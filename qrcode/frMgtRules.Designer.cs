namespace QRCode
{
    partial class frMgtRules
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMgtRules));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gzmc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gznr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.创建新的规则ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除选中规则ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gzmc,
            this.gznr,
            this.sl});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.GridColor = System.Drawing.Color.Silver;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Linen;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(974, 321);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // gzmc
            // 
            this.gzmc.DataPropertyName = "Name";
            this.gzmc.Frozen = true;
            this.gzmc.HeaderText = "规则名称";
            this.gzmc.Name = "gzmc";
            this.gzmc.ReadOnly = true;
            // 
            // gznr
            // 
            this.gznr.DataPropertyName = "Data";
            this.gznr.Frozen = true;
            this.gznr.HeaderText = "规则内容";
            this.gznr.Name = "gznr";
            this.gznr.ReadOnly = true;
            this.gznr.Width = 400;
            // 
            // sl
            // 
            this.sl.Frozen = true;
            this.sl.HeaderText = "二维码数量";
            this.sl.Name = "sl";
            this.sl.ReadOnly = true;
            this.sl.Width = 120;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.创建新的规则ToolStripMenuItem,
            this.删除选中规则ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 80);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 创建新的规则ToolStripMenuItem
            // 
            this.创建新的规则ToolStripMenuItem.Name = "创建新的规则ToolStripMenuItem";
            this.创建新的规则ToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.创建新的规则ToolStripMenuItem.Text = "创建新的规则";
            this.创建新的规则ToolStripMenuItem.Click += new System.EventHandler(this.创建新的规则ToolStripMenuItem_Click);
            // 
            // 删除选中规则ToolStripMenuItem
            // 
            this.删除选中规则ToolStripMenuItem.Name = "删除选中规则ToolStripMenuItem";
            this.删除选中规则ToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.删除选中规则ToolStripMenuItem.Text = "删除选中规则";
            this.删除选中规则ToolStripMenuItem.Click += new System.EventHandler(this.删除选中规则ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(5, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(963, 1);
            this.label1.TabIndex = 4;
            // 
            // frMgtRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 323);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frMgtRules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "规则管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除选中规则ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 创建新的规则ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn gzmc;
        private System.Windows.Forms.DataGridViewTextBoxColumn gznr;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
        private System.Windows.Forms.Label label1;
    }
}