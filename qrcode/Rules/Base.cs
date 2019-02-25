/*
 Name：小书童开源免费的二维码批量生成工具
 Author：奔跑的蜗牛
 Site：http://www.itxst.com 
 License：MIT 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QRCode.Rules
{
    public class Base
    {
        private string _ruleType = "zz";

        private int _len = 1;
        public int Len { get => _len; set => _len = value; }


        private string _format = "";
        public string Format { get => _format; set => _format = value; }
        public string RuleType { get => _ruleType; set => _ruleType = value; }
    }
}
