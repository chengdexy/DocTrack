using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocTrack.BLL;
using DocTrack.Model;

namespace DocTrack
{
    public partial class FrmEditDoc : Form
    {
        private int _id = 0;

        public FrmEditDoc()
        {
            InitializeComponent();
        }

        public FrmEditDoc(int ID)
        {
            this._id = ID;
            InitializeComponent();
        }

        private void FrmEditDoc_Load(object sender, EventArgs e)
        {
            if (_id != 0)
            {
                Document doc = DocumentControl.GetDocumentById(_id);
                TxtTitle.Text = doc.Title;
                TxtSerialNum.Text = doc.SerialNumber;
                TxtSecretLevel.Text = doc.SecretLevel.ToString();
                TxtQuantity.Text = doc.Quantity.ToString();
                TxtDistributionScope.Text = doc.DistributionScope;
                TxtRemark.Text = doc.Remark;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //Todo: 假定文本框输入内容全部合法
            Document doc = new Document()
            {
                Title = TxtTitle.Text.Trim(),
                SerialNumber = TxtSerialNum.Text.Trim(),
                Quantity = Convert.ToInt32(TxtQuantity.Text.Trim()),
                DistributionScope = TxtDistributionScope.Text.Trim(),
                Remark = TxtRemark.Text.Trim(),
            };
            switch (TxtSecretLevel.Text.Trim())
            {
                case "None":
                    doc.SecretLevel = Common.SecretLevel.None;
                    break;
                case "Low":
                    doc.SecretLevel = Common.SecretLevel.Low;
                    break;
                case "Normal":
                    doc.SecretLevel = Common.SecretLevel.Normal;
                    break;
                case "High":
                    doc.SecretLevel = Common.SecretLevel.High;
                    break;
                default:
                    throw new Exception("错误的密级参数被传入!FrmEditDoc.cs 第70行");
            }
            if (_id == 0)
            {
                //新增模式
                DocumentControl.AddNewDocument(doc);
            }
            else
            {
                //编辑模式
                doc.ID = _id;
                DocumentControl.UpdateDocument(doc);
            }
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
