/*
 Name：小书童开源免费的二维码批量生成工具
 Author：奔跑的蜗牛
 Site：http://www.itxst.com 
 License：MIT 
*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace QRCode.Comm
{
    public class Images
    {
        public static Bitmap Covert(Bitmap img,string qjsColor, string bjsColor)
        {
           

            if (qjsColor.ToLower().Trim() == "#00000000" && bjsColor.ToLower().Trim() == "#ffffffff") return img;

           var Color1=ColorTranslator.FromHtml(qjsColor);
           var Color2=ColorTranslator.FromHtml(bjsColor);

            for (var x = 0; x < img.Width; x++)
            {
                for (var y = 0; y < img.Height; y++)
                {
                    Color pixelColor = img.GetPixel(x, y);
                   if(Color.Black.ToArgb() == pixelColor.ToArgb())
                    { 
                       img.SetPixel(x, y, Color1);
                    }
                    if (Color.White.ToArgb() == pixelColor.ToArgb())
                    {
                        img.SetPixel(x, y, Color2);
                    }
                }
            }

            return img;
        }

        public static Bitmap CovertColor(Bitmap imgObj, string oldColor, string newColor)
        {

            var Color1 = ColorTranslator.FromHtml(oldColor);
            var Color2 = ColorTranslator.FromHtml(newColor);

            for (var x = 0; x < imgObj.Width; x++)
            {
                for (var j = 0; j < imgObj.Height; j++)
                {
                    Color pixelColor = imgObj.GetPixel(x, j);
                    if (Color1.ToArgb() == pixelColor.ToArgb())
                    {
                        imgObj.SetPixel(x, j, Color2);
                    }
                }
            }

            return imgObj;
        }
    }
}
