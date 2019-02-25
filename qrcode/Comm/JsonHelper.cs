/*
 Name：小书童开源免费的二维码批量生成工具
 Author：奔跑的蜗牛
 Site：http://www.itxst.com 
 License：MIT 
*/
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QRCode.Comm
{
    public class JsonHelper
    {
        /// <summary>
        /// 转换成json格式
        /// </summary>
        /// <param name="obj">对象</param>
        /// <returns></returns>
        public static string GetJson(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        /// <summary>
        /// json格式字符串转化成T类型对象
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="json">json字符串</param>
        /// <returns></returns>
        public static T GetModel<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

    }
}
