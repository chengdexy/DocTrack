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
            this.documentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NumQuantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.documentTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "标题:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "文号:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "密级:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "来文份数:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "分发范围:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "备注:";
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(114, 57);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(253, 21);
            this.TxtTitle.TabIndex = 6;
            // 
            // TxtSerialNum
            // 
            this.TxtSerialNum.Location = new System.Drawing.Point(114, 90);
            this.TxtSerialNum.Name = "TxtSerialNum";
            this.TxtSerialNum.Size = new System.Drawing.Size(253, 21);
            this.TxtSerialNum.TabIndex = 7;
            // 
            // TxtDistributionScope
            // 
            this.TxtDistributionScope.Location = new System.Drawing.Point(114, 220);
            this.TxtDistributionScope.Name = "TxtDistributionScope";
            this.TxtDistributionScope.Size = new System.Drawing.Size(253, 21);
            this.TxtDistributionScope.TabIndex = 10;
            // 
            // TxtRemark
            // 
            this.TxtRemark.Location = new System.Drawing.Point(114, 253);
            this.TxtRemark.Name = "TxtRemark";
            this.TxtRemark.Size = new System.Drawing.Size(253, 21);
            this.TxtRemark.TabIndex = 11;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(211, 324);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 12;
            this.BtnSave.Text = "保存";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(292, 324);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 13;
            this.BtnCancel.Text = "关闭";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // CboDocumentType
            // 
            this.CboDocumentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDocumentType.FormattingEnabled = true;
            this.CboDocumentType.Location = new System.Drawing.Point(114, 123);
            this.CboDocumentType.Name = "CboDocumentType";
            this.CboDocumentType.Size = new System.Drawing.Size(253, 20);
            this.CboDocumentType.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "类型:";
            // 
            // CboSecretLevel
            // 
            this.CboSecretLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboSecretLevel.FormattingEnabled = true;
            this.CboSecretLevel.Items.AddRange(new object[] {
            "无密级",
            "秘密",
            "机密",
            "绝密"});
            this.CboSecretLevel.Location = new System.Drawing.Point(114, 155);
            this.CboSecretLevel.Name = "CboSecretLevel";
            this.CboSecretLevel.Size = new System.Drawing.Size(253, 20);
            this.CboSecretLevel.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "时间:";
            // 
            // DtpCheckTime
            // 
            this.DtpCheckTime.CustomFormat = "yyyy/MM/dd HH:mm";
            this.DtpCheckTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpCheckTime.Location = new System.Drawing.Point(114, 21);
            this.DtpCheckTime.Name = "DtpCheckTime";
            this.DtpCheckTime.Size = new System.Drawing.Size(253, 21);
            this.DtpCheckTime.TabIndex = 18;
            // 
            // NumQuantity
            // 
            this.NumQuantity.Location = new System.Drawing.Point(114, 188);
            this.NumQuantity.Name = "NumQuantity";
            this.NumQuantity.Size = new System.Drawing.Size(253, 21);
            this.NumQuantity.TabIndex = 19;
            // 
            // FrmEditDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 393);
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
            ((System.ComponentModel.ISupportInitialize)(this.documentTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumQuantity)).EndInit();
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
    }
}