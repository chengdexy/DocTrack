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

using static DocTrack.BLL.DocumentControl;

namespace DocTrack
{
    public partial class FrmDocument : Form
    {
        private int _editDocNum = 0;

        public FrmDocument()
        {
            InitializeComponent();
        }
        public FrmDocument(int DocumentID)
        {
            //编辑模式
            _editDocNum = DocumentID;
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            //Todo: validation check
            //if(checked)
            Document doc = new Document
            {
                ID = _editDocNum,
                Title = TxtTitle.Text,
                SerialNumber = TxtSerialNumber.Text,
                Quantity = Convert.ToInt32(TxtQuantity.Text),
                DistributionScope = TxtDistributionScope.Text,
                Remark = TxtRemark.Text
            };
            //Todo: change the txtSecret to a select list
            switch (Convert.ToInt32(TxtSecretLevel.Text))
            {
                case 0:
                    doc.SecretLevel = SecretLevel.None;
                    break;
                case 1:
                    doc.SecretLevel = SecretLevel.Low;
                    break;
                case 2:
                    doc.SecretLevel = SecretLevel.Normal;
                    break;
                case 3:
                    doc.SecretLevel = SecretLevel.High;
                    break;
            }
            if (doc.ID == 0)
            {
                AddNewDocument(doc);
            }
            else
            {
                UpdateDocument(doc);
            }
            Close();
        }

        private void FrmDocument_Load(object sender, EventArgs e)
        {
            var doc = GetDocumentById(_editDocNum);
            if (doc != null)
            {
                TxtTitle.Text = doc.Title;
                TxtSerialNumber.Text = doc.SerialNumber;
                TxtSecretLevel.Text = Convert.ToInt32(doc.SecretLevel).ToString();
                TxtDistributionScope.Text = doc.DistributionScope;
                TxtQuantity.Text = doc.Quantity.ToString();
                TxtRemark.Text = doc.Remark;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
