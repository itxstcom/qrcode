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
    public partial class frAddRules : Form
    {
        private bool _load = false;
        private int rbIndex = 1;
        public frAddRules()
        {
            InitializeComponent();
        }

        private void rbType1_Click(object sender, EventArgs e)
        {
            if (_load == false)
            {
                _load = true;
                return;
            }
            if (rbIndex == 1)
            {
                return;
            }
            rbIndex = 1;

            groupBox2.Visible = true;
            groupBox3.Location = new Point(groupBox3.Location.X, groupBox3.Location.Y + 80);
            groupBox4.Location = new Point(groupBox4.Location.X, groupBox4.Location.Y + 80);
            groupBox5.Location = new Point(groupBox5.Location.X, groupBox5.Location.Y + 80);
            groupBox6.Location = new Point(groupBox6.Location.X, groupBox6.Location.Y + 80);
        }

        private void rbType2_Click(object sender, EventArgs e)
        {
            if (rbIndex == 2)
            {
                return;
            }
            rbIndex = 2;
            groupBox2.Visible = false;
            groupBox3.Location = new Point(groupBox3.Location.X, groupBox3.Location.Y - 80);
            groupBox4.Location = new Point(groupBox4.Location.X, groupBox4.Location.Y - 80);
            groupBox5.Location = new Point(groupBox5.Location.X, groupBox5.Location.Y - 80);
            groupBox6.Location = new Point(groupBox6.Location.X, groupBox6.Location.Y - 80);
        }

        private void rbType2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rbType1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void btBro_Click(object sender, EventArgs e)
        {
            BroCode();
        }

    

        private void txtQSZ_TextChanged(object sender, EventArgs e)
        {
            if (Comm.Func.IsNum(txtQSZ.Text) == false)
            {
                txtQSZ.Text = _txtQSZ;
            }
        }

        private void txtCD_TextChanged(object sender, EventArgs e)
        {
            if (Comm.Func.IsNum(txtCD.Text) == false)
            {
                txtCD.Text = _txtCD;
            }
        }

        private void txtGS_TextChanged(object sender, EventArgs e)
        {
            if (txtGS.Text.Trim() == "") txtGS.Text = _txtGS;
        }

        private string _txtGS = "";
        private void txtGS_Click(object sender, EventArgs e)
        {
            _txtGS = txtGS.Text.Trim(); ;
        }

        private string _txtQSZ = "";
        private void txtQSZ_Click(object sender, EventArgs e)
        {
            _txtQSZ = txtQSZ.Text.Trim(); ;
        }

        private string _txtCD = "";

        private void txtCD_Click(object sender, EventArgs e)
        {
            _txtCD = txtCD.Text.Trim();
        }

        private void txtGZMC_Click(object sender, EventArgs e)
        {
            BroCode();
        }

        private void BroCode()
        {

            var code = "";
            if (rbType1.Checked == true) code = Build.Get(new Rules.Auto { Len = int.Parse(txtCD.Text.Trim()), StartValue = int.Parse(txtQSZ.Text.Trim()), Format = txtGS.Text });
            if (rbType2.Checked == true) code = Build.Get(new Rules.Random { Len = int.Parse(txtCD.Text.Trim()), Format = txtGS.Text });
            lbMsg.Text = code;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Add();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void Add()
        {
            if (txtGZMC.Text.Trim() == "")
            {
                MessageBox.Show("规则名称不能为空");
                txtGZMC.Focus();
                return;
            }

            DialogResult dr = MessageBox.Show("确定保存吗，保存后不允许修改?", "保存规则", MessageBoxButtons.OKCancel);

            if (dr != DialogResult.OK) return;

            var ds=  SQLiteHelper.ExecuteDataset(" select  *  from Rules where name='" + txtGZMC.Text.Trim() + "' limit 1 ");

            if (Comm.Func.HasData(ds) ==true)
            {
                MessageBox.Show("规则已存在，请修改规则名称");
                return;
            }

            var json = "";

            if (rbType1.Checked == true) json = Comm.JsonHelper.GetJson(new Rules.Auto { RuleType = "zz", Len = int.Parse(txtCD.Text.Trim()), StartValue = int.Parse(txtQSZ.Text.Trim()), Format = txtGS.Text });
            if (rbType2.Checked == true) json = Comm.JsonHelper.GetJson(new Rules.Random { RuleType = "sj", Len = int.Parse(txtCD.Text.Trim()), Format = txtGS.Text });

            var item = new Datas.Rules()
            {
                Name = txtGZMC.Text.Trim(),
                Data = json
            };
           var rows= SQLiteHelper.ExecuteNonQuery("insert into Rules(Name,Data)values('"+ txtGZMC.Text.Trim() + "','"+ json + "')");
            MessageBox.Show("保存成功");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
