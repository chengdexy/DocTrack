namespace DocTrack
{
    partial class FrmOperation
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
            this.DgvOper = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHandman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTarget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOper)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvOper
            // 
            this.DgvOper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvOper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvOper.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNumber,
            this.colTime,
            this.colHandman,
            this.colType,
            this.colTarget});
            this.DgvOper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgvOper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvOper.Location = new System.Drawing.Point(0, 0);
            this.DgvOper.MultiSelect = false;
            this.DgvOper.Name = "DgvOper";
            this.DgvOper.ReadOnly = true;
            this.DgvOper.RowHeadersVisible = false;
            this.DgvOper.RowTemplate.Height = 23;
            this.DgvOper.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvOper.Size = new System.Drawing.Size(800, 450);
            this.DgvOper.TabIndex = 0;
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
            // colType
            // 
            this.colType.HeaderText = "操作";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colTarget
            // 
            this.colTarget.HeaderText = "目标人";
            this.colTarget.Name = "colTarget";
            this.colTarget.ReadOnly = true;
            // 
            // FrmOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvOper);
            this.Name = "FrmOperation";
            this.Text = "FrmOperation";
            this.Load += new System.EventHandler(this.FrmOperation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvOper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvOper;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHandman;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarget;
    }
}