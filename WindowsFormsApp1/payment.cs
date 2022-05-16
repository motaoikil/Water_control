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
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }
        OleDbConnection cx = Form1.cx;

        private void payment_Load(object sender, EventArgs e)
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
            dv.RowFilter = "date_facteur >= '"+date1.Value+"' and date_facteur <= '"+date2.Value+"'";
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

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                OleDbCommand cmd = cx.CreateCommand();
                if (dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString() == "True")
                {
                    dataGridView1.Rows[e.RowIndex].Cells[8].Value = false;
                    cmd.CommandText = "update Facteur set paie=false where ID_facteur=" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                }
                else
                {
                    dataGridView1.Rows[e.RowIndex].Cells[8].Value = true;
                    cmd.CommandText = "update Facteur set paie=true where ID_facteur=" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                }
                cx.Open();
                cmd.ExecuteNonQuery();
                cx.Close();
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DataTable t = new DataTable();
            OleDbDataAdapter tous = new OleDbDataAdapter("SELECT prénom,Nom,ID_facteur,ID_con,date_facteur,Nombre_aucien,Nombre_nouveau,prix_avec_main,F.paie FROM (Client AS c INNER JOIN Conteur AS co ON c.id_client = co.ID__Client) INNER JOIN Facteur AS F ON F.Id_cont = co.ID_con", cx);

            tous.Fill(t);
            DataView dv = new DataView(t);
            dv.RowFilter = "date_facteur >= '" + date1.Value + "' and date_facteur <= '" + date2.Value + "'";
            dataGridView1.DataSource = dv;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DataTable t = new DataTable();
            OleDbDataAdapter tous = new OleDbDataAdapter("SELECT prénom,Nom,ID_facteur,ID_con,date_facteur,Nombre_aucien,Nombre_nouveau,prix_avec_main,F.paie FROM (Client AS c INNER JOIN Conteur AS co ON c.id_client = co.ID__Client) INNER JOIN Facteur AS F ON F.Id_cont = co.ID_con", cx);

            tous.Fill(t);
            DataView dv = new DataView(t);
            dv.RowFilter = "date_facteur >= '" + date1.Value + "' and date_facteur <= '" + date2.Value + "'";
            dataGridView1.DataSource = dv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //true
            OleDbCommand cmd = cx.CreateCommand();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[8].Value = true;
            }
            cmd.CommandText = @"update Facteur set paie=true WHERE (((Facteur.date_facteur)>= #" + date1.Value.Month + "/" + date1.Value.Day + "/" + date1.Value.Year + "#) and (date_facteur <=#" + date2.Value.Month + "/" + date2.Value.Day + "/" + date2.Value.Year + "#))";
            cx.Open();
            cmd.ExecuteNonQuery();
            cx.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //false
            OleDbCommand cmd = cx.CreateCommand();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[8].Value = false;
            }
            cmd.CommandText = @"update Facteur set paie=false WHERE (((Facteur.date_facteur)>= #"+date1.Value.Month+"/"+ date1.Value.Day+"/"+ date1.Value.Year+"#) and (date_facteur <=#"+date2.Value.Month + "/" + date2.Value.Day + "/" + date2.Value.Year + "#))";
            cx.Open();
            cmd.ExecuteNonQuery();
            cx.Close();
        }
    }
}
