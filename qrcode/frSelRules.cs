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
    public partial class frSelRules : Form
    {
        public frSelRules()
        {
            InitializeComponent();

            dataGridView1.RowsDefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#111111");
            dataGridView1.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#ffffff");

           var result=  GetList();

            if (result <= 0)
            {
                var dlg = new frAddRules();
                dlg.ShowDialog();
                GetList();
            }


        }

        private int GetList()
        {
            var ds = SQLiteHelper.ExecuteDataset(" select  *  from Rules  order by name ");
            dataGridView1.DataSource = ds.Tables[0];
            if (Comm.Func.HasData(ds) == false) return 0;
            return ds.Tables[0].Rows.Count;
        }

        private void frSelRules_FormClosing(object sender, FormClosingEventArgs e)
        {
         
           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
          
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var rows = dataGridView1.SelectedRows;
            if (rows.Count <= 0)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                Comm.Data.RuleName = rows[0].Cells[0].Value + "";
                this.DialogResult = DialogResult.OK;
            }

            this.Close();
        }
    }
}
