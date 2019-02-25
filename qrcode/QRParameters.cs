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
    public class QRParameters: Parameters
    {

        private int _rc = 7;

     

        private string _bm = "UTF-8";

        private string _qj = "";

        private string _bj = "";

        private string _codeType = "二维码";



        public int RC { get => _rc; set => _rc = value; }
  
        public string BM { get => _bm; set => _bm = value; }
        public string QJS { get => _qj; set => _qj = value; }
        public string BJS { get => _bj; set => _bj = value; }
        public string CodeType { get => _codeType; set => _codeType = value; }
     

    }
}
