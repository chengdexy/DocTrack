namespace DocTrack
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvDocument = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSecretLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDistributionScope = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtLocateSerialNumber = new System.Windows.Forms.TextBox();
            this.BtnQuery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDocument)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvDocument
            // 
            this.DgvDocument.AllowUserToAddRows = false;
            this.DgvDocument.AllowUserToDeleteRows = false;
            this.DgvDocument.AllowUserToOrderColumns = true;
            this.DgvDocument.AllowUserToResizeRows = false;
            this.DgvDocument.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvDocument.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DgvDocument.ColumnHeadersHeight = 40;
            this.DgvDocument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvDocument.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNumber,
            this.colTitle,
            this.colSerialNumber,
            this.colSecretLevel,
            this.colQuantity,
            this.colDistributionScope,
            this.colRemark});
            this.DgvDocument.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgvDocument.Location = new System.Drawing.Point(0, 0);
            this.DgvDocument.MultiSelect = false;
            this.DgvDocument.Name = "DgvDocument";
            this.DgvDocument.ReadOnly = true;
            this.DgvDocument.RowHeadersVisible = false;
            this.DgvDocument.RowTemplate.Height = 23;
            this.DgvDocument.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDocument.Size = new System.Drawing.Size(791, 399);
            this.DgvDocument.TabIndex = 0;
            this.DgvDocument.DoubleClick += new System.EventHandler(this.DgvDocument_DoubleClick);
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // colNumber
            // 
            this.colNumber.HeaderText = "序号";
            this.colNumber.Name = "colNumber";
            this.colNumber.ReadOnly = true;
            // 
            // colTitle
            // 
            this.colTitle.HeaderText = "文件标题";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            // 
            // colSerialNumber
            // 
            this.colSerialNumber.HeaderText = "文号";
            this.colSerialNumber.Name = "colSerialNumber";
            this.colSerialNumber.ReadOnly = true;
            // 
            // colSecretLevel
            // 
            this.colSecretLevel.HeaderText = "密级";
            this.colSecretLevel.Name = "colSecretLevel";
            this.colSecretLevel.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "份数";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            // 
            // colDistributionScope
            // 
            this.colDistributionScope.HeaderText = "分发范围";
            this.colDistributionScope.Name = "colDistributionScope";
            this.colDistributionScope.ReadOnly = true;
            // 
            // colRemark
            // 
            this.colRemark.HeaderText = "备注";
            this.colRemark.Name = "colRemark";
            this.colRemark.ReadOnly = true;
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(412, 415);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 1;
            this.BtnNew.Text = "登记";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "文号/电报号:";
            // 
            // TxtLocateSerialNumber
            // 
            this.TxtLocateSerialNumber.Location = new System.Drawing.Point(96, 420);
            this.TxtLocateSerialNumber.Name = "TxtLocateSerialNumber";
            this.TxtLocateSerialNumber.Size = new System.Drawing.Size(111, 21);
            this.TxtLocateSerialNumber.TabIndex = 3;
            // 
            // BtnQuery
            // 
            this.BtnQuery.Location = new System.Drawing.Point(214, 417);
            this.BtnQuery.Name = "BtnQuery";
            this.BtnQuery.Size = new System.Drawing.Size(75, 23);
            this.BtnQuery.TabIndex = 4;
            this.BtnQuery.Text = "查询";
            this.BtnQuery.UseVisualStyleBackColor = true;
            this.BtnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.BtnQuery);
            this.Controls.Add(this.TxtLocateSerialNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.DgvDocument);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDocument)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvDocument;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSecretLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDistributionScope;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtLocateSerialNumber;
        private System.Windows.Forms.Button BtnQuery;
    }
}

