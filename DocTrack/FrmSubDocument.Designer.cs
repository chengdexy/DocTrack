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
            // FrmSubDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}