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
    public partial class R_facteur : Form
    {
        public R_facteur()
        {
            InitializeComponent();
        }
        OleDbConnection cx = Form1.cx;
        DataTable fa = new DataTable();
        bool lo = false;
        public bool remplir(string re, ComboBox co)
        {
            try
            {
                lo = false;
                DataTable t = new DataTable();
                OleDbDataAdapter te = new OleDbDataAdapter(re, cx);
                te.Fill(t);
                if (t.Rows.Count == 0) { return false; }
                else
                {
                    co.DataSource = t;
                    co.DisplayMember = t.Columns[0].ColumnName;
                    co.ValueMember = t.Columns[0].ColumnName;
                }

                lo = true;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            return true;
        }
        private void R_facteur_Load(object sender, EventArgs e)
        {
            label1.Hide();
            remplir("select distinct nom from client", nom_txt);
        }
        public void data()
        {
            dataGridView1.Columns[0].HeaderText = "رقم الفاتورة";
            dataGridView1.Columns[1].HeaderText = "رقم العداد";
            dataGridView1.Columns[2].HeaderText = "تاريخ الفاتورة";
            dataGridView1.Columns[3].HeaderText = "العددالقديم";
            dataGridView1.Columns[4].HeaderText = "العدد الجديد";
            dataGridView1.Columns[5].HeaderText = "مبلغ الفاتورة";
            dataGridView1.Columns[6].HeaderText = "مبلغ الفاتورة+واجب الإصلاح";
            dataGridView1.Columns[7].HeaderText = "خالص";
        }
        bool cli = true;
        private void ID_facteur_txt_TextChanged(object sender, EventArgs e)
        {
            if (cli == true)
            {
                remplir("select distinct nom from client", nom_txt);
                DataTable ta = new DataTable();
                prénom_txt.DataSource = ta;
                if (int.TryParse(ID_facteur_txt.Text, out int y))
                {
                    try
                    {
                        lo = false;
                        DataTable t = new DataTable();
                        OleDbDataAdapter te = new OleDbDataAdapter("SELECT Client.Nom, Client.prénom FROM(Client INNER JOIN Conteur ON Client.id_client = Conteur.ID__Client) INNER JOIN Facteur ON Conteur.ID_con = Facteur.Id_cont where Facteur.ID_facteur=" + ID_facteur_txt.Text, cx);
                        te.Fill(t);
                        if (t.Rows.Count != 0)
                        {

                            nom_txt.Text = t.Rows[0][0].ToString();
                            remplir("select prénom from client where nom= '" + nom_txt.Text + "'", prénom_txt);
                            prénom_txt.Text = t.Rows[0][1].ToString();
                        }
                        lo = true;

                        fa.Rows.Clear();
                        OleDbDataAdapter fac = new OleDbDataAdapter("SELECT Facteur.ID_facteur,Conteur.ID_con, Facteur.date_facteur, Facteur.Nombre_aucien, Facteur.Nombre_nouveau, Facteur.prix_sans_main, Facteur.prix_avec_main,Facteur.paie FROM (Client INNER JOIN Conteur ON Client.id_client = Conteur.ID__Client) INNER JOIN Facteur ON Conteur.ID_con = Facteur.Id_cont where Facteur.ID_facteur like'" + ID_facteur_txt.Text + "%' and Client.Nom like'" + nom_txt.Text + "%' and Client.prénom like '" + prénom_txt.Text + "%'", cx);
                        fac.Fill(fa);
                        dataGridView1.DataSource = fa;
                        data();
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.Message);
                    }
                }
                else
                {
                    DataTable i = new DataTable();
                    dataGridView1.DataSource = i;
                    if (ID_facteur_txt.Text != "")
                    {
                        timer1.Start();
                    }
                }
            }
        }
        private void nom_txt_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (nom_txt.Text.Trim() != "" && lo == true)
            {
                cli = false;
                ID_facteur_txt.Clear();
                remplir("select prénom from client where nom= '" + nom_txt.Text + "'", prénom_txt);

                fa.Rows.Clear();
                OleDbDataAdapter fac = new OleDbDataAdapter("SELECT Facteur.ID_facteur,Conteur.ID_con, Facteur.date_facteur, Facteur.Nombre_aucien, Facteur.Nombre_nouveau, Facteur.prix_sans_main, Facteur.prix_avec_main,Facteur.paie FROM (Client INNER JOIN Conteur ON Client.id_client = Conteur.ID__Client) INNER JOIN Facteur ON Conteur.ID_con = Facteur.Id_cont where Facteur.ID_facteur like'" + ID_facteur_txt.Text + "%' and Client.Nom like'" + nom_txt.Text + "%' and Client.prénom like '" + prénom_txt.Text + "%'", cx);
                fac.Fill(fa);
                dataGridView1.DataSource = fa;
                data();
                cli = true;
            }
        }
        private void prénom_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            fa.Rows.Clear();
            OleDbDataAdapter fac = new OleDbDataAdapter("SELECT Facteur.ID_facteur,Conteur.ID_con, Facteur.date_facteur, Facteur.Nombre_aucien, Facteur.Nombre_nouveau, Facteur.prix_sans_main, Facteur.prix_avec_main,Facteur.paie FROM (Client INNER JOIN Conteur ON Client.id_client = Conteur.ID__Client) INNER JOIN Facteur ON Conteur.ID_con = Facteur.Id_cont where Facteur.ID_facteur like'" + ID_facteur_txt.Text + "%' and Client.Nom like'" + nom_txt.Text + "%' and Client.prénom like '" + prénom_txt.Text + "%'", cx);
            fac.Fill(fa);
            dataGridView1.DataSource = fa;
            data();
        }
        int t = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (int.TryParse(ID_facteur_txt.Text, out int z) == false)
            {
                if (t % 2 == 0)
                {
                    label1.Show();
                    ID_facteur_txt.Hide();
                }
                else
                {
                    ID_facteur_txt.Show();
                    label1.Hide();
                    ID_facteur_txt.Clear();
                }
                ID_facteur_txt.Focus();
            }

            t++;
            if (t == 6)
            {
                t = 0;
                timer1.Stop();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                OleDbCommand command = new OleDbCommand();
                DataTable T = new DataTable();
                command = cx.CreateCommand();
                command.CommandText = "SELECT Facteur.date_facteur,Client.Nom, Client.prénom,Client.id_client,Facteur.ID_facteur, Conteur.ID_con, Facteur.Nombre_aucien, Facteur.Nombre_nouveau,(Facteur.Nombre_nouveau-Facteur.Nombre_aucien) AS ['fa'],(Facteur.prix_sans_main/(Facteur.Nombre_nouveau-Facteur.Nombre_aucien)) AS ['Pme'],(Facteur.prix_avec_main-Facteur.prix_sans_main) AS ['Pmai'],Facteur.prix_sans_main, Facteur.prix_avec_main FROM unique_, (Client INNER JOIN Conteur ON Client.id_client = Conteur.ID__Client) INNER JOIN Facteur ON Conteur.ID_con = Facteur.Id_cont WHERE (((Facteur.ID_facteur)=" + ID_facteur_txt.Text + "));";
               
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                da.Fill(T);

                Image Image = Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\logiciel gestion de l'eau\img\img1.png");
                Font ftext = new Font("Arial", 12, FontStyle.Regular);



                e.Graphics.DrawImage(Image, 0, 0, e.PageBounds.Width, 236);
                e.Graphics.DrawString(DateTime.Parse(T.Rows[0][0].ToString()).ToShortDateString(), ftext, Brushes.Black, 290, 22);
                e.Graphics.DrawString(T.Rows[0][1].ToString() + " " + T.Rows[0][2].ToString(), ftext, Brushes.Black, 240, 42);
                e.Graphics.DrawString(T.Rows[0][3].ToString(), ftext, Brushes.Black, 340, 63);

                e.Graphics.DrawString(T.Rows[0][4].ToString(), ftext, Brushes.Black, 725, 153);
                e.Graphics.DrawString(T.Rows[0][5].ToString(), ftext, Brushes.Black, 650, 153);
                e.Graphics.DrawString(T.Rows[0][6].ToString(), ftext, Brushes.Black, 544, 153);
                e.Graphics.DrawString(T.Rows[0][7].ToString(), ftext, Brushes.Black, 440, 153);
                e.Graphics.DrawString(String.Format("{0:0.00}", float.Parse(T.Rows[0][8].ToString())), ftext, Brushes.Black, 369, 153);
                e.Graphics.DrawString(String.Format("{0:0.00}", float.Parse(T.Rows[0][9].ToString())), ftext, Brushes.Black, 295, 153);
                e.Graphics.DrawString(String.Format("{0:0.00}", float.Parse(T.Rows[0][10].ToString())), ftext, Brushes.Black, 212, 153);
                e.Graphics.DrawString(String.Format("{0:0.00}", float.Parse(T.Rows[0][11].ToString())), ftext, Brushes.Black, 100, 153);
                e.Graphics.DrawString(String.Format("{0:0.00}", float.Parse(T.Rows[0][12].ToString())), ftext, Brushes.Black, 17, 153);
            }catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(ID_facteur_txt.Text, out int r))
            {
                ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
                printPreviewDialog1.Document = printDocument1;

                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
            else if (nom_txt.Text.Trim() != "" && prénom_txt.Text.Trim() != "")
            {
                ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
                printPreviewDialog1.Document = printDocument2;

                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument2.Print();
                }
            }
            else
            {
                timer1.Start();
            }
        }
        int cnt = 0;
        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                OleDbCommand command = new OleDbCommand();
                DataTable T = new DataTable();
                command = cx.CreateCommand();
                command.CommandText = "SELECT Facteur.date_facteur,Client.Nom, Client.prénom,Client.id_client,Facteur.ID_facteur, Conteur.ID_con, Facteur.Nombre_aucien, Facteur.Nombre_nouveau,(Facteur.Nombre_nouveau-Facteur.Nombre_aucien) AS ['fa'],(Facteur.prix_sans_main/(Facteur.Nombre_nouveau-Facteur.Nombre_aucien)) AS ['Pme'],(Facteur.prix_avec_main-Facteur.prix_sans_main) AS ['Pmai'],Facteur.prix_sans_main, Facteur.prix_avec_main FROM unique_, (Client INNER JOIN Conteur ON Client.id_client = Conteur.ID__Client) INNER JOIN Facteur ON Conteur.ID_con = Facteur.Id_cont WHERE (((Client.Nom)='" + nom_txt.Text + "') AND ((Client.prénom)='" + prénom_txt.Text + "'));";
                cx.Open();
                OleDbDataReader r = command.ExecuteReader();
                T.Load(r);
                r.Close();
                cx.Close();


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
                        e.Graphics.DrawString(DateTime.Parse(T.Rows[cnt][0].ToString()).ToShortDateString(), ftext, Brushes.Black, 290, 22 + yt);
                        e.Graphics.DrawString(T.Rows[cnt][1].ToString() + " " + T.Rows[cnt][2].ToString(), ftext, Brushes.Black, 240, 42 + yt);
                        e.Graphics.DrawString(T.Rows[cnt][3].ToString(), ftext, Brushes.Black, 340, 63 + yt);

                        e.Graphics.DrawString(T.Rows[cnt][4].ToString(), ftext, Brushes.Black, 725, 153 + yt);
                        e.Graphics.DrawString(T.Rows[cnt][5].ToString(), ftext, Brushes.Black, 650, 153 + yt);
                        e.Graphics.DrawString(T.Rows[cnt][6].ToString(), ftext, Brushes.Black, 544, 153 + yt);
                        e.Graphics.DrawString(T.Rows[cnt][7].ToString(), ftext, Brushes.Black, 440, 153 + yt);
                        e.Graphics.DrawString(String.Format("{0:0.00}", float.Parse(T.Rows[cnt][8].ToString())), ftext, Brushes.Black, 369, 153 + yt);
                        e.Graphics.DrawString(String.Format("{0:0.00}", float.Parse(T.Rows[cnt][9].ToString())), ftext, Brushes.Black, 295, 153 + yt);
                        e.Graphics.DrawString(String.Format("{0:0.00}", float.Parse(T.Rows[cnt][10].ToString())), ftext, Brushes.Black, 212, 153 + yt);
                        e.Graphics.DrawString(String.Format("{0:0.00}", float.Parse(T.Rows[cnt][11].ToString())), ftext, Brushes.Black, 100, 153 + yt);
                        e.Graphics.DrawString(String.Format("{0:0.00}", float.Parse(T.Rows[cnt][12].ToString())), ftext, Brushes.Black, 17, 153 + yt);

                        yt += 235;
                    }
                    j++;
                }
                if (cnt == T.Rows.Count)
                {
                    cnt = 0;
                    T.Clear();
                }
            }
            catch (Exception x) { MessageBox.Show(x.Message);
                cx.Close();
            }
        }
    }
}
