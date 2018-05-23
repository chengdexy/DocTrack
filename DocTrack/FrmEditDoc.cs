﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocTrack.BLL;
using DocTrack.Common;
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
            //初始化文件类型下拉框
            CboDocumentType.DataSource = DocumentControl.GetDocTypeList();
            CboDocumentType.DisplayMember = "Name";
            //编辑模式填充数据
            if (_id != 0)
            {
                Document doc = DocumentControl.GetDocumentById(_id);
                TxtTitle.Text = doc.Title;
                TxtSerialNum.Text = doc.SerialNumber;
                CboSecretLevel.SelectedIndex = (int)doc.SecretLevel;
                NumQuantity.Value = doc.Quantity;
                TxtDistributionScope.Text = doc.DistributionScope;
                TxtRemark.Text = doc.Remark;
                CboDocumentType.SelectedItem = doc.DocumentType;
                DtpCheckTime.Value = doc.CheckTime;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            if (CheckValues())
            {
                Document doc = new Document()
                {
                    Title = TxtTitle.Text.Trim(),
                    SerialNumber = TxtSerialNum.Text.Trim(),
                    Quantity = Convert.ToInt32(NumQuantity.Value),
                    DistributionScope = TxtDistributionScope.Text.Trim(),
                    Remark = TxtRemark.Text.Trim(),
                    DocumentType = (DocumentType)CboDocumentType.SelectedItem,
                    SecretLevel = (SecretLevel)Enum.Parse(typeof(SecretLevel), CboSecretLevel.SelectedIndex.ToString()),
                    CheckTime = DtpCheckTime.Value
                };
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
        }

        private bool CheckValues()
        {
            if (string.IsNullOrEmpty(CboDocumentType.Text))
            {
                MessageBox.Show("请选择文件类型", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CboDocumentType.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(CboSecretLevel.Text))
            {
                MessageBox.Show("请选择文件密级", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CboSecretLevel.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(TxtTitle.Text))
            {
                MessageBox.Show("请输入文件标题", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtTitle.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(TxtSerialNum.Text))
            {
                MessageBox.Show("请输入文号或电报号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtSerialNum.Focus();
                return false;
            }
            if (NumQuantity.Value <= 0)
            {
                MessageBox.Show("来文份数应为大于0的整数", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NumQuantity.Focus();
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
