namespace DocTrack
{
    partial class FrmEditOper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditOper));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtHandman = new System.Windows.Forms.TextBox();
            this.TxtTarget = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.CboOperationType = new System.Windows.Forms.ComboBox();
            this.DtpHappenTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "操作类型:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "经手人:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "目标人:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "发生时间:";
            // 
            // TxtHandman
            // 
            this.TxtHandman.Location = new System.Drawing.Point(129, 87);
            this.TxtHandman.Name = "TxtHandman";
            this.TxtHandman.Size = new System.Drawing.Size(179, 21);
            this.TxtHandman.TabIndex = 5;
            // 
            // TxtTarget
            // 
            this.TxtTarget.Location = new System.Drawing.Point(129, 131);
            this.TxtTarget.Name = "TxtTarget";
            this.TxtTarget.Size = new System.Drawing.Size(179, 21);
            this.TxtTarget.TabIndex = 6;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(152, 245);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "保存";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(233, 245);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "关闭";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // CboOperationType
            // 
            this.CboOperationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboOperationType.FormattingEnabled = true;
            this.CboOperationType.Items.AddRange(new object[] {
            "传出",
            "收回",
            "归档"});
            this.CboOperationType.Location = new System.Drawing.Point(129, 43);
            this.CboOperationType.Name = "CboOperationType";
            this.CboOperationType.Size = new System.Drawing.Size(179, 20);
            this.CboOperationType.TabIndex = 10;
            // 
            // DtpHappenTime
            // 
            this.DtpHappenTime.CustomFormat = "yyyy/MM/dd HH:mm";
            this.DtpHappenTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpHappenTime.Location = new System.Drawing.Point(129, 172);
            this.DtpHappenTime.Name = "DtpHappenTime";
            this.DtpHappenTime.Size = new System.Drawing.Size(179, 21);
            this.DtpHappenTime.TabIndex = 11;
            // 
            // FrmEditOper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 318);
            this.Controls.Add(this.DtpHappenTime);
            this.Controls.Add(this.CboOperationType);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtTarget);
            this.Controls.Add(this.TxtHandman);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditOper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmEditOper";
            this.Load += new System.EventHandler(this.FrmEditOper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtHandman;
        private System.Windows.Forms.TextBox TxtTarget;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ComboBox CboOperationType;
        private System.Windows.Forms.DateTimePicker DtpHappenTime;
    }
}