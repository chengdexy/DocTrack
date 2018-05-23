using DocTrack.BLL;
using DocTrack.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocTrack
{
    public partial class FrmMain : Form
    {
        //构造
        public FrmMain()
        {
            DocumentControl.CheckDb();
            InitializeComponent();
        }
        //更改布局以适应当前窗体大小
        private void FormatGroups()
        {
            //int solidHeight = MenuStrip.Height;  //菜单栏加工具栏的高
            //panel1.Width = ClientRectangle.Width / 2;
            //panel1.Left = 0;
            //panel1.Top = solidHeight;
            //panel1.Height = ClientRectangle.Height - solidHeight;
            //panel2.Width = ClientRectangle.Width / 2;
            //panel2.Height = panel1.Height / 2;
            //panel2.Top = panel1.Top;
            //panel2.Left = panel1.Left + panel1.Width;
            //panel3.Width = ClientRectangle.Width / 2;
            //panel3.Height = panel2.Height;
            //panel3.Top = panel2.Top + panel2.Height;
            //panel3.Left = panel2.Left;
            flowLayoutPanel3.Width = flowLayoutPanel1.Width;
            flowLayoutPanel3.Height = flowLayoutPanel1.Height - flowLayoutPanel2.Height;
            panel1.Width = flowLayoutPanel3.Width / 2;
            panel1.Height = flowLayoutPanel3.Height;
            flowLayoutPanel4.Width = panel1.Width;
            flowLayoutPanel4.Height = panel1.Height;
            panel2.Width = flowLayoutPanel4.Width;
            panel2.Height = flowLayoutPanel4.Height / 2;
            panel3.Width = panel2.Width;
            panel3.Height = panel2.Height;
        }
        //向DataGridView填充数据
        private void PopulateDataGridView()
        {
            //嵌套调用 ShowDocs()=>ShowViews()=>ShowOpers()
            //展示已存的数据
            TxtSearch.Text = "";
            ShowDocs("", 0, 0, 0);
        }
        private void ShowDocs(string filter, int slcDocID, int slcSubID, int slcOperID)
        {
            var docList = string.IsNullOrEmpty(filter) ? DocumentControl.GetDocuments() : DocumentControl.GetDocuments(filter);
            DgvDocument.Rows.Clear();
            if (docList != null && docList.Count > 0)
            {
                int i = 1;
                docList.ForEach(doc =>
                {
                    DgvDocument.Rows.Add(doc.ID, i, doc.Title, doc.ISN, doc.SerialNumber, doc.CheckTime, doc.DocumentType.Name, doc.SecretLevel, doc.Quantity, doc.DistributionScope, doc.Remark);
                    i++;
                });
                if (slcDocID < DgvDocument.RowCount)
                {
                    DgvDocument.Rows[slcDocID].Selected = true;
                }
                int docID = Convert.ToInt32(DgvDocument.SelectedRows[0].Cells["colID"].Value);
                ShowViews(docID, slcSubID, slcOperID);
            }
        }
        private void ShowViews(int docID, int slcSubID, int slcOperID)
        {
            var doc = DocumentControl.GetDocumentWithDetails(docID);
            var viewList = ViewFactory.DocToViews(doc);
            DgvSubDoc.Rows.Clear();
            if (viewList != null && viewList.Count > 0)
            {
                viewList.ForEach(view =>
                    {
                        int rowID = DgvSubDoc.Rows.Add(
                            view.ID,
                            view.LastOperTime,
                            view.HandmanName,
                            view.OperationType,
                            view.TargetName
                            );
                        switch (view.OperationType)
                        {
                            case Common.OperationType.传出至:
                                DgvSubDoc.Rows[rowID].Cells["colViewID"].Style.BackColor = Color.Yellow;
                                DgvSubDoc.Rows[rowID].Cells["colViewID"].Style.SelectionBackColor = Color.Yellow;
                                DgvSubDoc.Rows[rowID].Cells["colViewID"].Style.SelectionForeColor = Color.Black;
                                break;
                            case Common.OperationType.收回自:
                                DgvSubDoc.Rows[rowID].Cells["colViewID"].Style.BackColor = Color.LightPink;
                                DgvSubDoc.Rows[rowID].Cells["colViewID"].Style.SelectionForeColor = Color.Black;
                                DgvSubDoc.Rows[rowID].Cells["colViewID"].Style.SelectionBackColor = Color.LightPink;
                                break;
                            case Common.OperationType.已归档:
                                DgvSubDoc.Rows[rowID].Cells["colViewID"].Style.BackColor = Color.LightGreen;
                                DgvSubDoc.Rows[rowID].Cells["colViewID"].Style.SelectionForeColor = Color.Black;
                                DgvSubDoc.Rows[rowID].Cells["colViewID"].Style.SelectionBackColor = Color.LightGreen;
                                break;
                            case Common.OperationType.未开始:
                                break;
                            default:
                                break;
                        }
                    });
                DgvSubDoc.Rows[slcSubID].Selected = true;
                int viewID = Convert.ToInt32(DgvSubDoc.SelectedRows[0].Cells["colViewID"].Value);
                ShowOpers(viewID, slcOperID);
            }
            else
            {
                ShowOpers(0, slcOperID);
            }
        }
        private void ShowOpers(int viewID, int slcOperID)
        {
            var operList = DocumentControl.GetOperBySubID(viewID);
            DgvOper.Rows.Clear();
            if (operList != null && operList.Count > 0)
            {
                int i = 1;
                operList.ForEach(oper =>
                {
                    DgvOper.Rows.Add(oper.ID, i, oper.HappenTime, oper.HandmanName, oper.OperationType, oper.TargetName, oper.Remark);
                    i++;
                });
                if (slcOperID < DgvOper.RowCount)
                {
                    DgvOper.Rows[slcOperID].Selected = true;
                }
            }
        }
        //Load事件
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //IME设置
            TxtSearch.ImeMode = ImeMode.OnHalf;
            //初始化布局
            FormatGroups();
            PopulateDataGridView();
        }
        //按文号查询按钮
        private void BtnQuery_Click(object sender, EventArgs e)
        {
            //string serialNum = TxtLocateSerialNumber.Text.Trim();
            //for (int i = 0; i < DgvDocument.Rows.Count; i++)
            //{
            //    if (DgvDocument.Rows[i].Cells["colSerialNumber"].Value.ToString().IndexOf(serialNum) != -1)
            //    {
            //        DgvDocument.Rows[i].Selected = true;
            //    }
            //}
        }
        private void FrmMain_Resize(object sender, EventArgs e)
        {
            FormatGroups();
        }
        //点击DgvDocument
        private void DgvDocument_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DgvDocument.Rows.Count > 0 && DgvDocument.SelectedRows != null)
            {
                if (e.Button == MouseButtons.Left)    //点击左键
                {
                    int docID = Convert.ToInt32(DgvDocument.SelectedRows[0].Cells["colID"].Value);
                    ShowViews(docID, 0, 0);
                }
                else if (e.Button == MouseButtons.Right)  //点击右键
                {
                    if (e.RowIndex != -1)
                    {
                        DgvDocument.Rows[e.RowIndex].Selected = true;
                    }
                }

            }
        }
        private void DgvDocument_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CtxMenuDoc.Show(MousePosition.X, MousePosition.Y);
            }
        }
        //点击DgvSubDoc
        private void DgvSubDoc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DgvSubDoc.Rows.Count > 0 && DgvSubDoc.SelectedRows != null)
            {
                if (e.Button == MouseButtons.Left)
                {
                    int viewID = Convert.ToInt32(DgvSubDoc.SelectedRows[0].Cells["colViewID"].Value);
                    ShowOpers(viewID, 0);
                }
                else if (e.Button == MouseButtons.Right)
                {
                    if (e.RowIndex != -1)
                    {
                        DgvSubDoc.Rows[e.RowIndex].Selected = true;
                    }
                }
            }
        }
        private void DgvSubDoc_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CtxMenuSub.Show(MousePosition.X, MousePosition.Y);
            }
        }
        //点击DgvOper
        private void DgvOper_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DgvOper.Rows.Count > 0 && DgvOper.SelectedRows != null)
            {
                if (e.Button == MouseButtons.Right)     //右键
                {
                    if (e.RowIndex != -1)
                    {
                        DgvOper.Rows[e.RowIndex].Selected = true;
                    }
                }
            }
        }
        private void DgvOper_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CtxMenuOper.Show(MousePosition.X, MousePosition.Y);
            }
        }
        //pop菜单项
        private void 删除公文ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DgvDocument.SelectedRows.Count == 0)
            {
                return;
            }
            string title = DgvDocument.SelectedRows[0].Cells["colTitle"].Value.ToString();
            int docID = Convert.ToInt32(DgvDocument.SelectedRows[0].Cells["colID"].Value);
            if (MessageBox.Show($"确定删除《{title}》吗?", "删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DocumentControl.DeleteDocument(docID);
            }
            PopulateDataGridView();
        }
        private void 修改内容ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DgvDocument.SelectedRows.Count == 0)
            {
                return;
            }
            int docID = Convert.ToInt32(DgvDocument.SelectedRows[0].Cells["colID"].Value);
            FrmEditDoc frm = new FrmEditDoc(docID);
            frm.ShowDialog();
            ShowDocs(
                "",
                DgvDocument.SelectedRows[0].Index,
                DgvSubDoc.RowCount > 0 ? DgvSubDoc.SelectedRows[0].Index : 0,
                DgvOper.RowCount > 0 ? DgvOper.SelectedRows[0].Index : 0
                );
        }
        private void 登记公文ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditDoc frm = new FrmEditDoc();
            frm.ShowDialog();
            ShowDocs("", DgvDocument.RowCount, 0, 0);
        }
        private void 新增流转ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //新增流转的逻辑是创建一个新的oper对象及其对应的一个sub对象到数据库
            //添加完成后刷新界面,即可获得想要的结果
            if (DgvDocument.SelectedRows.Count == 0)
            {
                return;
            }
            int docID = Convert.ToInt32(DgvDocument.SelectedRows[0].Cells["colID"].Value);
            DocumentControl.CreateNewSubDoc(docID);
            ShowDocs("", DgvDocument.SelectedRows[0].Index, DgvSubDoc.RowCount, 0);
        }
        private void 删除流转ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Todo:这里先实现功能,不考虑删除的前提条件
            //viewID是一个view的唯一识别,无视其所属的doc
            if (DgvDocument.SelectedRows.Count == 0 || DgvSubDoc.SelectedRows.Count == 0)
            {
                return;
            }
            int docID = Convert.ToInt32(DgvDocument.SelectedRows[0].Cells["colID"].Value);
            int viewID = Convert.ToInt32(DgvSubDoc.SelectedRows[0].Cells["colViewID"].Value);
            if (MessageBox.Show($"确定删除流转{viewID}吗?", "删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DocumentControl.DeleteSubDocById(viewID);
            }
            ShowViews(docID, 0, 0);
        }
        private void 新增操作ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DgvSubDoc.SelectedRows.Count == 0)
            {
                return;
            }
            //只需传递subdoc的id即可
            int viewID = Convert.ToInt32(DgvSubDoc.SelectedRows[0].Cells["colViewID"].Value);
            FrmEditOper frm = new FrmEditOper(viewID);
            frm.ShowDialog();
            ShowDocs("", DgvDocument.SelectedRows[0].Index, DgvSubDoc.SelectedRows[0].Index, DgvOper.RowCount);
            //PopulateDataGridView();
        }
        private void 删除操作ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DgvOper.SelectedRows.Count == 0 || DgvSubDoc.SelectedRows.Count == 0)
            {
                return;
            }
            //依据oper的id直接删除
            int operID = Convert.ToInt32(DgvOper.SelectedRows[0].Cells["colOperID"].Value);
            int viewID = Convert.ToInt32(DgvSubDoc.SelectedRows[0].Cells["colViewID"].Value);
            int operNum = Convert.ToInt32(DgvOper.SelectedRows[0].Cells["colOperNumber"].Value);
            string hand = DgvOper.SelectedRows[0].Cells["colOperHandman"].Value.ToString();
            if (hand == "系统")
            {
                return;
            }
            if (MessageBox.Show($"确定删除{operNum}号操作记录吗?", "删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DocumentControl.DeleteOperationById(operID);
                ShowDocs("", DgvDocument.SelectedRows[0].Index, DgvSubDoc.SelectedRows[0].Index, 0);
                //PopulateDataGridView();
            }
        }
        private void TxtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ShowDocs(TxtSearch.Text, 0, 0, 0);
                DgvDocument.Focus();
            }
        }
        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N && e.Modifiers == Keys.Control)         //Ctrl+N
            {
                登记公文ToolStripMenuItem_Click(null, null);
            }
            if (e.KeyCode == Keys.L && e.Modifiers == Keys.Control)         //Ctrl+L
            {
                新增流转ToolStripMenuItem_Click(null, null);
            }
            if (e.KeyCode == Keys.C && e.Modifiers == Keys.Control)         //Ctrl+L
            {
                新增操作ToolStripMenuItem_Click(null, null);
            }
            if (e.KeyCode == Keys.F && e.Modifiers == Keys.Control)         //Ctrl+L
            {
                PopulateDataGridView();
                TxtSearch.Focus();
            }
        }
    }
}
