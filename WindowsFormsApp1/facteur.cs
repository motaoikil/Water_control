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
    public partial class facteur : Form
    {
        public facteur()
        {
            InitializeComponent();
        }
        OleDbConnection cx = Form1.cx;
        DataSet s = new DataSet();
        public void clean()
        {
            try
            {
                OleDbCommand com = cx.CreateCommand();
                com.CommandText = "Select max(ID_facteur) from Facteur";
                cx.Open();
                ID_facteur_txt.Text = ((int)com.ExecuteScalar() + 1).ToString();
                cx.Close();


                DataTable t = new DataTable();
                com = cx.CreateCommand();
                com.CommandText = "SELECT unique_.prix_mettre, unique_.prix_maintenance FROM unique_";
                cx.Open();
                OleDbDataReader r = com.ExecuteReader();
                t.Load(r);
                r.Close();
                cx.Close();

                double prix_mi = double.Parse(t.Rows[0][1].ToString());
                double prix_m = double.Parse(t.Rows[0][0].ToString());

                prix_mai.Text = prix_mi.ToString();
                prix_mettre.Text = prix_m.ToString();


                nouveau_.Clear();
                aucien_.Clear();
                Id_con.Text = "";

                date_.Value = DateTime.Now;
                prix_avec.Clear();

                prix_sans.Clear();

                DataTable p = new DataTable();
                id_client.DataSource = p;
                Id_con.DataSource = p;
                nom_txt.Text = "";
                prenom_txt.DataSource = p;
            }
            catch (Exception x)
            {
                cx.Close();
                MessageBox.Show(x.Message);
            }
        }
        bool go;
        public bool remplir(string re, ComboBox co)
        {
            try
            {
                DataTable t = new DataTable();
                OleDbDataAdapter te = new OleDbDataAdapter(re, cx);
                te.Fill(t);
                go = false;
                co.DataSource = t;
                co.DisplayMember = t.Columns[0].ColumnName;
                go = true;
                if (t.Rows.Count == 0) { return false; }
            }
            catch (Exception x)
            {
                cx.Close();
                MessageBox.Show(x.Message);
            }
            return true;
        }
        bool lo;
        private void facteur_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime d;
                if (DateTime.Today.Month == 1)
                {
                    d = new DateTime(DateTime.Today.Year - 1, 12, 1);
                }
                else
                {
                    d = new DateTime(DateTime.Today.Year, DateTime.Today.Month - 1, 1); ;
                }
                date1.Value = d;
                date2.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
  


                panel1.Hide();
                lo = false;

                label13.Hide();
                label14.Hide();
                label15.Hide();
                label16.Hide();
                label17.Hide();
                label18.Hide();
                OleDbDataAdapter fac = new OleDbDataAdapter("SELECT Facteur.ID_facteur, Facteur.date_facteur, Facteur.Nombre_aucien, Facteur.Nombre_nouveau, Facteur.prix_sans_main, Facteur.prix_avec_main, Facteur.Id_cont FROM Facteur ", cx);
                OleDbDataAdapter tous = new OleDbDataAdapter("SELECT ID_facteur,id_client,ID_con,date_facteur,prénom,Nom,Nombre_aucien,Nombre_nouveau,prix_sans_main,prix_avec_main FROM (Client AS c INNER JOIN Conteur AS co ON c.id_client = co.ID__Client) INNER JOIN Facteur AS F ON F.Id_cont = co.ID_con", cx);

                tous.Fill(s, "tous");
                fac.Fill(s, "facteur");
                dataGridView1.DataSource = s.Tables[0];

                remplir("select distinct Nom from client", nom_txt);
                //remplir("select distinct prénom from client", prenom_txt);

                dataGridView1.Columns[0].HeaderText = "رقم الفاتورة";
                dataGridView1.Columns[1].HeaderText = "رقم المشترك";
                dataGridView1.Columns[2].HeaderText = "رقم العداد";
                dataGridView1.Columns[3].HeaderText = "تاريخ الفاتورة";
                dataGridView1.Columns[4].HeaderText = "الإسم";
                dataGridView1.Columns[5].HeaderText = "النسب";
                dataGridView1.Columns[6].HeaderText = "العددالقديم";
                dataGridView1.Columns[7].HeaderText = "العدد الجديد";
                dataGridView1.Columns[8].HeaderText = "مبلغ الفاتورة";
                dataGridView1.Columns[9].HeaderText = "مبلغ الفاتورة+واجب الإصلاح";

                clean();

                lo = true;
            }
            catch (Exception x)
            {
                cx.Close();
                MessageBox.Show(x.Message);
            }
        }
        private void prenom_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (nom_txt.Text.Trim() != "" && prenom_txt.Text.Trim() != "" && lo == true && go == true)
                {
                    remplir("select id_client from client where nom='" + nom_txt.Text + "' and prénom= '" + prenom_txt.Text + "'", id_client);
                }
            }
            catch (Exception x)
            {
                cx.Close();
                MessageBox.Show(x.Message);
            }
        }

        private void nom_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (nom_txt.Text.Trim() != "" && prenom_txt.Text.Trim() != "" && lo == true && go == true)
                {
                    bool t = remplir("select id_client from client where nom='" + nom_txt.Text + "' and prénom= '" + prenom_txt.Text + "'", id_client);
                    if (t == false)
                    {
                        id_client.Text = "";

                        remplir("select distinct prénom from client where nom= '" + nom_txt.Text + "'", prenom_txt);
                    }
                }
                else if (nom_txt.Text.Trim() != "")
                {
                    remplir("select distinct prénom from client where nom= '" + nom_txt.Text + "'", prenom_txt);
                }
            }
            catch (Exception x)
            {
                cx.Close();
                MessageBox.Show(x.Message);
            }
        }

        private void Id_con_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand com = cx.CreateCommand();

                if (int.TryParse(Id_con.Text, out int y) == true)
                {
                    com = cx.CreateCommand();
                    com.CommandText = "select Nb_actuel from conteur where ID_con= " + Id_con.Text;
                    cx.Open();
                    aucien_.Text = ((int)com.ExecuteScalar()).ToString();
                    cx.Close();
                }
            }
            catch (Exception x)
            {
                cx.Close();
                MessageBox.Show(x.Message);
            }
        }

        private void id_client_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (id_client.Text.Trim() != "" && nom_txt.Text.Trim() != "" && prenom_txt.Text.Trim() != "" && lo == true && go == true)
                {
                    remplir("select ID_con from Conteur inner join Client on Client.id_client=Conteur.ID__Client where Client.id_client= " + id_client.Text, Id_con);
                }
            }
            catch (Exception x)
            {
                cx.Close();
                MessageBox.Show(x.Message);
            }
        }

        private void nouveau__TextChanged(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand com = cx.CreateCommand();

                if (double.TryParse(nouveau_.Text, out double b))
                {
                    DataTable t = new DataTable();
                    com = cx.CreateCommand();
                    com.CommandText = "SELECT unique_.prix_mettre, unique_.prix_maintenance FROM unique_";
                    cx.Open();
                    OleDbDataReader r = com.ExecuteReader();
                    t.Load(r);
                    r.Close();
                    cx.Close();
                    double prix_n = double.Parse(nouveau_.Text);
                    double prix_a = double.Parse(aucien_.Text);
                    double prix_mi = double.Parse(t.Rows[0][1].ToString());
                    double prix_m = double.Parse(t.Rows[0][0].ToString());


                    prix_sans.Text = ((prix_n - prix_a) * prix_m).ToString();
                    prix_avec.Text = (((prix_n - prix_a) * prix_m) + prix_mi).ToString();
                }
                else
                {
                    prix_sans.Clear();
                    prix_avec.Clear();
                }
            }
            catch (Exception x)
            {
                cx.Close();
                MessageBox.Show(x.Message);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    remplir("select ID_con from Conteur inner join Client on Client.id_client=Conteur.ID__Client where Client.id_client= " + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), Id_con);



                    ID_facteur_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                    id_client.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    Id_con.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                    date_.Value = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                    prenom_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    nom_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    aucien_.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                    nouveau_.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                    prix_sans.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                    prix_avec.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();

                    prix_mai.Text = Math.Round((double.Parse(dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString()) - double.Parse(dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString())), 2).ToString();
                    prix_mettre.Text = Math.Round((double.Parse(dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString()) / (double.Parse(dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString()) - double.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString()))), 2).ToString();
                    remplir("select id_client from client where nom='" + nom_txt.Text + "' and prénom= '" + prenom_txt.Text + "'", id_client);

                }
            }
            catch (Exception x)
            {
                cx.Close();
                MessageBox.Show(x.Message);
            }
        }
        public void save()
        {
            try
            {
                OleDbCommand com = cx.CreateCommand();
                OleDbDataAdapter fac = new OleDbDataAdapter("SELECT Facteur.ID_facteur, Facteur.date_facteur, Facteur.Nombre_aucien, Facteur.Nombre_nouveau, Facteur.prix_sans_main, Facteur.prix_avec_main, Facteur.Id_cont FROM Facteur ", cx);

                OleDbCommandBuilder cb = new OleDbCommandBuilder(fac);
                fac.Update(s.Tables[1]);

                com = cx.CreateCommand();
                com.CommandText = "update Conteur set Nb_actuel= " + nouveau_.Text + " where ID_con= " + Id_con.Text;
                cx.Open();
                com.ExecuteNonQuery();
                cx.Close();
            }
            catch (Exception x)
            {
                cx.Close();
                MessageBox.Show(x.Message);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                //Ajouter
                if (int.TryParse(nouveau_.Text, out int z) && aucien_.Text.Trim() != "" && Id_con.Text.Trim() != "" && id_client.Text.Trim() != "" && prenom_txt.Text.Trim() != "" && nom_txt.Text.Trim() != "")
                {
                    //pour affichage
                    DataRow r = s.Tables[0].NewRow();
                    r[0] = int.Parse(ID_facteur_txt.Text);
                    r[1] = int.Parse(id_client.Text);
                    r[2] = int.Parse(Id_con.Text);
                    r[3] = date_.Value.ToShortDateString();
                    r[4] = prenom_txt.Text;
                    r[5] = nom_txt.Text;
                    r[6] = int.Parse(aucien_.Text);
                    r[7] = int.Parse(nouveau_.Text);
                    r[8] = double.Parse(prix_sans.Text);
                    r[9] = double.Parse(prix_avec.Text);
                    s.Tables[0].Rows.Add(r);

                    //for save
                    r = s.Tables[1].NewRow();
                    r[1] = date_.Value.ToShortDateString();
                    r[2] = int.Parse(aucien_.Text);
                    r[3] = int.Parse(nouveau_.Text);
                    r[4] = double.Parse(prix_sans.Text);
                    r[5] = double.Parse(prix_avec.Text);
                    r[6] = int.Parse(Id_con.Text);
                    s.Tables[1].Rows.Add(r);

                    save();
                    clean();
                }
                else
                {
                    timer1.Start();
                }
            }
            catch (Exception x)
            {
                cx.Close();
                MessageBox.Show(x.Message);
            }
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            clean();
        }
        static int t = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (nom_txt.Text.Trim() == "")
                {
                    if (t % 2 == 0)
                    {
                        nom_txt.Hide();
                        label15.Show();
                    }
                    else
                    {
                        nom_txt.Show();
                        label15.Hide();
                    }
                }

                else if (prenom_txt.Text.Trim() == "")
                {
                    if (t % 2 == 0)
                    {
                        prenom_txt.Hide();
                        label17.Show();
                    }
                    else
                    {
                        prenom_txt.Show();
                        label17.Hide();
                    }
                }
                else if (id_client.Text.Trim() == "")
                {
                    if (t % 2 == 0)
                    {
                        id_client.Hide();
                        label14.Show();
                    }
                    else
                    {
                        id_client.Show();
                        label14.Hide();
                    }
                }
                else if (Id_con.Text.Trim() == "")
                {
                    if (t % 2 == 0)
                    {
                        Id_con.Hide();
                        label18.Show();
                    }
                    else
                    {
                        Id_con.Show();
                        label18.Hide();
                    }
                }
                else if (aucien_.Text.Trim() == "")
                {
                    if (t % 2 == 0)
                    {
                        aucien_.Hide();
                        label13.Show();
                    }
                    else
                    {
                        aucien_.Show();
                        label13.Hide();
                    }
                }
                else if (int.TryParse(nouveau_.Text, out int z) == false)
                {
                    if (t % 2 == 0)
                    {
                        label16.Show();
                        nouveau_.Hide();
                    }
                    else
                    {
                        nouveau_.Show();
                        label16.Hide();
                        nouveau_.Clear();
                    }
                    nouveau_.Focus();
                }


                t++;
                if (t == 6)
                {
                    t = 0;
                    timer1.Stop();
                }
            }
            catch (Exception x)
            {
                cx.Close();
                MessageBox.Show(x.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }
        int cnt = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                OleDbCommand command = new OleDbCommand();
                DataTable T = new DataTable();
                command = cx.CreateCommand();
                command.CommandText = "SELECT Facteur.date_facteur,Client.Nom, Client.prénom,Client.id_client,Facteur.ID_facteur, Conteur.ID_con, Facteur.Nombre_aucien, Facteur.Nombre_nouveau,(Facteur.Nombre_nouveau-Facteur.Nombre_aucien) AS ['fa'],(Facteur.prix_sans_main/(Facteur.Nombre_nouveau-Facteur.Nombre_aucien)) AS ['Pme'],(Facteur.prix_avec_main-Facteur.prix_sans_main) AS ['Pmai'],Facteur.prix_sans_main, Facteur.prix_avec_main FROM unique_, (Client INNER JOIN Conteur ON Client.id_client = Conteur.ID__Client) INNER JOIN Facteur ON Conteur.ID_con = Facteur.Id_cont WHERE (((Facteur.date_facteur)>=#" + date1.Value.Month + "/" + date1.Value.Day + "/" + date1.Value.Year + "#) AND ((Facteur.date_facteur)<=#" + date2.Value.Month + "/" + date2.Value.Day + "/" + date2.Value.Year + "#));";
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
                        e.Graphics.DrawString(T.Rows[cnt][8].ToString(), ftext, Brushes.Black, 369, 153 + yt);
                        e.Graphics.DrawString(String.Format("{0:0.00}", float.Parse(T.Rows[cnt][9].ToString())), ftext, Brushes.Black, 295, 153 + yt);
                        e.Graphics.DrawString(String.Format("{0:0.00}", float.Parse(T.Rows[cnt][10].ToString())), ftext, Brushes.Black, 212, 153 + yt);
                        e.Graphics.DrawString(String.Format("{0:0.00}", float.Parse(T.Rows[cnt][11].ToString())), ftext, Brushes.Black, 100, 153 + yt);
                        e.Graphics.DrawString(String.Format("{0:0.00}", float.Parse(T.Rows[cnt][12].ToString())), ftext, Brushes.Black, 17, 153 + yt);

                        yt += 235;
                    }
                    j++;
                }
                if (cnt == T.Rows.Count)
                    cnt = 0;
                T.Clear();
            }catch(Exception x)
            {
                cx.Close();
                MessageBox.Show(x.Message);
            }
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {

            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            printPreviewDialog1.Document = printDocument1;

            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }
    }
}
