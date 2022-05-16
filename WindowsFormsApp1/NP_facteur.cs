using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class NP_facteur : Form
    {
        public NP_facteur()
        {
            InitializeComponent();
        }
        OleDbConnection cx = Form1.cx;

        private void NP_facteur_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime d;
                if (DateTime.Now.Month != 1)
                {
                    d = new DateTime(DateTime.Now.Year, DateTime.Now.Month - 1, 1);
                }
                else
                {
                    d = new DateTime(DateTime.Now.Year, 12, 1);
                }
                date1.Value = d;
                date2.Value = DateTime.Now;
                DataTable t = new DataTable();
                OleDbDataAdapter tous = new OleDbDataAdapter("SELECT prénom,Nom,ID_facteur,ID_con,date_facteur,Nombre_aucien,Nombre_nouveau,prix_avec_main,F.paie FROM (Client AS c INNER JOIN Conteur AS co ON c.id_client = co.ID__Client) INNER JOIN Facteur AS F ON F.Id_cont = co.ID_con", cx);

                tous.Fill(t);
                DataView dv = new DataView(t);
                dv.RowFilter = "date_facteur >= '" + date1.Value + "' and date_facteur <= '" + date2.Value + "' and paie=false";
                dataGridView1.DataSource = dv;

                dataGridView1.Columns[0].HeaderText = "الإسم";
                dataGridView1.Columns[1].HeaderText = "النسب";

                dataGridView1.Columns[2].HeaderText = "رقم الفاتورة";
                dataGridView1.Columns[3].HeaderText = "رقم العداد";
                dataGridView1.Columns[4].HeaderText = "تاريخ الفاتورة";

                dataGridView1.Columns[5].HeaderText = "العددالقديم";
                dataGridView1.Columns[6].HeaderText = "العدد الجديد";
                dataGridView1.Columns[7].HeaderText = "مبلغ الفاتورة+واجب الإصلاح";
                dataGridView1.Columns[8].HeaderText = "خالص";
                double to = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    to += double.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());
                }
                label4.Text = "-" + to + " DH : مجموع الفواتير الغير مستخلص";
            }catch(Exception x)
            {
                cx.Close();
                MessageBox.Show(x.Message);
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DataTable t = new DataTable();
            OleDbDataAdapter tous = new OleDbDataAdapter("SELECT prénom,Nom,ID_facteur,ID_con,date_facteur,Nombre_aucien,Nombre_nouveau,prix_avec_main,F.paie FROM (Client AS c INNER JOIN Conteur AS co ON c.id_client = co.ID__Client) INNER JOIN Facteur AS F ON F.Id_cont = co.ID_con", cx);

            tous.Fill(t);
            DataView dv = new DataView(t);
            dv.RowFilter = "date_facteur >= '" + date1.Value + "' and date_facteur <= '" + date2.Value + "' and paie=false";
            dataGridView1.DataSource = dv;
            double to = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                to += double.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());
            }
            label4.Text = "-" + to + " DH : مجموع الفواتير الغير مستخلص";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DataTable t = new DataTable();
            OleDbDataAdapter tous = new OleDbDataAdapter("SELECT prénom,Nom,ID_facteur,ID_con,date_facteur,Nombre_aucien,Nombre_nouveau,prix_avec_main,F.paie FROM (Client AS c INNER JOIN Conteur AS co ON c.id_client = co.ID__Client) INNER JOIN Facteur AS F ON F.Id_cont = co.ID_con", cx);

            tous.Fill(t);
            DataView dv = new DataView(t);
            dv.RowFilter = "date_facteur >= '" + date1.Value + "' and date_facteur <= '" + date2.Value + "' and paie=false";
            dataGridView1.DataSource = dv;
            double to = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                to += double.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());
            }
            label4.Text = "-" + to + " DH : مجموع الفواتير الغير مستخلص";
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            printPreviewDialog1.Document = printDocument1;

            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        int cnt = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            OleDbCommand command = new OleDbCommand();
            DataTable T = new DataTable();
            command = cx.CreateCommand();
            command.CommandText = "SELECT   Facteur.ID_facteur,Client.Nom, Client.prénom, Facteur.date_facteur,Facteur.Nombre_aucien, Facteur.Nombre_nouveau,(Facteur.Nombre_nouveau - Facteur.Nombre_aucien) as 'fa',(Facteur.prix_avec_main - Facteur.prix_sans_main) as 'Pmai',(Facteur.prix_sans_main / (Facteur.Nombre_nouveau - Facteur.Nombre_aucien)) as 'Pme', Facteur.prix_sans_main, Facteur.prix_avec_main,Facteur.paie FROM unique_, (Client INNER JOIN Conteur ON Client.id_client = Conteur.ID__Client) INNER JOIN Facteur ON Conteur.ID_con = Facteur.Id_cont WHERE (((Facteur.date_facteur)>=#" + date1.Value.Month + "/" + date1.Value.Day + "/" + date1.Value.Year + "#) AND ((Facteur.date_facteur)<=#" + date2.Value.Month + "/" + date2.Value.Day + "/" + date2.Value.Year + "#) AND ((Facteur.paie)=False));";
            cx.Open();
            OleDbDataReader r = command.ExecuteReader();
            T.Load(r);
            r.Close();
            cx.Close();


            int j = 0, yt = 0;
            Image Image = Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\logiciel gestion de l'eau\img\img2.png");
            Image Image1 = Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\logiciel gestion de l'eau\img\img3.png");
            Font ftext = new Font("Arial", 12, FontStyle.Regular);
            Font ficon = new Font("Wingdings", 12, FontStyle.Regular);
            e.HasMorePages = false;
            e.Graphics.DrawImage(Image, 0, 0, e.PageBounds.Width, 180);
            for (; cnt < T.Rows.Count; cnt++)
            {
                if (j == 27)
                {
                    e.HasMorePages = true;
                    break;
                }
                else
                {
                    e.Graphics.DrawImage(Image1, 0, 170 + yt, e.PageBounds.Width, 35);
                    e.Graphics.DrawString(T.Rows[cnt][0].ToString(), ftext, Brushes.Black, 757, 180 + yt);
                    e.Graphics.DrawString(T.Rows[cnt][1].ToString() + " " + T.Rows[cnt][2].ToString(), ftext, Brushes.Black, 606, 180 + yt);
                    e.Graphics.DrawString(DateTime.Parse(T.Rows[cnt][3].ToString()).ToShortDateString(), ftext, Brushes.Black, 520, 180 + yt);
                    e.Graphics.DrawString(T.Rows[cnt][4].ToString(), ftext, Brushes.Black, 457, 180 + yt);
                    e.Graphics.DrawString(T.Rows[cnt][5].ToString(), ftext, Brushes.Black, 372, 180 + yt);
                    e.Graphics.DrawString(String.Format("{0:0.00}", float.Parse(T.Rows[cnt][6].ToString())), ftext, Brushes.Black, 312, 180 + yt);
                    e.Graphics.DrawString(String.Format("{0:0.00}", float.Parse(T.Rows[cnt][7].ToString())), ftext, Brushes.Black, 247, 180 + yt);
                    e.Graphics.DrawString(String.Format("{0:0.00}", float.Parse(T.Rows[cnt][8].ToString())), ftext, Brushes.Black, 177, 180 + yt);

                    if (bool.Parse(T.Rows[cnt][11].ToString()) == true)
                    {
                        e.Graphics.DrawString(String.Format("{0:0.00}", float.Parse(T.Rows[cnt][9].ToString())), ftext, Brushes.Green, 113, 180 + yt);
                        e.Graphics.DrawString(String.Format("{0:0.00}", float.Parse(T.Rows[cnt][10].ToString())), ftext, Brushes.Green, 51, 180 + yt);
                        e.Graphics.DrawString(((char)254).ToString(), ficon, Brushes.Green, 16, 180 + yt);
                    }
                    else
                    {
                        e.Graphics.DrawString(String.Format("{0:0.00}", float.Parse(T.Rows[cnt][9].ToString())), ftext, Brushes.Red, 113, 180 + yt);
                        e.Graphics.DrawString(String.Format("{0:0.00}", float.Parse(T.Rows[cnt][10].ToString())), ftext, Brushes.Red, 51, 180 + yt);
                        e.Graphics.DrawString(((char)168).ToString(), ficon, Brushes.Red, 16, 180 + yt);
                    }
                    yt += 35;
                }
                j++;
            }
            if (cnt == T.Rows.Count)
            {
                cnt = 0;
                T.Clear();
            }
        }
    }
}
