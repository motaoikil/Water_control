
namespace WindowsFormsApp1
{
    partial class R_facteur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(R_facteur));
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.ID_facteur_txt = new Guna.UI.WinForms.GunaTextBox();
            this.prénom_txt = new Guna.UI.WinForms.GunaComboBox();
            this.nom_txt = new Guna.UI.WinForms.GunaComboBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 78;
            this.label6.Text = ": الاسم  ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(652, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 77;
            this.label10.Text = ": النسب";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Location = new System.Drawing.Point(12, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(729, 237);
            this.dataGridView1.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 74);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 103;
            this.label2.Text = ": الرقم التسلسلي للفاتورة  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(219, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 79;
            this.label1.Text = "**";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.PaleTurquoise;
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton2.Image")));
            this.gunaButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton2.Location = new System.Drawing.Point(618, 179);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.PaleGreen;
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 15;
            this.gunaButton2.Size = new System.Drawing.Size(74, 33);
            this.gunaButton2.TabIndex = 107;
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // ID_facteur_txt
            // 
            this.ID_facteur_txt.BackColor = System.Drawing.Color.Transparent;
            this.ID_facteur_txt.BaseColor = System.Drawing.Color.White;
            this.ID_facteur_txt.BorderColor = System.Drawing.Color.Silver;
            this.ID_facteur_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ID_facteur_txt.FocusedBaseColor = System.Drawing.Color.White;
            this.ID_facteur_txt.FocusedBorderColor = System.Drawing.Color.PaleGreen;
            this.ID_facteur_txt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.ID_facteur_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ID_facteur_txt.Location = new System.Drawing.Point(262, 67);
            this.ID_facteur_txt.Name = "ID_facteur_txt";
            this.ID_facteur_txt.PasswordChar = '\0';
            this.ID_facteur_txt.Radius = 10;
            this.ID_facteur_txt.SelectedText = "";
            this.ID_facteur_txt.Size = new System.Drawing.Size(124, 30);
            this.ID_facteur_txt.TabIndex = 114;
            this.ID_facteur_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ID_facteur_txt.TextChanged += new System.EventHandler(this.ID_facteur_txt_TextChanged);
            // 
            // prénom_txt
            // 
            this.prénom_txt.BackColor = System.Drawing.Color.Transparent;
            this.prénom_txt.BaseColor = System.Drawing.Color.White;
            this.prénom_txt.BorderColor = System.Drawing.Color.Silver;
            this.prénom_txt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.prénom_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prénom_txt.FocusedColor = System.Drawing.Color.Empty;
            this.prénom_txt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.prénom_txt.ForeColor = System.Drawing.Color.Black;
            this.prénom_txt.Location = new System.Drawing.Point(101, 125);
            this.prénom_txt.Name = "prénom_txt";
            this.prénom_txt.OnHoverItemBaseColor = System.Drawing.Color.PaleGreen;
            this.prénom_txt.OnHoverItemForeColor = System.Drawing.Color.White;
            this.prénom_txt.Radius = 10;
            this.prénom_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.prénom_txt.Size = new System.Drawing.Size(124, 26);
            this.prénom_txt.TabIndex = 118;
            this.prénom_txt.SelectedIndexChanged += new System.EventHandler(this.prénom_txt_SelectedIndexChanged);
            // 
            // nom_txt
            // 
            this.nom_txt.BackColor = System.Drawing.Color.Transparent;
            this.nom_txt.BaseColor = System.Drawing.Color.White;
            this.nom_txt.BorderColor = System.Drawing.Color.Silver;
            this.nom_txt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.nom_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nom_txt.FocusedColor = System.Drawing.Color.Empty;
            this.nom_txt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nom_txt.ForeColor = System.Drawing.Color.Black;
            this.nom_txt.Location = new System.Drawing.Point(471, 125);
            this.nom_txt.Name = "nom_txt";
            this.nom_txt.OnHoverItemBaseColor = System.Drawing.Color.PaleGreen;
            this.nom_txt.OnHoverItemForeColor = System.Drawing.Color.White;
            this.nom_txt.Radius = 10;
            this.nom_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nom_txt.Size = new System.Drawing.Size(124, 26);
            this.nom_txt.TabIndex = 118;
            this.nom_txt.SelectedIndexChanged += new System.EventHandler(this.nom_txt_SelectedIndexChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // R_facteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(755, 499);
            this.Controls.Add(this.nom_txt);
            this.Controls.Add(this.prénom_txt);
            this.Controls.Add(this.ID_facteur_txt);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "R_facteur";
            this.Text = "R_facteur";
            this.Load += new System.EventHandler(this.R_facteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaTextBox ID_facteur_txt;
        private Guna.UI.WinForms.GunaComboBox prénom_txt;
        private Guna.UI.WinForms.GunaComboBox nom_txt;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument2;
    }
}