using DocTrack.BLL;
using DocTrack.Common;
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
    public partial class FrmEditOper : Form
    {
        private int _id = 0;

        //public FrmEditOper()
        //{
        //    InitializeComponent();
        //}

        public FrmEditOper(int viewID)
        {
            this._id = viewID;
            InitializeComponent();
        }

        private void FrmEditOper_Load(object sender, EventArgs e)
        {
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //Todo: 这里假定输入项全合法
            CirculationOperation oper = new CirculationOperation
            {
                HappenTime = DtpHappenTime.Value,
                HandmanName = TxtHandman.Text.Trim(),
                TargetName = TxtTarget.Text.Trim(),
                OperationType = (OperationType)Enum.Parse(typeof(OperationType), CboOperationType.SelectedIndex.ToString())
            };
            DocumentControl.AddNewOperation(_id, oper);
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
