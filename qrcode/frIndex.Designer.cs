namespace QRCode
{
    partial class frIndex
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
            QRCode.QRParameters qrParameters1 = new QRCode.QRParameters();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frIndex));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.生成数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.批量生成数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.批量生成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.批量生成二维码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.在线帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助文档ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.软件定制开发ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ctrParameters1 = new QRCode.ctrParameters();
            this.txtText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.picCode = new System.Windows.Forms.PictureBox();
            this.btBuild = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCode)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.生成数据ToolStripMenuItem,
            this.批量生成ToolStripMenuItem,
            this.在线帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1236, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 生成数据ToolStripMenuItem
            // 
            this.生成数据ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.批量生成数据ToolStripMenuItem,
            this.导出数据ToolStripMenuItem});
            this.生成数据ToolStripMenuItem.Name = "生成数据ToolStripMenuItem";
            this.生成数据ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.生成数据ToolStripMenuItem.Text = "数据管理";
            // 
            // 批量生成数据ToolStripMenuItem
            // 
            this.批量生成数据ToolStripMenuItem.Name = "批量生成数据ToolStripMenuItem";
            this.批量生成数据ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.批量生成数据ToolStripMenuItem.Text = "创建数据规则";
            this.批量生成数据ToolStripMenuItem.Click += new System.EventHandler(this.批量生成数据ToolStripMenuItem_Click);
            // 
            // 导出数据ToolStripMenuItem
            // 
            this.导出数据ToolStripMenuItem.Name = "导出数据ToolStripMenuItem";
            this.导出数据ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.导出数据ToolStripMenuItem.Text = "管理已有数据";
            this.导出数据ToolStripMenuItem.Click += new System.EventHandler(this.导出数据ToolStripMenuItem_Click);
            // 
            // 批量生成ToolStripMenuItem
            // 
            this.批量生成ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.批量生成二维码ToolStripMenuItem});
            this.批量生成ToolStripMenuItem.Name = "批量生成ToolStripMenuItem";
            this.批量生成ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.批量生成ToolStripMenuItem.Text = "批量生成";
            // 
            // 批量生成二维码ToolStripMenuItem
            // 
            this.批量生成二维码ToolStripMenuItem.Name = "批量生成二维码ToolStripMenuItem";
            this.批量生成二维码ToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.批量生成二维码ToolStripMenuItem.Text = "批量生成二维码";
            this.批量生成二维码ToolStripMenuItem.Click += new System.EventHandler(this.批量生成二维码ToolStripMenuItem_Click);
            // 
            // 在线帮助ToolStripMenuItem
            // 
            this.在线帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助文档ToolStripMenuItem,
            this.软件定制开发ToolStripMenuItem});
            this.在线帮助ToolStripMenuItem.Name = "在线帮助ToolStripMenuItem";
            this.在线帮助ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.在线帮助ToolStripMenuItem.Text = "在线帮助";
            // 
            // 帮助文档ToolStripMenuItem
            // 
            this.帮助文档ToolStripMenuItem.Name = "帮助文档ToolStripMenuItem";
            this.帮助文档ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.帮助文档ToolStripMenuItem.Text = "在线帮助文档";
            // 
            // 软件定制开发ToolStripMenuItem
            // 
            this.软件定制开发ToolStripMenuItem.Name = "软件定制开发ToolStripMenuItem";
            this.软件定制开发ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.软件定制开发ToolStripMenuItem.Text = "软件定制开发";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ctrParameters1);
            this.groupBox1.Controls.Add(this.txtText);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(862, 410);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // ctrParameters1
            // 
            this.ctrParameters1.Location = new System.Drawing.Point(8, 324);
            this.ctrParameters1.Name = "ctrParameters1";
            qrParameters1.BJS = "#FFFFFFFF";
            qrParameters1.BM = "UTF-8";
            qrParameters1.CodeType = "二维码";
            qrParameters1.DX = 200;
            qrParameters1.ImgType = "png";
            qrParameters1.QJS = "#00000000";
            qrParameters1.RC = 7;
            this.ctrParameters1.QRParameters = qrParameters1;
            this.ctrParameters1.Size = new System.Drawing.Size(726, 78);
            this.ctrParameters1.TabIndex = 6;
            // 
            // txtText
            // 
            this.txtText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtText.Location = new System.Drawing.Point(8, 19);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(840, 300);
            this.txtText.TabIndex = 5;
            this.txtText.Text = "输入要生成的内容";
            this.txtText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.picCode);
            this.groupBox2.Location = new System.Drawing.Point(894, 33);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 410);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.YellowGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(90, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "另存为";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // picCode
            // 
            this.picCode.Location = new System.Drawing.Point(11, 19);
            this.picCode.Name = "picCode";
            this.picCode.Size = new System.Drawing.Size(300, 300);
            this.picCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCode.TabIndex = 0;
            this.picCode.TabStop = false;
            // 
            // btBuild
            // 
            this.btBuild.BackColor = System.Drawing.Color.YellowGreen;
            this.btBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuild.ForeColor = System.Drawing.Color.White;
            this.btBuild.Location = new System.Drawing.Point(333, 455);
            this.btBuild.Name = "btBuild";
            this.btBuild.Size = new System.Drawing.Size(185, 50);
            this.btBuild.TabIndex = 3;
            this.btBuild.Text = "生成二维码";
            this.btBuild.UseVisualStyleBackColor = false;
            this.btBuild.Click += new System.EventHandler(this.btBuild_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1054, 490);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(167, 15);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Powered by ITXST.COM";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1236, 519);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btBuild);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "小书童批量二维码生成工具";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frIndex_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 生成数据ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btBuild;
        private System.Windows.Forms.ToolStripMenuItem 批量生成数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 批量生成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 在线帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助文档ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 软件定制开发ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 批量生成二维码ToolStripMenuItem;
        private System.Windows.Forms.PictureBox picCode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private ctrParameters codeParameters1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private ctrParameters ctrParameters1;
    }
}

