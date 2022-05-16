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
    public partial class R_conteur : Form
    {
        public R_conteur()
        {
            InitializeComponent();
        }
        OleDbConnection cx = Form1.cx;
        public int te = 0;
        private void id_co__TextChanged(object sender, EventArgs e)
        {
            DataTable t = new DataTable();
            dataGridView1.DataSource = t;
            dataGridView2.DataSource = t;
            dateTimePicker1.Value = DateTime.Today;
            nom_txt.Clear();
            ID_client_txt.Clear();
            Nb_actuel.Clear();
            Nb_actuel.Clear();
            if (int.TryParse(id_co_.Text, out int y))
            {
                DataTable mm = new DataTable();
                DataTable fa = new DataTable();
                DataTable cl = new DataTable();
                OleDbDataAdapter ma = new OleDbDataAdapter("SELECT Maintenance.id_mai, Maintenance.Description_, Maintenance.date_mai, Maintenance.prix_main FROM Maintenance where Maintenance.id_conteur=" + id_co_.Text, cx);
                ma.Fill(mm);
                dataGridView2.DataSource = mm;
                dataGridView2.Columns[0].HeaderText = "رقم التسلسلي للعطب";
                dataGridView2.Columns[1].HeaderText = "التعليق";
                dataGridView2.Columns[2].HeaderText = "تاريخ اصلاح العطب";
                dataGridView2.Columns[3].HeaderText = "تكلفة اصلاح العطب";

                OleDbDataAdapter fac = new OleDbDataAdapter("SELECT Facteur.ID_facteur, Facteur.date_facteur, Facteur.Nombre_aucien, Facteur.Nombre_nouveau, Facteur.prix_sans_main, Facteur.prix_avec_main,Facteur.paie FROM Facteur where Facteur.Id_cont=" + id_co_.Text, cx);
                fac.Fill(fa);
                dataGridView1.DataSource = fa;
                dataGridView1.Columns[0].HeaderText = "رقم الفاتورة";
                dataGridView1.Columns[1].HeaderText = "تاريخ الفاتورة";
                dataGridView1.Columns[2].HeaderText = "العددالقديم";
                dataGridView1.Columns[3].HeaderText = "العدد الجديد";
                dataGridView1.Columns[4].HeaderText = "مبلغ الفاتورة";
                dataGridView1.Columns[5].HeaderText = "مبلغ الفاتورة+واجب الإصلاح";
                dataGridView1.Columns[6].HeaderText = "خالص";

                dataGridView1.Columns[5].Width = dataGridView1.Columns[5].Width + 5;


                OleDbDataAdapter client_conteur = new OleDbDataAdapter("SELECT Client.id_client, Client.Nom, Client.prénom, Conteur.date_con, Conteur.Nb_actuel FROM Client INNER JOIN Conteur ON Client.id_client = Conteur.ID__Client where Conteur.ID_con=" + id_co_.Text, cx);

                client_conteur.Fill(cl);
                if (cl.Rows.Count != 0)
                {
                    ID_client_txt.Text = cl.Rows[0][0].ToString();
                    nom_txt.Text = cl.Rows[0][1].ToString();
                    prenom_txt.Text = cl.Rows[0][2].ToString();
                    dateTimePicker1.Value = DateTime.Parse(cl.Rows[0][3].ToString());
                    Nb_actuel.Text = cl.Rows[0][4].ToString();
                }
            } 
            else if (id_co_.Text != "")
            {
                timer1.Start();
            }
        }
        private void R_conteur_Load(object sender, EventArgs e)
        {
            label5.Hide();
        }
        int t = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (int.TryParse(id_co_.Text, out int z) == false)
            {
                if (t % 2 == 0)
                {
                    label5.Show();
                    id_co_.Hide();
                }
                else
                {
                    id_co_.Show();
                    label5.Hide();
                    id_co_.Clear();
                }
                id_co_.Focus();
            }

            t++;
            if (t == 6)
            {
                t = 0;
                timer1.Stop();
            }
        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(id_co_.Text, out int y))
                {
                    ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
                    printPreviewDialog1.Document = printDocument1;

                    if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }
                }
                else
                {
                    timer1.Start();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        int cnt = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            OleDbCommand command = new OleDbCommand();
            DataTable T = new DataTable();
            command = cx.CreateCommand();
            command.CommandText = "SELECT   Facteur.ID_facteur,Client.Nom, Client.prénom, Facteur.date_facteur,Facteur.Nombre_aucien, Facteur.Nombre_nouveau,(Facteur.Nombre_nouveau - Facteur.Nombre_aucien) as 'fa',(Facteur.prix_avec_main - Facteur.prix_sans_main) as 'Pmai',(Facteur.prix_sans_main / (Facteur.Nombre_nouveau - Facteur.Nombre_aucien)) as 'Pme', Facteur.prix_sans_main, Facteur.prix_avec_main,Facteur.paie FROM unique_, (Client INNER JOIN Conteur ON Client.id_client = Conteur.ID__Client) INNER JOIN Facteur ON Conteur.ID_con = Facteur.Id_cont WHERE(((Facteur.Id_cont) =" + id_co_.Text+")); ";
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
                    e.Graphics.DrawString(T.Rows[cnt][1].ToString()+" "+ T.Rows[cnt][2].ToString(), ftext, Brushes.Black, 606, 180 + yt);
                    e.Graphics.DrawString(DateTime.Parse(T.Rows[cnt][3].ToString()).ToShortDateString(), ftext, Brushes.Black, 520, 180 + yt);
                    e.Graphics.DrawString(T.Rows[cnt][4].ToString(), ftext, Brushes.Black, 457, 180 + yt);
                    e.Graphics.DrawString(T.Rows[cnt][5].ToString(), ftext, Brushes.Black, 372, 180 + yt);
                    e.Graphics.DrawString(T.Rows[cnt][6].ToString(), ftext, Brushes.Black, 312, 180 + yt);
                    e.Graphics.DrawString(String.Format("{0:0.00}", float.Parse(T.Rows[cnt][7].ToString())), ftext, Brushes.Black, 247, 180 + yt);
                    e.Graphics.DrawString(String.Format("{0:0.00}", float.Parse(T.Rows[cnt][8].ToString())), ftext, Brushes.Black, 177, 180 + yt);

                    if (bool.Parse(T.Rows[cnt][11].ToString())== true)
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
                cnt = 0;
            T.Clear();
        }
    }
}
