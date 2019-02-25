namespace QRCode
{
    partial class ctrParameters
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBJS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQJS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comMZ = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comLC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDX = new System.Windows.Forms.TextBox();
            this.rbPng = new System.Windows.Forms.RadioButton();
            this.rbBmp = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // txtBJS
            // 
            this.txtBJS.BackColor = System.Drawing.Color.White;
            this.txtBJS.Location = new System.Drawing.Point(260, 44);
            this.txtBJS.Name = "txtBJS";
            this.txtBJS.Size = new System.Drawing.Size(121, 25);
            this.txtBJS.TabIndex = 26;
            this.txtBJS.Text = "#ffffffff";
            this.txtBJS.Click += new System.EventHandler(this.txtBJS_Click);
            this.txtBJS.TextChanged += new System.EventHandler(this.txtBJS_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(205, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "背景：";
            // 
            // txtQJS
            // 
            this.txtQJS.BackColor = System.Drawing.Color.White;
            this.txtQJS.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtQJS.Location = new System.Drawing.Point(60, 44);
            this.txtQJS.Name = "txtQJS";
            this.txtQJS.Size = new System.Drawing.Size(121, 25);
            this.txtQJS.TabIndex = 24;
            this.txtQJS.Text = "#00000000";
            this.txtQJS.Click += new System.EventHandler(this.txtQJS_Click);
            this.txtQJS.TextChanged += new System.EventHandler(this.txtQJS_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "前景：";
            // 
            // comMZ
            // 
            this.comMZ.FormattingEnabled = true;
            this.comMZ.Items.AddRange(new object[] {
            "二维码",
            "条形码"});
            this.comMZ.Location = new System.Drawing.Point(463, 44);
            this.comMZ.Name = "comMZ";
            this.comMZ.Size = new System.Drawing.Size(121, 23);
            this.comMZ.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "码制：";
            // 
            // txtBM
            // 
            this.txtBM.Location = new System.Drawing.Point(463, 7);
            this.txtBM.Name = "txtBM";
            this.txtBM.Size = new System.Drawing.Size(121, 25);
            this.txtBM.TabIndex = 20;
            this.txtBM.Text = "UTF-8";
            this.txtBM.TextChanged += new System.EventHandler(this.txtBM_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "编码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "大小：";
            // 
            // comLC
            // 
            this.comLC.FormattingEnabled = true;
            this.comLC.Location = new System.Drawing.Point(60, 7);
            this.comLC.Name = "comLC";
            this.comLC.Size = new System.Drawing.Size(121, 23);
            this.comLC.TabIndex = 17;
            this.comLC.SelectedIndexChanged += new System.EventHandler(this.comLC_SelectedIndexChanged);
            this.comLC.TextChanged += new System.EventHandler(this.comLC_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "容错：";
            // 
            // txtDX
            // 
            this.txtDX.Location = new System.Drawing.Point(260, 7);
            this.txtDX.Name = "txtDX";
            this.txtDX.Size = new System.Drawing.Size(121, 25);
            this.txtDX.TabIndex = 27;
            this.txtDX.Text = "200";
            this.txtDX.TextChanged += new System.EventHandler(this.txtDX_TextChanged);
            // 
            // rbPng
            // 
            this.rbPng.AutoSize = true;
            this.rbPng.Checked = true;
            this.rbPng.Location = new System.Drawing.Point(616, 10);
            this.rbPng.Name = "rbPng";
            this.rbPng.Size = new System.Drawing.Size(82, 19);
            this.rbPng.TabIndex = 28;
            this.rbPng.TabStop = true;
            this.rbPng.Text = "Png图片";
            this.rbPng.UseVisualStyleBackColor = true;
            this.rbPng.Click += new System.EventHandler(this.rbPng_Click);
            // 
            // rbBmp
            // 
            this.rbBmp.AutoSize = true;
            this.rbBmp.Location = new System.Drawing.Point(616, 45);
            this.rbBmp.Name = "rbBmp";
            this.rbBmp.Size = new System.Drawing.Size(82, 19);
            this.rbBmp.TabIndex = 29;
            this.rbBmp.Text = "Bmp图片";
            this.rbBmp.UseVisualStyleBackColor = true;
            this.rbBmp.Click += new System.EventHandler(this.rbBmp_Click);
            // 
            // ctrParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbBmp);
            this.Controls.Add(this.rbPng);
            this.Controls.Add(this.txtDX);
            this.Controls.Add(this.txtBJS);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtQJS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comMZ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comLC);
            this.Controls.Add(this.label1);
            this.Name = "ctrParameters";
            this.Size = new System.Drawing.Size(726, 78);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBJS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQJS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comMZ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comLC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDX;
        private System.Windows.Forms.RadioButton rbPng;
        private System.Windows.Forms.RadioButton rbBmp;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
