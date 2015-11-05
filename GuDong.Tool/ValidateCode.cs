using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuDong.Tool
{
   public class ValidateCode
    {
        int CodeCount;
        string allChar = "1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,J,K,M,N,P,Q,R,S,T,U,W,X,Y,Z";
        string[] allCharArray;
        public string RandomCode{get;set;}
        int temp = -1;
        public ValidateCode(int CodeCount=4)
        {
            this.CodeCount = CodeCount;
            allCharArray = allChar.Split(',');
        }

        public byte[] CreateCodeImg()
        {
            Random rand = new Random();
            for (int i = 0; i < CodeCount; i++)
            {
                if (temp != -1)
                {
                    rand = new Random(temp * i * ((int)DateTime.Now.Ticks));
                }

                int t = rand.Next(31);

                while (temp == t)
                {
                    t = rand.Next(31);
                }

                temp = t;
                RandomCode += allCharArray[t];
            }

            int iwidth = (int)(RandomCode.Length * 14);
            Bitmap image = new Bitmap(iwidth, 20);
            Graphics g = Graphics.FromImage(image);
            Font f = new System.Drawing.Font("Arial ", 10);
            Color[] colors = { Color.Black, Color.DarkBlue, Color.Green, Color.Orange, Color.Brown, Color.DarkCyan, Color.Purple, Color.DarkGoldenrod };

            g.Clear(Color.White);//背景色
            Pen blackPen = new Pen(Color.DarkGray, 0);
            for (var i = 0; i < 10; i++)
            {//噪点
                int x = rand.Next(0, image.Width);
                int y = rand.Next(0, image.Height);
                g.DrawRectangle(blackPen, x, y, 1, 1);
            }
            char[] ch = RandomCode.ToCharArray();
            Point dot = new Point(10, 10);
            StringFormat format = new StringFormat(StringFormatFlags.NoClip)
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            for (int i = 0; i < ch.Length; i++)
            {
                Brush b = new SolidBrush(colors[rand.Next(colors.Length)]);

                int angle = rand.Next(-30, 30); // 转动的度数  
                g.TranslateTransform(dot.X, dot.Y); // 移动光标到指定位置  
                g.RotateTransform(angle);
                g.DrawString(ch[i].ToString(CultureInfo.InvariantCulture), f, b, 1, 1, format);

                g.RotateTransform(-angle); // 转回去  
                g.TranslateTransform(2, -dot.Y); // 移动光标到指定位置 



                //g.DrawString(ch[i].ToString(), f, b, 3 + (i * 12), 3);
            }
            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            g.Dispose();
            image.Dispose();
            return ms.ToArray();
        }
    }
}
