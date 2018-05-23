namespace DocTrack
{
    partial class FrmType
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
            this.LstTypes = new System.Windows.Forms.ListBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstTypes
            // 
            this.LstTypes.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LstTypes.FormattingEnabled = true;
            this.LstTypes.ItemHeight = 20;
            this.LstTypes.Location = new System.Drawing.Point(0, 0);
            this.LstTypes.Name = "LstTypes";
            this.LstTypes.Size = new System.Drawing.Size(224, 244);
            this.LstTypes.TabIndex = 0;
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(138, 250);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 35);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "关闭";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(57, 250);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 35);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "删除";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // FrmType
            // 
            this.AcceptButton = this.BtnCancel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(225, 287);
            this.ControlBox = false;
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.LstTypes);
            this.Name = "FrmType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "管理公文类别";
            this.Load += new System.EventHandler(this.FrmType_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstTypes;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnDelete;
    }
}