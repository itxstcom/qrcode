/*
 Name：小书童开源免费的二维码批量生成工具
 Author：奔跑的蜗牛
 Site：http://www.itxst.com 
 License：MIT 
*/
using QRCode.Datas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCode
{
    public partial class frIndex : Form
    {
        public frIndex()
        {
            InitializeComponent();
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frIndex_Paint);
            linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = ColorTranslator.FromHtml("#666");

            
            //MyContext context = new MyContext();
            //var empList = context.Rules.OrderBy(c => c.Name).ToList();

            //var item = new Data.Rules()
            //{
            //    Name = "Hello"
            //};
            //context.Rules.Add(item); 
            //context.SaveChanges();

            //using (var db = new MyContext())
            //{
            //    var user = (from v in db.Rules
            //                where v.Name == "Hello"
            //                select v).Single();
            //    db.Rules.Remove(user);
            //    db.SaveChanges();
            //}

            var code = new Code.QRCode();
            picCode.Image = code.Build(txtText.Text.Trim(), ctrParameters1.QRParameters);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btBuild_Click(object sender, EventArgs e)
        {
            var code = new  Code.QRCode();
            picCode.Image= code.Build(txtText.Text.Trim(),ctrParameters1.QRParameters);
        }

        private void 批量生成数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new frAddRules();
            var result =  dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                var dlg2 = new frMgtRules();
                dlg2.ShowDialog();
            }
        }

        private void 导出数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new frMgtRules();
            dlg.ShowDialog();
            
        }

        private void 批量生成二维码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var dlg = new frBuild();
                dlg.ShowDialog();
            }
            catch { }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.itxst.com/qrcode");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "png (*.png)|*.png|bmp (*.bmp)|*.bmp";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            picCode.Image.Save(saveFileDialog1.FileName);
            MessageBox.Show("保存成功！");
        }

        private void frIndex_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
