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
                HappenTime = Convert.ToDateTime(TxtHappenTime.Text.Trim()),
                HandmanName = TxtHandman.Text.Trim(),
                TargetName = TxtTarget.Text.Trim()
            };
            int operNum = Convert.ToInt32(TxtOperationType.Text.Trim());
            switch (operNum)
            {
                case 0:
                    oper.OperationType = Common.OperationType.Send;
                    break;
                case 1:
                    oper.OperationType = Common.OperationType.Receive;
                    break;
                case 2:
                    oper.OperationType = Common.OperationType.Over;
                    break;
                case 999:
                    oper.OperationType = Common.OperationType.New;
                    break;
                default:
                    throw new Exception($"不存在的操作标识号[{operNum.ToString()}]被传入. frmeditoper.cs, 58行");
            }

            DocumentControl.AddNewOperation(_id, oper);
            Close();
        }
    }
}
