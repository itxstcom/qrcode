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

namespace QRCode
{
    public class Parameters
    {
        private int _dx = 200;
        public int DX { get => _dx; set => _dx = value; }


        private string _imgType = "png";
        public string ImgType { get => _imgType; set => _imgType = value; }
    

    }
}
