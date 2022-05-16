using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;

namespace WindowsFormsApp1
{
    class impression
    {

        public int cnt = 0;
        public impression(){ }
        public void impTous(System.Drawing.Printing.PrintPageEventArgs e,DataTable T)
        {
            int j = 0, y = 0, yt = 0;
            Image Image = Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\logiciel gestion de l'eau\img\img1.png");
            Font ftext = new Font("Arial", 12, FontStyle.Regular);
            e.HasMorePages = false;
            for (; cnt < T.Rows.Count; cnt++)
            {
                if (j == 5)
                {
                    e.HasMorePages = true;
                    break;
                }
                else
                {
                    e.Graphics.DrawImage(Image, 0, y * j, e.PageBounds.Width, 236);
                    y = 235;
                    e.Graphics.DrawString(T.Rows[cnt][0].ToString(), ftext, Brushes.Black, 290, 22 + yt);
                    e.Graphics.DrawString(T.Rows[cnt][1].ToString()+" "+ T.Rows[cnt][2].ToString(), ftext, Brushes.Black, 220, 42 + yt);
                    e.Graphics.DrawString(T.Rows[cnt][3].ToString(), ftext, Brushes.Black, 340, 63 + yt);

                    e.Graphics.DrawString(T.Rows[cnt][4].ToString(), ftext, Brushes.Black, 725, 153 + yt);
                    e.Graphics.DrawString(T.Rows[cnt][5].ToString(), ftext, Brushes.Black, 650, 153 + yt);
                    e.Graphics.DrawString(T.Rows[cnt][6].ToString(), ftext, Brushes.Black, 544, 153 + yt);
                    e.Graphics.DrawString(T.Rows[cnt][7].ToString(), ftext, Brushes.Black, 440, 153 + yt);
                    e.Graphics.DrawString(T.Rows[cnt][8].ToString(), ftext, Brushes.Black, 369, 153 + yt);
                    e.Graphics.DrawString(T.Rows[cnt][9].ToString(), ftext, Brushes.Black, 295, 153 + yt);
                   e.Graphics.DrawString(T.Rows[cnt][10].ToString(), ftext, Brushes.Black, 212, 153 + yt);
                     e.Graphics.DrawString(T.Rows[cnt][11].ToString(), ftext, Brushes.Black, 100, 153 + yt);
                    e.Graphics.DrawString(T.Rows[cnt][12].ToString(), ftext, Brushes.Black, 17, 153 + yt);
                    //////*****vireffire
                    //e.Graphics.DrawString(T.Rows[cnt][13].ToString(), ftext, Brushes.Black, 540, 180 + yt);
                    //e.Graphics.DrawString(T.Rows[cnt][14].ToString(), ftext, Brushes.Black, 520, 204 + yt);
                    yt += 235;
                }
                j++;
            }
        }
    }
}
