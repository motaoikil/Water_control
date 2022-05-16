using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Affichage : Form
    {
        public Affichage()
        {
            InitializeComponent();
        }
        private void Affichage_Load(object sender, EventArgs e)
        {
            P_2.Hide();
            P_3.Hide();
            P_1.Show();
            P_4.Hide();
            payement_click(sender, e);
                }
        private void Ajouter_Click(object sender, EventArgs e)
        {
            bibutton();

            gunaButton3.BaseColor = Color.PaleGreen;
            gunaButton1.BaseColor = Color.PaleGreen;

            gunaButton2.BaseColor = Color.PaleGreen;

            button13.BaseColor = Color.PaleGreen;

            if (P_2.Visible == false)
            {
                P_2.Location = new Point(3, 85);
                P_2.Size = new Size(648,467); 
                P_1.Hide();               
                P_2.Show();
                P_3.Hide();
                P_4.Hide();
            }
            else
            {
                P_2.Hide();
                P_3.Hide();
                P_4.Hide();
                P_1.Show();
            }

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     

        private void button27_Click(object sender, EventArgs e)
        {
            bibutton();
            gunaButton1.BaseColor = Color.PaleGreen;

            gunaButton19.BaseColor =Color.FromArgb(151, 143, 255);

            P_accuil.Controls.Clear();
            Form1 h = new Form1()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            P_accuil.Controls.Add(h);
            h.Show();         
        }
        private void Recherche_Click(object sender, EventArgs e)
        {
            bibutton();
            gunaButton5.BaseColor = Color.PaleGreen;

            gunaButton6.BaseColor = Color.PaleGreen;

            gunaButton4.BaseColor = Color.PaleGreen;

            button5.BaseColor = Color.PaleGreen;


            if (P_3.Visible == false)
            {
                P_3.Location = P_1.Location;
                P_3.Size = new Size(P_1.Size.Width, P_1.Size.Height+80);
                P_1.Hide();
                P_4.Hide();
                P_2.Hide();
                P_3.Show();
            }
            else
            {
                P_2.Hide();
                P_3.Hide();
                P_4.Hide();
                P_1.Show();
            }
        }

        private void Paramerte_Click(object sender, EventArgs e)
        {
            bibutton();
            gunaButton18.BaseColor = Color.PaleGreen;

            button2.BaseColor = Color.PaleGreen;
            gunaButton16.BaseColor = Color.PaleGreen;


            P_2.Hide();
            P_3.Hide();
            P_4.Hide();
            P_1.Show();
            P_accuil.Controls.Clear();

            parametre h = new parametre()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            P_accuil.Controls.Add(h);
            h.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bibutton();

            gunaButton12.BaseColor = Color.PaleGreen;

            gunaButton10.BaseColor = Color.PaleGreen;



            //mantement
            if (P_4.Visible == false)
            {
                P_4.Location = P_1.Location;
                P_4.Size =new Size(P_1.Size.Width, P_1.Size.Height+80);
                P_1.Hide();
                P_3.Hide();
                P_2.Hide();
                P_4.Show();
            }
            else
            {
                P_2.Hide();
                P_3.Hide();
                P_4.Hide();
                P_1.Show();
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            bibutton();
            gunaButton1.BaseColor = Color.PaleGreen;

            gunaButton20.BaseColor = Color.FromArgb(151, 143, 255);

            P_accuil.Controls.Clear();

            facteur h = new facteur()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            P_accuil.Controls.Add(h);
            h.Show();           
        }

        private void button22_Click(object sender, EventArgs e)
        {
            bibutton();
            gunaButton15.BaseColor = Color.PaleGreen;

            button38.BaseColor = Color.PaleGreen;
            gunaButton13.BaseColor = Color.PaleGreen;


            P_2.Hide();
            P_3.Hide();
            P_4.Hide();
            P_1.Show();

            P_accuil.Controls.Clear();

            maintenance h = new maintenance()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            P_accuil.Controls.Add(h);
            h.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            bibutton();
            gunaButton5.BaseColor = Color.PaleGreen;

            gunaButton21.BaseColor = Color.FromArgb(151 ,143, 255);

            P_accuil.Controls.Clear();

            R_conteur h = new R_conteur()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            P_accuil.Controls.Add(h);
            h.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            bibutton();
            gunaButton5.BaseColor = Color.PaleGreen;

            gunaButton22.BaseColor = Color.FromArgb(151, 143, 255);

            P_accuil.Controls.Clear();

            R_facteur h = new R_facteur()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            P_accuil.Controls.Add(h);
            h.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //recherche pet
            if (P_3.Visible == false)
            {
                P_3.Location = P_1.Location;
                P_3.Size = new Size(P_1.Size.Width, P_1.Size.Height + 80);
                P_1.Hide();
                P_4.Hide();
                P_2.Hide();
                P_3.Show();
            }
            else
            {
                P_2.Hide();
                P_3.Hide();
                P_4.Hide();
                P_1.Show();
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //mant pet
            if (P_4.Visible == false)
            {
                P_4.Location = P_1.Location;
                P_4.Size = new Size(P_1.Size.Width, P_1.Size.Height + 80);
                P_1.Hide();
                P_3.Hide();
                P_2.Hide();
                P_4.Show();
            }
            else
            {
                P_2.Hide();
                P_3.Hide();
                P_4.Hide();
                P_1.Show();
            }
        }
        public void bibutton()
        {
            button38.BaseColor = Color.PaleTurquoise;
            button13.BaseColor = Color.PaleTurquoise;
            button5.BaseColor = Color.PaleTurquoise;
            payement.BaseColor = Color.PaleTurquoise;
            button10.BaseColor = Color.PaleTurquoise;
            button2.BaseColor = Color.PaleTurquoise;
            gunaButton2.BaseColor = Color.PaleTurquoise;
            gunaButton5.BaseColor = Color.PaleTurquoise;
            gunaButton8.BaseColor = Color.PaleTurquoise;
            gunaButton14.BaseColor = Color.PaleTurquoise;
            gunaButton17.BaseColor = Color.PaleTurquoise;
            gunaButton11.BaseColor = Color.PaleTurquoise;

            gunaButton1.BaseColor = Color.PaleTurquoise;
            gunaButton4.BaseColor = Color.PaleTurquoise;
            gunaButton7.BaseColor = Color.PaleTurquoise;
            gunaButton10.BaseColor = Color.PaleTurquoise;
            gunaButton13.BaseColor = Color.PaleTurquoise;
            gunaButton16.BaseColor = Color.PaleTurquoise;
            gunaButton3.BaseColor = Color.PaleTurquoise;
            gunaButton6.BaseColor = Color.PaleTurquoise;
            gunaButton9.BaseColor = Color.PaleTurquoise;
            gunaButton12.BaseColor = Color.PaleTurquoise;
            gunaButton15.BaseColor = Color.PaleTurquoise;
            gunaButton18.BaseColor = Color.PaleTurquoise;

            gunaButton21.BaseColor = Color.PaleTurquoise;
            gunaButton22.BaseColor = Color.PaleTurquoise;
            gunaButton19.BaseColor = Color.PaleTurquoise;
            gunaButton20.BaseColor = Color.PaleTurquoise;
            gunaButton23.BaseColor = Color.PaleTurquoise;
            gunaButton24.BaseColor = Color.PaleTurquoise;
        }
        private void payement_click(object sender, EventArgs e)
        {
            bibutton();
            gunaButton9.BaseColor = Color.PaleGreen;

            gunaButton7.BaseColor = Color.PaleGreen;

            payement.BaseColor = Color.PaleGreen;

            payement.BaseColor = Color.PaleGreen;

            P_2.Hide();
            P_3.Hide();
            P_4.Hide();
            P_1.Show();
            P_accuil.Controls.Clear();

            payment h = new payment()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            P_accuil.Controls.Add(h);
            h.Show();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            bibutton();
            gunaButton12.BaseColor = Color.PaleGreen;

            gunaButton23.BaseColor = Color.FromArgb(151, 143, 255);

            P_accuil.Controls.Clear();

            P_facteur h = new P_facteur()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            P_accuil.Controls.Add(h);
            h.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            bibutton();
            gunaButton12.BaseColor = Color.PaleGreen;

            gunaButton24.BaseColor = Color.FromArgb(151, 143, 255);

            P_accuil.Controls.Clear();

            NP_facteur h = new NP_facteur()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            P_accuil.Controls.Add(h);
            h.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            P_accuil.Controls.Clear();

            parametre h = new parametre()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            P_accuil.Controls.Add(h);
            h.Show();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            P_accuil.Controls.Clear();

            payment h = new payment()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            P_accuil.Controls.Add(h);
            h.Show();
        }
    }
}
