namespace DocTrack
{
    partial class FrmSubDocument
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
            this.DgvSubDoc = new System.Windows.Forms.DataGridView();
            this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHandman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTarget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSend = new System.Windows.Forms.Button();
            this.BtnReceive = new System.Windows.Forms.Button();
            this.BtnArchive = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSubDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvSubDoc
            // 
            this.DgvSubDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvSubDoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvSubDoc.ColumnHeadersHeight = 40;
            this.DgvSubDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvSubDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumber,
            this.colTime,
            this.colHandman,
            this.colState,
            this.colTarget});
            this.DgvSubDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgvSubDoc.Location = new System.Drawing.Point(0, 0);
            this.DgvSubDoc.Name = "DgvSubDoc";
            this.DgvSubDoc.ReadOnly = true;
            this.DgvSubDoc.RowHeadersVisible = false;
            this.DgvSubDoc.RowTemplate.Height = 23;
            this.DgvSubDoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSubDoc.Size = new System.Drawing.Size(800, 390);
            this.DgvSubDoc.TabIndex = 0;
            this.DgvSubDoc.DoubleClick += new System.EventHandler(this.DgvSubDoc_DoubleClick);
            // 
            // colNumber
            // 
            this.colNumber.HeaderText = "工作流";
            this.colNumber.Name = "colNumber";
            this.colNumber.ReadOnly = true;
            // 
            // colTime
            // 
            this.colTime.HeaderText = "时间";
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            // 
            // colHandman
            // 
            this.colHandman.HeaderText = "经手人";
            this.colHandman.Name = "colHandman";
            this.colHandman.ReadOnly = true;
            // 
            // colState
            // 
            this.colState.HeaderText = "操作";
            this.colState.Name = "colState";
            this.colState.ReadOnly = true;
            // 
            // colTarget
            // 
            this.colTarget.HeaderText = "目标人";
            this.colTarget.Name = "colTarget";
            this.colTarget.ReadOnly = true;
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(415, 410);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(75, 23);
            this.BtnSend.TabIndex = 1;
            this.BtnSend.Text = "传出";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // BtnReceive
            // 
            this.BtnReceive.Location = new System.Drawing.Point(496, 410);
            this.BtnReceive.Name = "BtnReceive";
            this.BtnReceive.Size = new System.Drawing.Size(75, 23);
            this.BtnReceive.TabIndex = 2;
            this.BtnReceive.Text = "收回";
            this.BtnReceive.UseVisualStyleBackColor = true;
            // 
            // BtnArchive
            // 
            this.BtnArchive.Location = new System.Drawing.Point(577, 410);
            this.BtnArchive.Name = "BtnArchive";
            this.BtnArchive.Size = new System.Drawing.Size(75, 23);
            this.BtnArchive.TabIndex = 3;
            this.BtnArchive.Text = "归档";
            this.BtnArchive.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(658, 410);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "关闭";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmSubDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnArchive);
            this.Controls.Add(this.BtnReceive);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.DgvSubDoc);
            this.Name = "FrmSubDocument";
            this.Text = "FrmSubDocument";
            this.Load += new System.EventHandler(this.FrmSubDocument_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSubDoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvSubDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHandman;
        private System.Windows.Forms.DataGridViewTextBoxColumn colState;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarget;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Button BtnReceive;
        private System.Windows.Forms.Button BtnArchive;
        private System.Windows.Forms.Button BtnCancel;
    }
}