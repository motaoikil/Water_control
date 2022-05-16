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
    public partial class parametre : Form
    {
        public parametre()
        {
            InitializeComponent();
        }
        OleDbConnection cx = Form1.cx;
        DataTable un = new DataTable();
        string au = "";

        private void parametre_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT unique_.prix_mettre, unique_.prix_maintenance, unique_.mot,id_un FROM unique_", cx);

                label7.Hide();
                label4.Hide();
                da.Fill(un);
                prix_mettre.Text = un.Rows[0][0].ToString();
                prix_mai.Text = un.Rows[0][1].ToString();
                for (int i = 0; i < un.Rows[0][2].ToString().Length; i++)
                {
                    au += decreptage(un.Rows[0][2].ToString()[i]);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        public char creptage(char c)
        {
            int t = c;
            return (char)(t + 2);
        }
        public char decreptage(char c)
        {
            int t = c;
            return (char)(t - 2);
        }

        private void nouveau_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (auncien_.Text.Trim() == "")
                {
                    nouveau.Clear();
                    auncien_.Focus();
                    MessageBox.Show("أدخال كلمة السر القديمة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (auncien_.Text != au)
                {
                    nouveau.Clear();
                    auncien_.Clear();
                    auncien_.Focus();
                    MessageBox.Show("خطأ في إدخال كلمة السر القديمة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void nouveau2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (auncien_.Text.Trim() == "")
                {
                    MessageBox.Show("أدخال كلمة السر القديمة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nouveau.Clear();
                    auncien_.Focus();
                    nouveau2.Clear();
                }

                else if (nouveau.Text.Trim() == "")
                {
                    MessageBox.Show("أدخال كلمة السر الجديدة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nouveau2.Clear();
                    nouveau.Focus();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(prix_mettre.Text, out double s) && double.TryParse(prix_mai.Text, out double v))
                {
                    if (nouveau.Text != nouveau2.Text)
                    {
                        nouveau.Clear();
                        nouveau2.Clear();
                        MessageBox.Show("كلمتي السر لا تتوافقان", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (nouveau2.Text != "")
                        {
                            un.Rows[0].BeginEdit();
                            un.Rows[0][2] = "";
                            for (int i = 0; i < nouveau2.Text.Length; i++)
                            {
                                un.Rows[0][2] += creptage(nouveau2.Text[i]).ToString();
                            }
                            un.Rows[0].EndEdit();
                        }
                        OleDbDataAdapter da = new OleDbDataAdapter("SELECT unique_.prix_mettre, unique_.prix_maintenance, unique_.mot,id_un FROM unique_", cx);

                        un.Rows[0].BeginEdit();
                        un.Rows[0][0] = double.Parse(prix_mettre.Text);
                        un.Rows[0][1] = double.Parse(prix_mai.Text);
                        un.Rows[0].EndEdit();
                        OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
                        da.Update(un);
                        MessageBox.Show("تم الحفض", "حفض", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        int t = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(prix_mettre.Text, out double w) == false)
                {
                    if (t % 2 == 0)
                    {
                        label7.Show();
                        prix_mettre.Hide();
                    }
                    else
                    {
                        prix_mettre.Show();
                        label7.Hide();
                        prix_mettre.Clear();
                    }
                    prix_mettre.Focus();
                }
                else if (double.TryParse(prix_mai.Text, out double a) == false)
                {
                    if (t % 2 == 0)
                    {
                        label4.Show();
                        prix_mai.Hide();
                    }
                    else
                    {
                        prix_mai.Show();
                        label4.Hide();
                        prix_mai.Clear();
                    }
                    prix_mai.Focus();
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
                MessageBox.Show(x.Message);
            }
        }
    }
}
