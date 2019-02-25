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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace QRCode
{
    public partial class frBuild : Form
    {

        private string _RuleName = "";
        private Datas.Rules _Rule = null;
        
        public frBuild(string RuleName="")
        {
             

            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

            _RuleName = RuleName;
            if (_RuleName != "")
            {
                _RuleName = Comm.Data.RuleName;
                lbMsg.Text = "选中规则：" + _RuleName;
                return;
            }

            var dlg = new frSelRules();
            if (dlg.ShowDialog() == DialogResult.Cancel)
            {
                this.Close();

            }
            _RuleName = Comm.Data.RuleName;
            lbMsg.Text = "选中规则：" + _RuleName;

            var ds = SQLiteHelper.ExecuteDataset(" select   *  from Rules where name='" + _RuleName + "' limit 1");

            if (Comm.Func.HasData(ds) == false)
            {
                this.Close();
            }
            else
            {
                _Rule.Name = ds.Tables[0].Rows[0]["Name"] + "";
                _Rule.Data = ds.Tables[0].Rows[0]["Data"] + "";
            }
             

            if (_Rule ==null)
            {
              
            }


        }

        private void textBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (txtDir.Text.Trim() == "")
            {
                MessageBox.Show("请选择文件夹");
                return;
            }
            if (Directory.Exists(txtDir.Text.Trim()) == false)
            {
                MessageBox.Show("请选择文件夹");
                return;
            }

            btStart.Text = "生成中...";
            btStart.Enabled = false;

            Thread th = new Thread(Working);
            th.Start();
        }

        private void Working()
        {
            var num = int.Parse(txtNum.Text.Trim());
            var count = 0;
            var qrcode = new Code.QRCode();
            var parm = ctrParameters1.QRParameters;
            var dir = txtDir.Text.Trim().Replace("/","\\");
            var ext = parm.ImgType;
            if (dir.Substring(dir.Length - 1, 1) != "\\") dir = dir + "\\";
            while (true)
            {

               var Code= BuildCode();

                var ds = SQLiteHelper.ExecuteDataset(" select  *  from Data where RuleName='" + _RuleName + "' and Code='"+ Code + "' limit 1 ");

                if (Comm.Func.HasData(ds) == false) continue;

                var rows = SQLiteHelper.ExecuteNonQuery("insert into Data(RuleName,Code)values('" + _RuleName + "','" + Code + "')");

                if (rows <= 0) continue;

                var fileName = dir + Code + "."+ ext;
                var result = qrcode.Save(Code, parm, fileName, ext);

                if (rows > 0 && result==true)   count = count + 1;

                lbMsg.Text = "进度："+ count + "/"+ num;

                if (count >= num) break;
            }

            lbMsg.Text = "生成完成";
          
            
        }

        private QRCode.Rules.Auto _ruleAuto =null;
        private QRCode.Rules.Random _ruleRandom = null;
        private string BuildCode()
        {
            var rule = Comm.JsonHelper.GetModel<QRCode.Rules.Base>(_Rule.Data);
            var code = "";
            if (rule.RuleType == "zz")
            {
               if(_ruleAuto==null) _ruleAuto = Comm.JsonHelper.GetModel<QRCode.Rules.Auto>(_Rule.Data);
                code = QRCode.Build.Get(_ruleAuto);
                _ruleAuto.StartValue = _ruleAuto.StartValue + 1;

                var ds = SQLiteHelper.ExecuteDataset(" select  *  from Rules where name='" + _RuleName + "' limit 1 ");

                var item = new QRCode.Datas.Rules();
                if (Comm.Func.HasData(ds) == false)
                {
                    return "";
                }
                else
                {
                    item.Name = ds.Tables[0].Rows[0]["Name"] + "";
                    item.Data = ds.Tables[0].Rows[0]["Data"] + "";
                }
                

                item.Data = Comm.JsonHelper.GetJson(_ruleAuto);
                SQLiteHelper.ExecuteNonQuery(" update Rules set  Data='"+ item.Data + "' whhere name='" + _RuleName + "' ");

            }
            if (rule.RuleType == "sj")
            {
                if (_ruleRandom == null) _ruleRandom = Comm.JsonHelper.GetModel<QRCode.Rules.Random>(_Rule.Data);
                code = QRCode.Build.Get(_ruleRandom);
            }

            return code;
        }

        private void btBro_Click(object sender, EventArgs e)
        {
            //folder控件描述Environment.SpecialFolder.Desktop;
            folderBrowserDialog1.Description = "请选择二维码存放的文件夹：";
            //指定folder根=桌面
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            //是否添加新建文件夹的按钮
            folderBrowserDialog1.ShowNewFolderButton = true;

            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK) return;

            txtDir.Text = folderBrowserDialog1.SelectedPath;
        }
    }
}
