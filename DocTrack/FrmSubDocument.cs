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
    }
}
