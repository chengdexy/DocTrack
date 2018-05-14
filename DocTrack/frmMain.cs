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

using static DocTrack.BLL.DocumentControl;

namespace DocTrack
{
    public partial class FrmMain : Form
    {
        //构造
        public FrmMain()
        {
            InitializeComponent();
        }
        //更改布局以适应当前窗体大小
        private void FormatGroups()
        {
            int solidHeight = ToolStrip.Height + MenuStrip.Height;  //菜单栏加工具栏的高
            panel1.Width = ClientRectangle.Width / 2;
            panel1.Left = 0;
            panel1.Top = solidHeight;
            panel1.Height = ClientRectangle.Height - solidHeight;
            panel2.Width = ClientRectangle.Width / 2;
            panel2.Height = panel1.Height / 2;
            panel2.Top = panel1.Top;
            panel2.Left = panel1.Left + panel1.Width;
            panel3.Width = ClientRectangle.Width / 2;
            panel3.Height = panel2.Height;
            panel3.Top = panel2.Top + panel2.Height;
            panel3.Left = panel2.Left;
        }
        //向DataGridView填充数据
        private void PopulateDataGridView()
        {
            //嵌套调用 ShowDocs()=>ShowViews()=>ShowOpers()
            //展示已存的数据
            ShowDocs();
        }
        private void ShowDocs()
        {
            var docList = GetDocuments();
            DgvDocument.Rows.Clear();
            if (docList != null)
            {
                int i = 1;
                docList.ForEach(doc =>
                {
                    DgvDocument.Rows.Add(doc.ID, i, doc.Title, doc.SerialNumber, doc.SecretLevel, doc.Quantity, doc.DistributionScope, doc.Remark);
                    i++;
                });
                DgvDocument.Rows[0].Selected = true;
                int docID = Convert.ToInt32(DgvDocument.Rows[0].Cells["colID"].Value);
                ShowViews(docID);
            }
        }
        private void ShowViews(int docID)
        {
            var doc = DocumentControl.GetDocumentWithDetails(docID);
            var viewList = ViewFactory.DocToViews(doc);
            DgvSubDoc.Rows.Clear();
            if (viewList != null)
            {
                viewList.ForEach(view =>
                    {
                        DgvSubDoc.Rows.Add(
                            view.ID,
                            view.LastOperTime,
                            view.HandmanName,
                            view.OperationType,
                            view.TargetName
                            );
                    });
                DgvSubDoc.Rows[0].Selected = true;
                int viewID = Convert.ToInt32(DgvSubDoc.Rows[0].Cells["colViewID"].Value);
                ShowOpers(viewID);
            }
        }
        private void ShowOpers(int viewID)
        {
            var operList = DocumentControl.GetOperBySubID(viewID);
            if (operList != null)
            {
                DgvOper.Rows.Clear();
                int i = 1;
                operList.ForEach(oper =>
                {
                    DgvOper.Rows.Add(oper.ID, i, oper.HappenTime, oper.HandmanName, oper.OperationType, oper.TargetName);
                });
                DgvOper.Rows[0].Selected = true;
            }
        }
        //Load事件
        private void FrmMain_Load(object sender, EventArgs e)
        {
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
                    ShowViews(docID);
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
                    ShowOpers(viewID);
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
    }
}
