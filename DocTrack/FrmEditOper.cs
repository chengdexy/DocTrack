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
            this.Text = $"新增操作: 流程-{_id}";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CheckValues())
            {
                CirculationOperation oper = new CirculationOperation
                {
                    HappenTime = DtpHappenTime.Value,
                    HandmanName = TxtHandman.Text.Trim(),
                    TargetName = TxtTarget.Text.Trim(),
                    OperationType = (OperationType)Enum.Parse(typeof(OperationType), CboOperationType.SelectedIndex.ToString()),
                    Remark = TxtRemark.Text.Trim()
                };
                DocumentControl.AddNewOperation(_id, oper);
                Close();
            }
        }

        private bool CheckValues()
        {
            if (string.IsNullOrEmpty(CboOperationType.Text))
            {
                MessageBox.Show("请选择操作类型", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CboOperationType.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(TxtHandman.Text))
            {
                MessageBox.Show("请输入经手人", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtHandman.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(TxtTarget.Text))
            {
                MessageBox.Show("请输入目标人", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtTarget.Focus();
                return false;
            }
            return true;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
