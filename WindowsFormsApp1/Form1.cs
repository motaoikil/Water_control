using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Data.OleDb;
using System.Configuration;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\logiciel gestion de l'eau\\base_de_donne.mdb";
       public static OleDbConnection cx = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+path);
        public static OleDbCommand com = cx.CreateCommand();
        public static OleDbDataAdapter tous = new OleDbDataAdapter("select client.id_client , client.prénom , client.nom, Conteur.ID_con , Conteur.date_con , Conteur.Nb_actuel from client inner join Conteur on client.id_client = Conteur.ID__Client", cx);
        public static OleDbDataAdapter client = new OleDbDataAdapter("select id_client,nom,prénom from client",cx);
        public static OleDbDataAdapter conteur = new OleDbDataAdapter("select ID_con,date_con,Nb_actuel,ID__Client from conteur",cx);
        DataSet s = new DataSet();

        private void Form1_Load(object sender, EventArgs e)
        {       

            tous.Fill(s, "tous");
            client.Fill(s, "client");
            conteur.Fill(s, "conteur");
            label5.Hide();
            label4.Hide();
            label7.Hide();
            label8.Hide();
            dataGridView1.DataSource = s.Tables[0];
            clean();
            dataGridView1.Columns[0].HeaderText = "الرقم التسلسلي للمشترك"; 
            dataGridView1.Columns[1].HeaderText = "الاسم";
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[2].HeaderText = "النسب";
            dataGridView1.Columns[3].HeaderText = "الرقم التسلسلي للعداد";
            dataGridView1.Columns[4].HeaderText = "التاريخ تسليم العداد";
            dataGridView1.Columns[5].HeaderText = "عدد الدورات";
        }
        public void clean()
        {
            try
            {
                com.CommandText = "select max(id_client) from client";
                cx.Open();
                ID_txt.Text = ((int)com.ExecuteScalar() + 1).ToString();
                cx.Close();
                prenom_txt.Clear();
                nom_txt.Clear();
                dateTimePicker1.Value = DateTime.Now;
                id_co_.Clear();
                Nb_actuel.Text = "0";
            }
            catch(Exception x)
            {
                cx.Close();
                MessageBox.Show(x.Message);
            }
        }
        
        public void save()
        {
            try
            {
                //for client
                OleDbCommandBuilder b = new OleDbCommandBuilder(client);
                client.Update(s.Tables[1]);
                //for conteur
                OleDbCommandBuilder H = new OleDbCommandBuilder(conteur);
                conteur.Update(s.Tables[2]);
          

            }
            catch (Exception x)
            {
                cx.Close();
                MessageBox.Show(x.Message);
            }

        }
        static int t = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (prenom_txt.Text.Trim() == "")
                {
                    if (t % 2 == 0)
                    {
                        prenom_txt.Hide();
                        label4.Show();
                    }
                    else
                    {
                        prenom_txt.Show();
                        label4.Hide();
                    }
                    prenom_txt.Focus();
                }
                else if (nom_txt.Text.Trim() == "")
                {
                    if (t % 2 == 0)
                    {
                        nom_txt.Hide();
                        label7.Show();
                    }
                    else
                    {
                        nom_txt.Show();
                        label7.Hide();
                    }
                    nom_txt.Focus();
                }
                else if (int.TryParse(id_co_.Text, out int z) == false)
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

                else if (int.TryParse(Nb_actuel.Text, out int q) == false)
                {
                    if (t % 2 == 0)
                    {
                        label8.Show();
                        Nb_actuel.Hide();
                    }
                    else
                    {
                        Nb_actuel.Show();
                        label8.Hide();
                        Nb_actuel.Clear();
                    }
                    id_co_.Focus();
                }
                t++;
                if (t == 6)
                {
                    t = 0;
                    Ajouter_timer.Stop();
                }
            }catch(Exception x)
            {
                cx.Close();
                MessageBox.Show(x.Message);
            }
        }
        public bool T_F_Client(string client)
        {
            foreach (DataRow k in s.Tables[1].Rows)
            {
                if (k[0].ToString() == client)
                {
                    ////////////////MessageBox.Show("هذا المشترك أضيف مسبقا", "خطأ في ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }
        public bool T_F_Conteur(string conteur,bool i)
        {
            try
            {
                foreach (DataRow k in s.Tables[2].Rows)
                {
                    if (k[0].ToString() == conteur)
                    {
                        if (i == true)
                            MessageBox.Show(" هذا العداد يرجع لمشترك اخر", "خطأ في ادخال البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        id_co_.Clear();
                        id_co_.Focus();
                        return true;
                    }
                }
            }catch(Exception x)
            {
                cx.Close();
                MessageBox.Show(x.Message);
            }
            return false;
        }
        private void Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (prenom_txt.Text.Trim() != "" && nom_txt.Text.Trim() != "" && int.TryParse(id_co_.Text, out int y) == true && int.TryParse(Nb_actuel.Text, out int p))
                {
                    if (T_F_Client(ID_txt.Text))
                    {
                        // clean();
                    }
                    else
                    {
                        if (T_F_Conteur(id_co_.Text, true) == false)
                        {

                            //ajouter client
                            DataRow cl = s.Tables[1].NewRow();
                            cl[1] = nom_txt.Text;
                            cl[2] = prenom_txt.Text;
                            s.Tables[1].Rows.Add(cl);


                            ////ajouter conteur
                            DataRow con = s.Tables[2].NewRow();
                            con[0] = int.Parse(id_co_.Text);
                            con[1] = dateTimePicker1.Value.ToShortDateString();
                            con[2] = Nb_actuel.Text;
                            con[3] = int.Parse(ID_txt.Text);
                            s.Tables[2].Rows.Add(con);

                            //ajouter tous
                            DataRow r = s.Tables[0].NewRow();
                            r[0] = int.Parse(ID_txt.Text);
                            r[1] = prenom_txt.Text;
                            r[2] = nom_txt.Text;
                            r[3] = int.Parse(id_co_.Text);
                            r[4] = dateTimePicker1.Value.ToShortDateString();
                            r[5] = Nb_actuel.Text;
                            s.Tables[0].Rows.Add(r);

                            save();
                            clean();

                        }
                    }
                }

                else Ajouter_timer.Start();
            }
            catch(Exception x)
            {
                cx.Close();
                MessageBox.Show(x.Message);
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (prenom_txt.Text.Trim() != "" && nom_txt.Text.Trim() != "" &&int.TryParse(id_co_.Text, out int y) == true && int.TryParse(Nb_actuel.Text, out int p))
                {

                    DialogResult q = MessageBox.Show(" هل أنت متأكد من تعديل هذا المشترك", "التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (DialogResult.Yes == q)
                    {
                        foreach (DataRow r in s.Tables[0].Rows)
                        {
                            if (r[0].ToString() == ID_txt.Text)
                            {
                                r.BeginEdit();
                                r[1] = prenom_txt.Text;
                                r[2] = nom_txt.Text;
                                r[3] = int.Parse(id_co_.Text);
                                r[4] = dateTimePicker1.Value.ToShortDateString();
                                r[5] = Nb_actuel.Text;
                                r.EndEdit();
                                break;
                            }
                        }
                        //com.CommandText = "select id_client,nom,prénom from client";
                        //update client
                        foreach (DataRow r in s.Tables[1].Rows)
                        {
                            if (r[0].ToString() == ID_txt.Text)
                            {
                                r.BeginEdit();
                                r[0] = int.Parse(ID_txt.Text);
                                r[1] = nom_txt.Text;
                                r[2] = prenom_txt.Text;
                                r.EndEdit();
                                break;
                            }
                        }
                        //com.CommandText = "select ID_con,date_con,Nb_actuel,ID_Client from conteur";
                        //update conteur
                        foreach (DataRow r in s.Tables[2].Rows)
                        {
                            if (r[0].ToString() == id_co_.Text)
                            {
                                r.BeginEdit();
                                r[0] = int.Parse(id_co_.Text);
                                r[1] = dateTimePicker1.Value.ToShortDateString();
                                r[2] = Nb_actuel.Text;
                                r[3] = int.Parse(ID_txt.Text);
                                r.EndEdit();
                                break;
                            }
                        }
                        save();
                        clean();
                        MessageBox.Show("تم تعديل", "التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else 
                {
                   MessageBox.Show("اضغط على مشترك أسفله", "الخطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception d)
            {
                cx.Close();
                MessageBox.Show(d.Message);
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (prenom_txt.Text.Trim() != "" && nom_txt.Text.Trim() != "" &&int.TryParse(id_co_.Text, out int y) == true && int.TryParse(Nb_actuel.Text, out int p))
                {

                    DialogResult q = MessageBox.Show("هل أنت متأكد حذف هذا المشترك", "الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (DialogResult.Yes == q)
                    {
                        foreach (DataRow r in s.Tables[0].Rows)
                        {
                            if (r[0].ToString() == ID_txt.Text)
                            {
                                r.Delete();
                                break;
                            }
                        }
                        //com.CommandText = "select id_client,nom,prénom from client";
                        //update client
                        foreach (DataRow r in s.Tables[1].Rows)
                        {
                            if (r[0].ToString() == ID_txt.Text)
                            {
                                r.Delete();
                                break;
                            }
                        }
                        //com.CommandText = "select ID_con,date_con,Nb_actuel,ID_Client from conteur";
                        //update conteur
                        foreach (DataRow r in s.Tables[2].Rows)
                        {
                            if (r[0].ToString() == id_co_.Text)
                            {
                                r.Delete();
                                break;
                            }
                        }
                        try
                        {
                            //for conteur
                            OleDbCommandBuilder H = new OleDbCommandBuilder(conteur);
                            conteur.Update(s.Tables[2]);
                            //for client
                            OleDbCommandBuilder b = new OleDbCommandBuilder(client);
                            client.Update(s.Tables[1]);

                        }
                        catch (Exception x)
                        {
                            MessageBox.Show(x.Message);
                        }
                        clean();
                        MessageBox.Show("تم الحذف", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("اضغط على مشترك أسفله", "الخطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
                cx.Close();
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            clean();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Nb_actuel.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString(); 
                dateTimePicker1.Value = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                id_co_.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(); 
                nom_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                prenom_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(); 
                ID_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void Ajouter_n_conteur_Click(object sender, EventArgs e)
        {
            try
            {
                if (T_F_Conteur(id_co_.Text, false) == false)
                {
                    if (prenom_txt.Text.Trim() != "" && nom_txt.Text.Trim() != "" && int.TryParse(id_co_.Text, out int y) == true && int.TryParse(Nb_actuel.Text, out int p))
                    {
                        //ajouter tous
                        DataRow r = s.Tables[0].NewRow();
                        r[0] = int.Parse(ID_txt.Text);
                        r[1] = prenom_txt.Text;
                        r[2] = nom_txt.Text;
                        r[3] = int.Parse(id_co_.Text);
                        r[4] = dateTimePicker1.Value.ToShortDateString();
                        r[5] = Nb_actuel.Text;
                        s.Tables[0].Rows.Add(r);


                        //ajouter conteur
                        r = s.Tables[2].NewRow();
                        r[0] = int.Parse(id_co_.Text);
                        r[1] = dateTimePicker1.Value.ToShortDateString();
                        r[2] = Nb_actuel.Text;
                        r[3] = int.Parse(ID_txt.Text);
                        s.Tables[2].Rows.Add(r);

                        OleDbCommandBuilder H = new OleDbCommandBuilder(conteur);
                        conteur.Update(s.Tables[2]);
                        clean();

                        MessageBox.Show("تم الإضافة", "الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("اضغط على مشترك أسفله", "الخطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    dateTimePicker1.Value = DateTime.Now;
                    id_co_.Clear();
                    Nb_actuel.Text = "0";
                }
            }catch(Exception x)
            {
                MessageBox.Show(x.Message);
                cx.Close();
            }
        }
    }
}
