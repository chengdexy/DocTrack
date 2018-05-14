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
            this.components = new System.ComponentModel.Container();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvDocument = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSecretLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDistributionScope = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgvSubDoc = new System.Windows.Forms.DataGridView();
            this.colViewID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHandman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTarget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DgvOper = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.CtxMenuDoc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.登记公文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuSub = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CtxMenuOper = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新增流转ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDocument)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSubDoc)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOper)).BeginInit();
            this.CtxMenuDoc.SuspendLayout();
            this.CtxMenuSub.SuspendLayout();
            this.CtxMenuOper.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1008, 25);
            this.MenuStrip.TabIndex = 7;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // StatusStrip
            // 
            this.StatusStrip.Location = new System.Drawing.Point(0, 707);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(1008, 22);
            this.StatusStrip.TabIndex = 8;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgvDocument);
            this.panel1.Location = new System.Drawing.Point(131, 467);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 9;
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
            this.DgvDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvDocument.Location = new System.Drawing.Point(3, 3);
            this.DgvDocument.MultiSelect = false;
            this.DgvDocument.Name = "DgvDocument";
            this.DgvDocument.ReadOnly = true;
            this.DgvDocument.RowHeadersVisible = false;
            this.DgvDocument.RowTemplate.Height = 23;
            this.DgvDocument.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDocument.Size = new System.Drawing.Size(194, 94);
            this.DgvDocument.TabIndex = 1;
            this.DgvDocument.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvDocument_CellMouseClick);
            this.DgvDocument.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DgvDocument_MouseClick);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.DgvSubDoc);
            this.panel2.Location = new System.Drawing.Point(350, 467);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 10;
            // 
            // DgvSubDoc
            // 
            this.DgvSubDoc.AllowUserToAddRows = false;
            this.DgvSubDoc.AllowUserToDeleteRows = false;
            this.DgvSubDoc.AllowUserToOrderColumns = true;
            this.DgvSubDoc.AllowUserToResizeRows = false;
            this.DgvSubDoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvSubDoc.ColumnHeadersHeight = 40;
            this.DgvSubDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvSubDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colViewID,
            this.colTime,
            this.colHandman,
            this.colState,
            this.colTarget});
            this.DgvSubDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgvSubDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvSubDoc.Location = new System.Drawing.Point(0, 3);
            this.DgvSubDoc.MultiSelect = false;
            this.DgvSubDoc.Name = "DgvSubDoc";
            this.DgvSubDoc.ReadOnly = true;
            this.DgvSubDoc.RowHeadersVisible = false;
            this.DgvSubDoc.RowTemplate.Height = 23;
            this.DgvSubDoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSubDoc.Size = new System.Drawing.Size(197, 94);
            this.DgvSubDoc.TabIndex = 2;
            this.DgvSubDoc.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvSubDoc_CellMouseClick);
            this.DgvSubDoc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DgvSubDoc_MouseClick);
            // 
            // colViewID
            // 
            this.colViewID.HeaderText = "工作流";
            this.colViewID.Name = "colViewID";
            this.colViewID.ReadOnly = true;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.DgvOper);
            this.panel3.Location = new System.Drawing.Point(571, 467);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 11;
            // 
            // DgvOper
            // 
            this.DgvOper.AllowUserToAddRows = false;
            this.DgvOper.AllowUserToDeleteRows = false;
            this.DgvOper.AllowUserToOrderColumns = true;
            this.DgvOper.AllowUserToResizeRows = false;
            this.DgvOper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvOper.ColumnHeadersHeight = 40;
            this.DgvOper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvOper.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.colType,
            this.dataGridViewTextBoxColumn6});
            this.DgvOper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgvOper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvOper.Location = new System.Drawing.Point(0, 3);
            this.DgvOper.MultiSelect = false;
            this.DgvOper.Name = "DgvOper";
            this.DgvOper.ReadOnly = true;
            this.DgvOper.RowHeadersVisible = false;
            this.DgvOper.RowTemplate.Height = 23;
            this.DgvOper.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvOper.Size = new System.Drawing.Size(197, 94);
            this.DgvOper.TabIndex = 2;
            this.DgvOper.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvOper_CellMouseClick);
            this.DgvOper.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DgvOper_MouseClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "序号";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "时间";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "经手人";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.HeaderText = "操作";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "目标人";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // ToolStrip
            // 
            this.ToolStrip.Location = new System.Drawing.Point(0, 25);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(1008, 25);
            this.ToolStrip.TabIndex = 12;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // CtxMenuDoc
            // 
            this.CtxMenuDoc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.登记公文ToolStripMenuItem});
            this.CtxMenuDoc.Name = "CtxMenuDoc";
            this.CtxMenuDoc.Size = new System.Drawing.Size(125, 26);
            // 
            // 登记公文ToolStripMenuItem
            // 
            this.登记公文ToolStripMenuItem.Name = "登记公文ToolStripMenuItem";
            this.登记公文ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.登记公文ToolStripMenuItem.Text = "登记公文";
            // 
            // CtxMenuSub
            // 
            this.CtxMenuSub.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增流转ToolStripMenuItem});
            this.CtxMenuSub.Name = "CtxMenuSub";
            this.CtxMenuSub.Size = new System.Drawing.Size(125, 26);
            // 
            // CtxMenuOper
            // 
            this.CtxMenuOper.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增操作ToolStripMenuItem});
            this.CtxMenuOper.Name = "CtxMenuOper";
            this.CtxMenuOper.Size = new System.Drawing.Size(125, 26);
            // 
            // 新增流转ToolStripMenuItem
            // 
            this.新增流转ToolStripMenuItem.Name = "新增流转ToolStripMenuItem";
            this.新增流转ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.新增流转ToolStripMenuItem.Text = "新增流转";
            // 
            // 新增操作ToolStripMenuItem
            // 
            this.新增操作ToolStripMenuItem.Name = "新增操作ToolStripMenuItem";
            this.新增操作ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.新增操作ToolStripMenuItem.Text = "新增操作";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDocument)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSubDoc)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvOper)).EndInit();
            this.CtxMenuDoc.ResumeLayout(false);
            this.CtxMenuSub.ResumeLayout(false);
            this.CtxMenuOper.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgvDocument;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSecretLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDistributionScope;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DgvSubDoc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView DgvOper;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colViewID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHandman;
        private System.Windows.Forms.DataGridViewTextBoxColumn colState;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarget;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ContextMenuStrip CtxMenuDoc;
        private System.Windows.Forms.ToolStripMenuItem 登记公文ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CtxMenuSub;
        private System.Windows.Forms.ContextMenuStrip CtxMenuOper;
        private System.Windows.Forms.ToolStripMenuItem 新增流转ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增操作ToolStripMenuItem;
    }
}

