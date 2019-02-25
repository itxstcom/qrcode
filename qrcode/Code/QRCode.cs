/*
 Name：小书童开源免费的二维码批量生成工具
 Author：奔跑的蜗牛
 Site：http://www.itxst.com 
 License：MIT 
*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using ZXing;
using ZXing.Datamatrix.Encoder;
using ZXing.QrCode;
using ZXing.QrCode.Internal;

namespace QRCode.Code
{
    public class QRCode : Base
    {

        public bool  Save(string text, Parameters parm,string fileName, string ext)
        {
            try
            {
                var format =   ImageFormat.Jpeg;

                if(ext.Trim().ToLower()=="png") format = ImageFormat.Png;

                var img = Build(text, parm);

                img.Save(fileName, format);

            }
            catch {
                return false;
            }
            return true;
        }
        public override Bitmap Build(string text, Parameters parm)
        {

            var QRParameters = (QRParameters)parm;

            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            QrCodeEncodingOptions options = new QrCodeEncodingOptions();
            options.DisableECI = true;
            //设置内容编码
            options.CharacterSet = QRParameters.BM;
            //设置二维码的宽度和高度
            options.Width = QRParameters.DX;
            options.Height = QRParameters.DX;
            options.Margin = 0;
            //设置二维码的边距,单位不是固定像素
            options.Margin = 1;
            if (QRParameters.RC == 7) options.ErrorCorrection = ErrorCorrectionLevel.L;
            if (QRParameters.RC == 15) options.ErrorCorrection = ErrorCorrectionLevel.M;
            if (QRParameters.RC == 25) options.ErrorCorrection = ErrorCorrectionLevel.Q;
            if (QRParameters.RC == 30) options.ErrorCorrection = ErrorCorrectionLevel.H;
            writer.Options = options;

            Bitmap map = writer.Write(text);

            map = Comm.Images.Covert(map, QRParameters.QJS, QRParameters.BJS);

            return map;
        }
    }
}
