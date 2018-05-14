using DocTrack.BLL;
using DocTrack.Model;
using DocTrack.VModel;
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
    public partial class FrmSubDocument : Form
    {
        private int _id;

        public FrmSubDocument(int id)
        {
            this._id = id;
            InitializeComponent();
        }

        private void FrmSubDocument_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            //填充数据到DGV
            Document doc = DocumentControl.GetDocumentWithDetails(_id);
            List<DocView> dvList = ViewFactory.DocToViews(doc);
            DgvSubDoc.Rows.Clear();
            dvList.ForEach(dv =>
            {
                DgvSubDoc.Rows.Add(
                    dv.ID,
                    dv.LastOperTime,
                    dv.HandmanName,
                    dv.OperationType,
                    dv.TargetName
                    );
            });
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            //是否选中合法项
            //if (SelectedDataRow())
            //{
            //    4
            //}
        }

        //判断当前选中行是否是数据行
        private bool SelectedDataRow()
        {
            if (DgvSubDoc.SelectedRows.Count > 0 &&
                DgvSubDoc.SelectedRows[0].Index >= 0 &&
                DgvSubDoc.SelectedRows[0].Index < DgvSubDoc.RowCount - 1)
            {
                return true;

            }
            return false;
        }

        //双击数据行
        private void DgvSubDoc_DoubleClick(object sender, EventArgs e)
        {
            if (SelectedDataRow())
            {
                int docViewID = Convert.ToInt32(DgvSubDoc.SelectedRows[0].Cells["colNumber"].Value);
                FrmOperation frm = new FrmOperation(docViewID);
                frm.ShowDialog();
                PopulateDataGridView();
            }
        }
    }
}
