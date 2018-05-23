namespace DocTrack
{
    partial class FrmEditDoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditDoc));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.TxtSerialNum = new System.Windows.Forms.TextBox();
            this.TxtDistributionScope = new System.Windows.Forms.TextBox();
            this.TxtRemark = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.CboDocumentType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CboSecretLevel = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DtpCheckTime = new System.Windows.Forms.DateTimePicker();
            this.NumQuantity = new System.Windows.Forms.NumericUpDown();
            this.TxtISN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.documentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnTypeSetting = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.label1.Location = new System.Drawing.Point(68, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "标题:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.label2.Location = new System.Drawing.Point(68, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "文号:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.label3.Location = new System.Drawing.Point(68, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "密级:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.label4.Location = new System.Drawing.Point(44, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "来文份数:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.label5.Location = new System.Drawing.Point(44, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "分发范围:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.label6.Location = new System.Drawing.Point(68, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "备注:";
            // 
            // TxtTitle
            // 
            this.TxtTitle.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.TxtTitle.Location = new System.Drawing.Point(114, 57);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(253, 26);
            this.TxtTitle.TabIndex = 1;
            // 
            // TxtSerialNum
            // 
            this.TxtSerialNum.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.TxtSerialNum.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.TxtSerialNum.Location = new System.Drawing.Point(114, 90);
            this.TxtSerialNum.Name = "TxtSerialNum";
            this.TxtSerialNum.Size = new System.Drawing.Size(253, 26);
            this.TxtSerialNum.TabIndex = 2;
            // 
            // TxtDistributionScope
            // 
            this.TxtDistributionScope.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.TxtDistributionScope.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.TxtDistributionScope.Location = new System.Drawing.Point(114, 255);
            this.TxtDistributionScope.Name = "TxtDistributionScope";
            this.TxtDistributionScope.Size = new System.Drawing.Size(253, 26);
            this.TxtDistributionScope.TabIndex = 7;
            // 
            // TxtRemark
            // 
            this.TxtRemark.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.TxtRemark.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.TxtRemark.Location = new System.Drawing.Point(114, 288);
            this.TxtRemark.Name = "TxtRemark";
            this.TxtRemark.Size = new System.Drawing.Size(253, 26);
            this.TxtRemark.TabIndex = 8;
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.Location = new System.Drawing.Point(113, 349);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(82, 37);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "保存";
            this.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.BtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancel.Image")));
            this.BtnCancel.Location = new System.Drawing.Point(212, 349);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(82, 37);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "关闭";
            this.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // CboDocumentType
            // 
            this.CboDocumentType.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.CboDocumentType.FormattingEnabled = true;
            this.CboDocumentType.Location = new System.Drawing.Point(114, 158);
            this.CboDocumentType.Name = "CboDocumentType";
            this.CboDocumentType.Size = new System.Drawing.Size(253, 28);
            this.CboDocumentType.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.label7.Location = new System.Drawing.Point(68, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "类型:";
            // 
            // CboSecretLevel
            // 
            this.CboSecretLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboSecretLevel.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.CboSecretLevel.FormattingEnabled = true;
            this.CboSecretLevel.Items.AddRange(new object[] {
            "无密级",
            "秘密",
            "机密",
            "绝密"});
            this.CboSecretLevel.Location = new System.Drawing.Point(114, 190);
            this.CboSecretLevel.Name = "CboSecretLevel";
            this.CboSecretLevel.Size = new System.Drawing.Size(253, 28);
            this.CboSecretLevel.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.label8.Location = new System.Drawing.Point(68, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "时间:";
            // 
            // DtpCheckTime
            // 
            this.DtpCheckTime.CustomFormat = "yyyy/MM/dd HH:mm";
            this.DtpCheckTime.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.DtpCheckTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpCheckTime.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.DtpCheckTime.Location = new System.Drawing.Point(114, 21);
            this.DtpCheckTime.Name = "DtpCheckTime";
            this.DtpCheckTime.Size = new System.Drawing.Size(253, 26);
            this.DtpCheckTime.TabIndex = 0;
            // 
            // NumQuantity
            // 
            this.NumQuantity.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.NumQuantity.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.NumQuantity.Location = new System.Drawing.Point(114, 223);
            this.NumQuantity.Name = "NumQuantity";
            this.NumQuantity.Size = new System.Drawing.Size(253, 26);
            this.NumQuantity.TabIndex = 6;
            // 
            // TxtISN
            // 
            this.TxtISN.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.TxtISN.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TxtISN.Location = new System.Drawing.Point(114, 122);
            this.TxtISN.Name = "TxtISN";
            this.TxtISN.Size = new System.Drawing.Size(253, 26);
            this.TxtISN.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.label9.Location = new System.Drawing.Point(54, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "机传号:";
            // 
            // BtnTypeSetting
            // 
            this.BtnTypeSetting.Image = ((System.Drawing.Image)(resources.GetObject("BtnTypeSetting.Image")));
            this.BtnTypeSetting.Location = new System.Drawing.Point(369, 160);
            this.BtnTypeSetting.Name = "BtnTypeSetting";
            this.BtnTypeSetting.Size = new System.Drawing.Size(24, 24);
            this.BtnTypeSetting.TabIndex = 21;
            this.BtnTypeSetting.UseVisualStyleBackColor = true;
            this.BtnTypeSetting.Click += new System.EventHandler(this.BtnTypeSetting_Click);
            // 
            // FrmEditDoc
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(439, 412);
            this.Controls.Add(this.BtnTypeSetting);
            this.Controls.Add(this.TxtISN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NumQuantity);
            this.Controls.Add(this.DtpCheckTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CboSecretLevel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CboDocumentType);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtRemark);
            this.Controls.Add(this.TxtDistributionScope);
            this.Controls.Add(this.TxtSerialNum);
            this.Controls.Add(this.TxtTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditDoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "登记新公文";
            this.Load += new System.EventHandler(this.FrmEditDoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.TextBox TxtSerialNum;
        private System.Windows.Forms.TextBox TxtDistributionScope;
        private System.Windows.Forms.TextBox TxtRemark;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ComboBox CboDocumentType;
        private System.Windows.Forms.BindingSource documentTypeBindingSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CboSecretLevel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DtpCheckTime;
        private System.Windows.Forms.NumericUpDown NumQuantity;
        private System.Windows.Forms.TextBox TxtISN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnTypeSetting;
    }
}