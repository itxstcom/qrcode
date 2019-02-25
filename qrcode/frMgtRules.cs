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
using System.Windows.Forms;

namespace QRCode
{
    public partial class frMgtRules : Form
    {
        public frMgtRules()
        {
            InitializeComponent();
         

            dataGridView1.RowsDefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#111111");
            dataGridView1.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#ffffff");

            GetList();

            //dataGridView1.SelectedRows[0].DefaultCellStyle.ForeColor =ColorTranslator.FromHtml("#333333");
            //dataGridView1.SelectedRows[0].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#f1f1f1");
        }
        private void GetList()
        {
             
            var ds = SQLiteHelper.ExecuteDataset(" select  *  from Rules  order by name ");
            dataGridView1.DataSource = ds.Tables[0];
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

      
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            //if (dataGridView1.Rows[e.RowIndex].Selected)
            //{
              
            //    dataGridView1.ClearSelection();
            //    dataGridView1.Rows[e.RowIndex].Selected = true;
            //   // contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
            //}

           

        }

        private void 规矩此规则生成二维码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          var rows=  dataGridView1.SelectedRows;

        }

        private void 创建新的规则ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new frAddRules();
            dlg.ShowDialog();
            GetList();
        }

        private void 删除选中规则ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dlg = new frAddRules();
            dlg.ShowDialog();
            GetList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void Delete()
        {
            var rows = dataGridView1.SelectedRows;
            if (rows.Count <= 0)
            {
                MessageBox.Show("请选择你要删除的规则");
                return;
            }


            DialogResult dr = MessageBox.Show("确定删除吗?", "删除规则", MessageBoxButtons.OKCancel);

            if (dr != DialogResult.OK) return;

            var RuleName = rows[0].Cells[1].Value + "";

 
            var rowcount = SQLiteHelper.ExecuteNonQuery(" delete from Rules where name='" + RuleName + "' ");

            GetList();
            MessageBox.Show("删除成功");
        }
    }
}
