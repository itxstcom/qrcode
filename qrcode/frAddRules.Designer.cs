namespace QRCode
{
    partial class frAddRules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frAddRules));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbType2 = new System.Windows.Forms.RadioButton();
            this.rbType1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtQSZ = new System.Windows.Forms.TextBox();
            this.txtCD = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtGS = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbMsg = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btBro = new System.Windows.Forms.Button();
            this.txtGZMC = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbType2);
            this.groupBox1.Controls.Add(this.rbType1);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "种子类型";
            // 
            // rbType2
            // 
            this.rbType2.AutoSize = true;
            this.rbType2.Location = new System.Drawing.Point(117, 37);
            this.rbType2.Name = "rbType2";
            this.rbType2.Size = new System.Drawing.Size(58, 19);
            this.rbType2.TabIndex = 1;
            this.rbType2.Text = "随机";
            this.rbType2.UseVisualStyleBackColor = true;
            this.rbType2.CheckedChanged += new System.EventHandler(this.rbType2_CheckedChanged);
            this.rbType2.Click += new System.EventHandler(this.rbType2_Click);
            // 
            // rbType1
            // 
            this.rbType1.AutoSize = true;
            this.rbType1.Checked = true;
            this.rbType1.Location = new System.Drawing.Point(16, 37);
            this.rbType1.Name = "rbType1";
            this.rbType1.Size = new System.Drawing.Size(58, 19);
            this.rbType1.TabIndex = 0;
            this.rbType1.TabStop = true;
            this.rbType1.Text = "自增";
            this.rbType1.UseVisualStyleBackColor = true;
            this.rbType1.CheckedChanged += new System.EventHandler(this.rbType1_CheckedChanged);
            this.rbType1.Click += new System.EventHandler(this.rbType1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtQSZ);
            this.groupBox2.Location = new System.Drawing.Point(12, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(704, 78);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " 起始值";
            // 
            // txtQSZ
            // 
            this.txtQSZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQSZ.Location = new System.Drawing.Point(16, 35);
            this.txtQSZ.Name = "txtQSZ";
            this.txtQSZ.Size = new System.Drawing.Size(159, 25);
            this.txtQSZ.TabIndex = 0;
            this.txtQSZ.Text = "1";
            this.txtQSZ.Click += new System.EventHandler(this.txtQSZ_Click);
            this.txtQSZ.TextChanged += new System.EventHandler(this.txtQSZ_TextChanged);
            // 
            // txtCD
            // 
            this.txtCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCD.Location = new System.Drawing.Point(16, 35);
            this.txtCD.Name = "txtCD";
            this.txtCD.Size = new System.Drawing.Size(159, 25);
            this.txtCD.TabIndex = 0;
            this.txtCD.Text = "10";
            this.txtCD.Click += new System.EventHandler(this.txtCD_Click);
            this.txtCD.TextChanged += new System.EventHandler(this.txtCD_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCD);
            this.groupBox3.Location = new System.Drawing.Point(13, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(704, 78);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " 种子长度";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtGS);
            this.groupBox4.Location = new System.Drawing.Point(12, 301);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(704, 78);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "种子格式";
            // 
            // txtGS
            // 
            this.txtGS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGS.Location = new System.Drawing.Point(16, 35);
            this.txtGS.Name = "txtGS";
            this.txtGS.Size = new System.Drawing.Size(682, 25);
            this.txtGS.TabIndex = 0;
            this.txtGS.Text = "{年份}{月份}{日期}{种子}";
            this.txtGS.Click += new System.EventHandler(this.txtGS_Click);
            this.txtGS.TextChanged += new System.EventHandler(this.txtGS_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbMsg);
            this.groupBox5.Location = new System.Drawing.Point(13, 398);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(704, 78);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "种子预览";
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.Location = new System.Drawing.Point(15, 36);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(55, 15);
            this.lbMsg.TabIndex = 0;
            this.lbMsg.Text = "label1";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(343, 587);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(159, 33);
            this.btAdd.TabIndex = 7;
            this.btAdd.Text = "确定";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btBro
            // 
            this.btBro.Location = new System.Drawing.Point(158, 587);
            this.btBro.Name = "btBro";
            this.btBro.Size = new System.Drawing.Size(159, 33);
            this.btBro.TabIndex = 8;
            this.btBro.Text = "预览";
            this.btBro.UseVisualStyleBackColor = true;
            this.btBro.Click += new System.EventHandler(this.btBro_Click);
            // 
            // txtGZMC
            // 
            this.txtGZMC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGZMC.Location = new System.Drawing.Point(16, 35);
            this.txtGZMC.Name = "txtGZMC";
            this.txtGZMC.Size = new System.Drawing.Size(159, 25);
            this.txtGZMC.TabIndex = 0;
            this.txtGZMC.Click += new System.EventHandler(this.txtGZMC_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtGZMC);
            this.groupBox6.Location = new System.Drawing.Point(13, 494);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(704, 78);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "规则名称";
            // 
            // frAddRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(731, 635);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btBro);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frAddRules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "创建数据规则";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbType2;
        private System.Windows.Forms.RadioButton rbType1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtQSZ;
        private System.Windows.Forms.TextBox txtCD;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtGS;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btBro;
        private System.Windows.Forms.Label lbMsg;
        private System.Windows.Forms.TextBox txtGZMC;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}