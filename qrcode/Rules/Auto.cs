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
    //自增
    public class Auto :Base
    {
        private int _startValue = 1;

        public int StartValue { get => _startValue; set => _startValue = value; }
    }
}
