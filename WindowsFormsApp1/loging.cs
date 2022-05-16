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
    public partial class loging : Form
    {
        public loging()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (au==textBox1.Text) 
            {
                Affichage f = new Affichage();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("خطأ في إدخال كلمة السر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        public char decreptage(char c)
        {
            int t = c;
            return (char)(t - 2);
        }
        string au = "";

        private void loging_Load(object sender, EventArgs e)
        {
            OleDbConnection cx = Form1.cx;
            DataTable un = new DataTable();

            OleDbDataAdapter da = new OleDbDataAdapter("SELECT unique_.mot,id_un FROM unique_", cx);
            da.Fill(un);
            for (int i = 0; i < un.Rows[0][0].ToString().Length; i++)
            {
                au += decreptage(un.Rows[0][0].ToString()[i]);
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            gunaButton2_Click(sender, e);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gunaButton2_Click(sender,e);
            }
        }
    }
}
