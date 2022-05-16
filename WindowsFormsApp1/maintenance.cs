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
    public partial class maintenance : Form
    {
        public maintenance()
        {
            InitializeComponent();
        }
        DataTable mm = new DataTable();
        OleDbConnection cx = Form1.cx;
        DataSet s = new DataSet("dze");
        bool lo = false;
        public bool remplir(string re, ComboBox co)
        {
            try
            {
                lo = false;
                DataTable t = new DataTable();
                OleDbDataAdapter te = new OleDbDataAdapter(re, cx);
                te.Fill(t);
                if (t.Rows.Count == 0)
                {
                    lo = true;
                    return false; }
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
                cx.Close();
                MessageBox.Show(x.Message);
            }
            return true;
        }
        private void maintenance_Load(object sender, EventArgs e)
        {
            try
            {
                label9.Hide();
                label7.Hide();
                label13.Hide();
                label14.Hide();
                label11.Hide();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT Conteur.ID_con, Maintenance.id_mai, Client.prénom, Client.Nom, Maintenance.prix_main, Maintenance.date_mai, Maintenance.Description_ FROM (Client INNER JOIN Conteur ON Client.id_client = Conteur.ID__Client) INNER JOIN Maintenance ON Conteur.ID_con = Maintenance.id_conteur", cx);
                OleDbDataAdapter ma = new OleDbDataAdapter("SELECT Maintenance.id_mai, Maintenance.id_conteur, Maintenance.Description_, Maintenance.date_mai, Maintenance.prix_main FROM Maintenance", cx);

                ma.Fill(mm);
                da.Fill(s, "main");
                dataGridView1.DataSource = s.Tables[0];
                dataGridView1.Columns[0].HeaderText = "رقم العداد";
                dataGridView1.Columns[1].HeaderText = "رقم التسلسلي للعطب";
                dataGridView1.Columns[2].HeaderText = "الإسم";
                dataGridView1.Columns[3].HeaderText = "النسب";
                dataGridView1.Columns[4].HeaderText = "تكلفة اصلاح العطب";
                dataGridView1.Columns[5].HeaderText = "تاريخ اصلاح العطب";
                dataGridView1.Columns[6].HeaderText = "التعليق";
                clean();
            }
            catch(Exception x)
            {
                cx.Close();
                MessageBox.Show(x.Message);
            }
        }
        public void clean()
        {
            try
            {
                OleDbCommand com = cx.CreateCommand();

                com.CommandText = "select max(id_mai) from Maintenance";
                cx.Open();
                id.Text = ((int)com.ExecuteScalar() + 1).ToString();
                cx.Close();
                DataTable t = new DataTable();
                prénom_txt.DataSource = t;
                remplir("select distinct nom from client", nom_txt);
                id_con.DataSource = t;
                dateTimePicker1.Value = DateTime.Now;
                prix_main.Clear();
                déscreption.Clear();
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
                OleDbDataAdapter ma = new OleDbDataAdapter("SELECT Maintenance.id_mai, Maintenance.id_conteur, Maintenance.Description_, Maintenance.date_mai, Maintenance.prix_main FROM Maintenance", cx);

                OleDbCommandBuilder cb = new OleDbCommandBuilder(ma);
                ma.Update(mm);
            } catch (Exception x)
            {
                cx.Close();
                MessageBox.Show(x.Message);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(prix_main.Text, out double w) && prénom_txt.Text.Trim() != "" && nom_txt.Text.Trim() != "" && id_con.Text.Trim() != "" && déscreption.Text.Trim() != "")
                {
                    //Ajouter
                    //pour affichage
                    DataRow r = s.Tables[0].NewRow();
                    r[0] = int.Parse(id_con.Text);
                    r[1] = int.Parse(id.Text);
                    r[2] = prénom_txt.Text;
                    r[3] = nom_txt.Text;
                    r[4] = double.Parse(prix_main.Text);
                    r[5] = dateTimePicker1.Value.ToShortDateString();
                    r[6] = déscreption.Text;
                    s.Tables[0].Rows.Add(r);


                    //pour le enregestrement
                    DataRow rr = mm.NewRow();
                    rr[1] = int.Parse(id_con.Text);
                    rr[2] = déscreption.Text;
                    rr[3] = dateTimePicker1.Value.ToShortDateString();
                    rr[4] = double.Parse(prix_main.Text);
                    mm.Rows.Add(rr);
                    save();
                    clean();

                }
                else
                {
                    timer1.Start();
                }
            } catch (Exception x)
            {
                cx.Close();
                MessageBox.Show(x.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(prix_main.Text, out double w) && prénom_txt.Text.Trim() != "" && nom_txt.Text.Trim() != "" && id_con.Text.Trim() != "" && déscreption.Text.Trim() != "")
                {
                    DialogResult q = MessageBox.Show("هل أنت متأكد من تعديل العطب", "التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (DialogResult.Yes == q)
                    {
                        foreach (DataRow r in s.Tables[0].Rows)
                        {
                            if (r[1].ToString() == id.Text)
                            {
                                r.BeginEdit();
                                r[1] = int.Parse(id.Text);
                                r[2] = prénom_txt.Text;
                                r[3] = nom_txt.Text;
                                r[4] = double.Parse(prix_main.Text);
                                r[5] = dateTimePicker1.Value.ToShortDateString();
                                r[6] = déscreption.Text;
                                r.EndEdit();
                                break;
                            }
                        }

                        foreach (DataRow rr in mm.Rows)
                        {
                            if (rr[0].ToString() == id.Text)
                            {
                                rr.BeginEdit();
                                rr[1] = int.Parse(id_con.Text);
                                rr[2] = déscreption.Text;
                                rr[3] = dateTimePicker1.Value.ToShortDateString();
                                rr[4] = double.Parse(prix_main.Text);
                                rr.EndEdit();
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
                    timer1.Start();
                }
            }
            catch (Exception d)
            {
                cx.Close();
                MessageBox.Show(d.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {

                    prix_main.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    déscreption.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                    dateTimePicker1.Value = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                    nom_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    prénom_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    id.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    DataTable ta = new DataTable();
                    ta.Columns.Add(new DataColumn());
                    DataRow r = ta.NewRow();
                    r[0] = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    ta.Rows.Add(r);
                    id_con.DataSource = ta;
                    id_con.DisplayMember = ta.Columns[0].ColumnName;
                    id_con.ValueMember = ta.Columns[0].ColumnName;
                    //id_con.Text= dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                }
            } catch (Exception x)
            {
                cx.Close();
                MessageBox.Show(x.Message);
            }
        }

        private void prénom_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (nom_txt.Text.Trim() != "" && prénom_txt.Text.Trim() != "" && lo == true)
                {
                    bool t = remplir("SELECT Conteur.ID_con FROM Client INNER JOIN Conteur ON Client.id_client = Conteur.ID__Client where Client.nom='" + nom_txt.Text + "' and Client.prénom= '" + prénom_txt.Text + "'", id_con);
                    if (t == false)
                    {
                        DataTable ta = new DataTable();
                        id_con.DataSource = ta;
                    }
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
                if (nom_txt.Text.Trim() != "" && lo == true)
                {
                    remplir("select prénom from client where nom= '" + nom_txt.Text + "'", prénom_txt);
                }
            } catch (Exception x)
            {
                cx.Close();
                MessageBox.Show(x.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Suppreme
                DialogResult q = MessageBox.Show("هل أنت متأكد حذف العطب", "الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (DialogResult.Yes == q)
                {
                    foreach (DataRow r in s.Tables[0].Rows)
                    {
                        if (r[1].ToString() == id.Text)
                        {
                            r.Delete();
                            break;
                        }
                    }

                    foreach (DataRow r in mm.Rows)
                    {
                        if (r[0].ToString() == id.Text)
                        {
                            r.Delete();
                            break;
                        }
                    }
                    save();
                    clean();
                    MessageBox.Show("تم الحذف", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("لم يتم الحذف", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch (Exception x)
            {
                cx.Close();
                MessageBox.Show(x.Message);
            }
        }
        int t = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (id_con.Text.Trim() == "")
                {
                    if (t % 2 == 0)
                    {
                        id_con.Hide();
                        label13.Show();
                    }
                    else
                    {
                        id_con.Show();
                        label13.Hide();
                    }
                }
                else if (nom_txt.Text.Trim() == "")
                {
                    if (t % 2 == 0)
                    {
                        nom_txt.Hide();
                        label11.Show();
                    }
                    else
                    {
                        nom_txt.Show();
                        label11.Hide();
                    }
                }
                else if (prénom_txt.Text.Trim() == "")
                {
                    if (t % 2 == 0)
                    {
                        prénom_txt.Hide();
                        label14.Show();
                    }
                    else
                    {
                        prénom_txt.Show();
                        label14.Hide();
                    }
                }
                else if (double.TryParse(prix_main.Text, out double w) == false)
                {
                    if (t % 2 == 0)
                    {
                        label7.Show();
                        prix_main.Hide();
                    }
                    else
                    {
                        prix_main.Show();
                        label7.Hide();
                        prix_main.Clear();
                    }
                    prix_main.Focus();
                }
                else if (déscreption.Text.Trim() == "")
                {
                    if (t % 2 == 0)
                    {
                        déscreption.Hide();
                        label9.Show();
                    }
                    else
                    {
                        déscreption.Show();
                        label9.Hide();
                    }
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
    } 
}
