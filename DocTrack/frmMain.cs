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
            PopulateDataGridView();
        }

        //向DataGridView填充数据
        private void PopulateDataGridView()
        {
            var docList = DocumentControl.GetDocuments();
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
        private void DgvDocument_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int editDocID = Convert.ToInt32(DgvDocument.SelectedRows[0].Cells["colID"].Value);
            var frm = new FrmDocument(editDocID);
            frm.ShowDialog();
            PopulateDataGridView();
        }
    }
}
