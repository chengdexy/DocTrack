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
    public partial class FrmType : Form
    {
        public FrmType()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmType_Load(object sender, EventArgs e)
        {
            SetupList();
        }

        private void SetupList()
        {
            List<DocumentType> types = DocumentControl.GetDocTypeList();
            LstTypes.DataSource = types;
            LstTypes.DisplayMember = "Name";
            LstTypes.ValueMember = "ID";
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int id = (int)LstTypes.SelectedValue;
            if (!DocumentControl.CheckTypeUsing(id))
            {
                //没被使用可以删除
                DocumentControl.DeleteDocType(id);
                SetupList();
            }
            else
            {
                MessageBox.Show($"{LstTypes.Text}已被使用,全部修改后才可以删除.");
            }
        }
    }
}
