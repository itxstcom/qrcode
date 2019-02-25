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
    public class Build
    {
        public static string Get(Rules.Base RuleData)
        {
            var Rule = "";

            if (RuleData.GetType().FullName== "QRCode.Rules.Auto") Rule = Auto((Rules.Auto)RuleData);
            if (RuleData.GetType().FullName == "QRCode.Rules.Random") Rule = Random((Rules.Random)RuleData);

            return Rule;
        }

        private static string Auto(Rules.Auto RuleData)
        {
            var Code = RuleData.StartValue.ToString().PadLeft(RuleData.Len, '0');
            var Format=RuleData.Format;
            Format = Format.Replace("{年份}", DateTime.Now.ToString("yyyy"));
            Format = Format.Replace("{月份}", DateTime.Now.ToString("MM"));
            Format = Format.Replace("{日期}", DateTime.Now.ToString("dd"));
            Format = Format.Replace("{种子}", Code);
            return Format;
        }

        private static string Random(Rules.Random RuleData)
        {
           var Code = GetRandom(RuleData.Len);

            Code = Code.PadLeft(RuleData.Len, '0');

            var Format = RuleData.Format;

            Format = Format.Replace("{年份}", DateTime.Now.ToString("yyyy"));
            Format = Format.Replace("{月份}", DateTime.Now.ToString("MM"));
            Format = Format.Replace("{日期}", DateTime.Now.ToString("dd"));
            Format = Format.Replace("{种子}", Code);
            return Format;
        }

        /// <summary>
        /// 获取指定区间的随机数
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <returns></returns>
        public static string GetRandom(int max = 30)
        {

            var text2 = "";
            var random = new Random((int)DateTime.Now.Ticks);
            const string textArray = "0123456789ABCDEFGHGKLMNPQRSTUVWXYZ";

            for (var i = 0; i < max; i++)
            {
                text2 = text2 + textArray.Substring(random.Next() % textArray.Length, 1);
            }

            return text2;
        }
 
    }
}
