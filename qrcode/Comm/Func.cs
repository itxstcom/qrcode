/*
 Name：小书童开源免费的二维码批量生成工具
 Author：奔跑的蜗牛
 Site：http://www.itxst.com 
 License：MIT 
*/
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QRCode.Comm
{
    public class Func
    {
        public static bool IsNum(string parVal)
        {
            try
            {
                int.Parse(parVal);

            }
            catch
            {
                return false;
            }
            return true;
        }

        public static bool HasData(DataSet ds)
        {
            if (ds == null) return false;
            if (ds.Tables.Count <= 0) return false;
            if (ds.Tables[0].Rows.Count <= 0) return false;
            return true;
        }
        public static bool HasData(DataTable dt)
        {
            if (dt == null) return false;
            if (dt.Rows.Count <= 0) return false;
            return true;
        }
    }
}
