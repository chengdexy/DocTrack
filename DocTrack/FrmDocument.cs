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
    public partial class FrmDocument : Form
    {
        public FrmDocument()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Todo: validation check
            //if(checked)
            Document doc = new Document
            {
                Title = TxtTitle.Text,
                SerialNumber = TxtSerialNumber.Text,
                Quantity = Convert.ToInt32(TxtQuantity.Text),
                DistributionScope = TxtDistributionScope.Text,
                Remark = TxtRemark.Text
            };
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
            DocumentControl.AddNewDocument(doc);
            this.Close();
        }
    }
}
