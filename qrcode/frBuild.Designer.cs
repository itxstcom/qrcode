namespace QRCode
{
    partial class frBuild
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
            QRCode.QRParameters qrParameters1 = new QRCode.QRParameters();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frBuild));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ctrParameters2 = new QRCode.ctrParameters();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btBro = new System.Windows.Forms.Button();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btStart = new System.Windows.Forms.Button();
            this.lbMsg = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ctrParameters2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数设置";
            // 
            // ctrParameters2
            // 
            this.ctrParameters2.Location = new System.Drawing.Point(8, 31);
            this.ctrParameters2.Name = "ctrParameters2";
            qrParameters1.BJS = "#FFFFFFFF";
            qrParameters1.BM = "UTF-8";
            qrParameters1.CodeType = "二维码";
            qrParameters1.DX = 100;
            qrParameters1.ImgType = "png";
            qrParameters1.QJS = "#00000000";
            qrParameters1.RC = 7;
            this.ctrParameters2.QRParameters = qrParameters1;
            this.ctrParameters2.Size = new System.Drawing.Size(726, 78);
            this.ctrParameters2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btBro);
            this.groupBox2.Controls.Add(this.txtDir);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtNum);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(769, 99);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "其他设置";
            // 
            // btBro
            // 
            this.btBro.Location = new System.Drawing.Point(525, 59);
            this.btBro.Name = "btBro";
            this.btBro.Size = new System.Drawing.Size(102, 25);
            this.btBro.TabIndex = 4;
            this.btBro.Text = "选择文件夹";
            this.btBro.UseVisualStyleBackColor = true;
            this.btBro.Click += new System.EventHandler(this.btBro_Click);
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(94, 59);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(424, 25);
            this.txtDir.TabIndex = 3;
            this.txtDir.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "文件目录：";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(94, 23);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(119, 25);
            this.txtNum.TabIndex = 1;
            this.txtNum.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "生成数量：";
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(107, 276);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(119, 29);
            this.btStart.TabIndex = 2;
            this.btStart.Text = "开始生成";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.Location = new System.Drawing.Point(262, 283);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(55, 15);
            this.lbMsg.TabIndex = 3;
            this.lbMsg.Text = "label4";
            // 
            // frBuild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(807, 335);
            this.Controls.Add(this.lbMsg);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frBuild";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "批量生成二维码";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private ctrParameters ctrParameters1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label lbMsg;
        private System.Windows.Forms.Button btBro;
        private ctrParameters ctrParameters2;
    }
}