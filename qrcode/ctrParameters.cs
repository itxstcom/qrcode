/*
 Name：小书童开源免费的二维码批量生成工具
 Author：奔跑的蜗牛
 Site：http://www.itxst.com 
 License：MIT 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QRCode.Comm;

namespace QRCode
{
    public partial class ctrParameters : UserControl
    {
        public ctrParameters()
        {
            InitializeComponent();

            //7 %
            //15 %
            //25 %
            //30 %
            var  list = new List<KeyValue>();
            list.Add(new KeyValue { Key= "7%", Value="7" });
            list.Add(new KeyValue { Key= "15%", Value="15" });
            list.Add(new KeyValue { Key= "25%", Value="25" });
            list.Add(new KeyValue { Key= "30%", Value= "30" });

            comLC.DataSource = list;
            comLC.DisplayMember = "Key";

            comLC.SelectedIndex = 0;
            comMZ.SelectedIndex = 0;

            QRParameters.QJS = "#00000000";
            QRParameters.BJS = "#FFFFFFFF";

        }


        private QRParameters qRParameters = new QRParameters();

        public QRParameters QRParameters { get => qRParameters; set => qRParameters = value; }

        private void comLC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                QRParameters.RC = int.Parse(((KeyValue)comLC.SelectedValue).Value);
            }
            catch
            { }
        }

        private void txtDX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                QRParameters.DX = int.Parse(txtDX.Text);
            }
            catch
            { }
        }

        private void txtBM_TextChanged(object sender, EventArgs e)
        {
            QRParameters.BM = txtDX.Text.Trim();
        }

        private void txtQJS_TextChanged(object sender, EventArgs e)
        {
            QRParameters.QJS = txtQJS.Text.Trim();
        }

        private void txtBJS_TextChanged(object sender, EventArgs e)
        {
            QRParameters.BJS = txtBJS.Text.Trim();
        }

        private void txtQJS_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtQJS.BackColor = colorDialog1.Color;
                txtQJS.Text = "#" + colorDialog1.Color.ToArgb().ToString("X8");
             
            }
        }

        private void txtBJS_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBJS.BackColor = colorDialog1.Color;
                txtBJS.Text = "#" + colorDialog1.Color.ToArgb().ToString("X8");
               
            }
        
        }

        private void rbPng_Click(object sender, EventArgs e)
        {
            QRParameters.ImgType = "png";
        }

        private void rbBmp_Click(object sender, EventArgs e)
        {
            QRParameters.ImgType = "bmp";
        }

        private void comLC_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }
    }
}
