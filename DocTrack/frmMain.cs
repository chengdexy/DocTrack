using DocTrack.BLL;
using DocTrack.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //初始化布局
            FormatGroups();
            PopulateDataGridView();
        }

        //更改布局以适应当前窗体大小
        private void FormatGroups()
        {
            //int solidHeight = ToolStrip.Height + MenuStrip.Height;  //菜单栏加工具栏的高
            panel1.Width = ClientRectangle.Width / 2;
            panel1.Left = 0;
            panel1.Top = MenuStrip.Height;
            panel1.Height = ClientRectangle.Height - StatusStrip.Height - MenuStrip.Height;
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
            ShowDocs(0);
        }

        private void ShowDocs(int rowID)
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
                DgvDocument.Rows[rowID].Selected = true;
                int docID = Convert.ToInt32(DgvDocument.Rows[rowID].Cells["colID"].Value);
                ShowViews(docID, 0);
            }
        }

        private void ShowViews(int docID, int rowID)
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
                DgvSubDoc.Rows[rowID].Selected = true;
                int viewID = Convert.ToInt32(DgvSubDoc.Rows[rowID].Cells["colViewID"].Value);
                ShowOpers(viewID, 0);
            }
        }

        private void ShowOpers(int viewID, int rowID)
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
                DgvOper.Rows[rowID].Selected = true;
            }
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

        private void DgvDocument_Click(object sender, EventArgs e)
        {
            //todo:点击的是否有效数据行,是否是当前选中行
            if (DgvDocument.SelectedRows != null)
            {
                int docID = Convert.ToInt32(DgvDocument.SelectedRows[0].Cells["colID"].Value);
                ShowViews(docID, 0);
            }

        }

        private void DgvSubDoc_Click(object sender, EventArgs e)
        {
            if (DgvSubDoc.SelectedRows != null)
            {
                int viewID = Convert.ToInt32(DgvSubDoc.SelectedRows[0].Cells["colViewID"].Value);
                ShowOpers(viewID, 0);
            }
        }
    }
}
