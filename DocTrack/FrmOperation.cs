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
    public partial class FrmOperation : Form
    {
        private int _id = 0;

        public FrmOperation()
        {
            InitializeComponent();
        }

        public FrmOperation(int docViewID)
        {
            _id = docViewID;
            InitializeComponent();
        }

        private void FrmOperation_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            if (_id != 0)
            {
                var operList = DocumentControl.GetOperBySubID(_id);
                DgvOper.Rows.Clear();
                int i = 1;
                operList.ForEach(oper =>
                {
                    DgvOper.Rows.Add(oper.ID, i, oper.HappenTime, oper.HandmanName, oper.OperationType, oper.TargetName);
                });
            }

        }
    }
}
