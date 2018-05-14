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

            groupBox1.Width = ClientRectangle.Width / 2;
            groupBox1.Left = 0;
            groupBox1.Top = 0;
            groupBox1.Height = ClientRectangle.Height;
            groupBox2.Width = ClientRectangle.Width / 2;
            groupBox2.Height = groupBox1.Height / 2;
            groupBox2.Top = groupBox1.Top;
            groupBox2.Left = groupBox1.Left + groupBox1.Width;
            groupBox3.Width = ClientRectangle.Width / 2;
            groupBox3.Height = groupBox2.Height;
            groupBox3.Top = groupBox2.Top + groupBox2.Height;
            groupBox3.Left = groupBox2.Left;
        }

        //向DataGridView填充数据
        private void PopulateDataGridView()
        {
            var docList = GetDocuments();
            DgvDocument.Rows.Clear();
            int i = 1;
            docList.ForEach(doc =>
            {
                DgvDocument.Rows.Add(doc.ID, i, doc.Title, doc.SerialNumber, doc.SecretLevel, doc.Quantity, doc.DistributionScope, doc.Remark);
                i++;
            });
        }

        //登记按钮
        private void BtnNew_Click(object sender, EventArgs e)
        {
            FrmDocument frm = new FrmDocument();
            frm.ShowDialog();
            PopulateDataGridView();
        }

        //双击数据表中某行
        private void DgvDocument_DoubleClick(object sender, EventArgs e)
        {
            if (DgvDocument.SelectedRows.Count > 0)
            {
                int editDocID = Convert.ToInt32(DgvDocument.SelectedRows[0].Cells["colID"].Value);
                var frm = new FrmDocument(editDocID);
                frm.ShowDialog();
                PopulateDataGridView();
            }
        }

        //按文号查询按钮
        private void BtnQuery_Click(object sender, EventArgs e)
        {
            string serialNum = TxtLocateSerialNumber.Text.Trim();
            for (int i = 0; i < DgvDocument.Rows.Count; i++)
            {
                if (DgvDocument.Rows[i].Cells["colSerialNumber"].Value.ToString().IndexOf(serialNum) != -1)
                {
                    DgvDocument.Rows[i].Selected = true;
                }
            }
        }

        private void BtnOper_Click(object sender, EventArgs e)
        {
            //是否选了某行
            if (DgvDocument.SelectedRows.Count > 0)
            {
                int selectedID = Convert.ToInt32(DgvDocument.SelectedRows[0].Cells["colID"].Value);
                //打开该文档对应子文档列表
                var frm = new FrmSubDocument(selectedID);
                frm.ShowDialog();
                PopulateDataGridView();
            }
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            FormatGroups();
        }
    }
}
