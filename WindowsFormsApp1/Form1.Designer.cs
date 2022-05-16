
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Ajouter_timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ID_txt = new Guna.UI.WinForms.GunaTextBox();
            this.prenom_txt = new Guna.UI.WinForms.GunaTextBox();
            this.nom_txt = new Guna.UI.WinForms.GunaTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.id_co_ = new Guna.UI.WinForms.GunaTextBox();
            this.Nb_actuel = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton5 = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(233, 61);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = ": النسب";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 61);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = ": الاسم  ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleGreen;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(32, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(700, 258);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 16);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = ": الرقم التسلسلي للمشترك  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(375, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "**";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(48, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 20);
            this.label7.TabIndex = 65;
            this.label7.Text = "**";
            // 
            // Ajouter_timer
            // 
            this.Ajouter_timer.Interval = 500;
            this.Ajouter_timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ID_txt);
            this.groupBox1.Controls.Add(this.prenom_txt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nom_txt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(59, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(653, 89);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المشترك";
            // 
            // ID_txt
            // 
            this.ID_txt.BackColor = System.Drawing.Color.Transparent;
            this.ID_txt.BaseColor = System.Drawing.Color.White;
            this.ID_txt.BorderColor = System.Drawing.Color.Silver;
            this.ID_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ID_txt.Enabled = false;
            this.ID_txt.FocusedBaseColor = System.Drawing.Color.White;
            this.ID_txt.FocusedBorderColor = System.Drawing.Color.PaleGreen;
            this.ID_txt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.ID_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ID_txt.Location = new System.Drawing.Point(204, 8);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.PasswordChar = '\0';
            this.ID_txt.Radius = 10;
            this.ID_txt.SelectedText = "";
            this.ID_txt.Size = new System.Drawing.Size(124, 30);
            this.ID_txt.TabIndex = 107;
            this.ID_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prenom_txt
            // 
            this.prenom_txt.BackColor = System.Drawing.Color.Transparent;
            this.prenom_txt.BaseColor = System.Drawing.Color.White;
            this.prenom_txt.BorderColor = System.Drawing.Color.Silver;
            this.prenom_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prenom_txt.FocusedBaseColor = System.Drawing.Color.White;
            this.prenom_txt.FocusedBorderColor = System.Drawing.Color.PaleGreen;
            this.prenom_txt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.prenom_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.prenom_txt.Location = new System.Drawing.Point(418, 54);
            this.prenom_txt.Name = "prenom_txt";
            this.prenom_txt.PasswordChar = '\0';
            this.prenom_txt.Radius = 10;
            this.prenom_txt.SelectedText = "";
            this.prenom_txt.Size = new System.Drawing.Size(124, 30);
            this.prenom_txt.TabIndex = 107;
            this.prenom_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nom_txt
            // 
            this.nom_txt.BackColor = System.Drawing.Color.Transparent;
            this.nom_txt.BaseColor = System.Drawing.Color.White;
            this.nom_txt.BorderColor = System.Drawing.Color.Silver;
            this.nom_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nom_txt.FocusedBaseColor = System.Drawing.Color.White;
            this.nom_txt.FocusedBorderColor = System.Drawing.Color.PaleGreen;
            this.nom_txt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.nom_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nom_txt.Location = new System.Drawing.Point(83, 53);
            this.nom_txt.Name = "nom_txt";
            this.nom_txt.PasswordChar = '\0';
            this.nom_txt.Radius = 10;
            this.nom_txt.SelectedText = "";
            this.nom_txt.Size = new System.Drawing.Size(124, 30);
            this.nom_txt.TabIndex = 107;
            this.nom_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.id_co_);
            this.groupBox2.Controls.Add(this.Nb_actuel);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(60, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(652, 79);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العداد";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.BackColor = System.Drawing.Color.Transparent;
            this.dateTimePicker1.BaseColor = System.Drawing.Color.White;
            this.dateTimePicker1.BorderColor = System.Drawing.Color.Silver;
            this.dateTimePicker1.CustomFormat = null;
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.FocusedColor = System.Drawing.Color.PaleGreen;
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePicker1.ForeColor = System.Drawing.Color.Black;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(71, 14);
            this.dateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.OnHoverBaseColor = System.Drawing.Color.White;
            this.dateTimePicker1.OnHoverBorderColor = System.Drawing.Color.PaleGreen;
            this.dateTimePicker1.OnHoverForeColor = System.Drawing.Color.Black;
            this.dateTimePicker1.OnPressedColor = System.Drawing.Color.Black;
            this.dateTimePicker1.Radius = 10;
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 30);
            this.dateTimePicker1.TabIndex = 110;
            this.dateTimePicker1.Text = "01/04/2021";
            this.dateTimePicker1.Value = new System.DateTime(2021, 4, 1, 10, 46, 24, 615);
            // 
            // id_co_
            // 
            this.id_co_.BackColor = System.Drawing.Color.Transparent;
            this.id_co_.BaseColor = System.Drawing.Color.White;
            this.id_co_.BorderColor = System.Drawing.Color.Silver;
            this.id_co_.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id_co_.FocusedBaseColor = System.Drawing.Color.White;
            this.id_co_.FocusedBorderColor = System.Drawing.Color.PaleGreen;
            this.id_co_.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.id_co_.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.id_co_.Location = new System.Drawing.Point(398, 19);
            this.id_co_.Name = "id_co_";
            this.id_co_.PasswordChar = '\0';
            this.id_co_.Radius = 10;
            this.id_co_.SelectedText = "";
            this.id_co_.Size = new System.Drawing.Size(107, 30);
            this.id_co_.TabIndex = 107;
            this.id_co_.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Nb_actuel
            // 
            this.Nb_actuel.BackColor = System.Drawing.Color.Transparent;
            this.Nb_actuel.BaseColor = System.Drawing.Color.White;
            this.Nb_actuel.BorderColor = System.Drawing.Color.Silver;
            this.Nb_actuel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Nb_actuel.FocusedBaseColor = System.Drawing.Color.White;
            this.Nb_actuel.FocusedBorderColor = System.Drawing.Color.PaleGreen;
            this.Nb_actuel.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.Nb_actuel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Nb_actuel.Location = new System.Drawing.Point(216, 49);
            this.Nb_actuel.Name = "Nb_actuel";
            this.Nb_actuel.PasswordChar = '\0';
            this.Nb_actuel.Radius = 10;
            this.Nb_actuel.SelectedText = "";
            this.Nb_actuel.Size = new System.Drawing.Size(124, 30);
            this.Nb_actuel.TabIndex = 107;
            this.Nb_actuel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(187, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 20);
            this.label8.TabIndex = 79;
            this.label8.Text = "**";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(372, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 20);
            this.label5.TabIndex = 80;
            this.label5.Text = "**";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(347, 58);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 77;
            this.label9.Text = ": عدد الدورات";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 23);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = ": الرقم التسلسلي للعداد  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 23);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = ": التاريخ تسليم العداد";
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.PaleTurquoise;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaButton1.Image = global::WindowsFormsApp1.Properties.Resources._12;
            this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton1.Location = new System.Drawing.Point(588, 192);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.PaleGreen;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 15;
            this.gunaButton1.Size = new System.Drawing.Size(124, 33);
            this.gunaButton1.TabIndex = 106;
            this.gunaButton1.Text = "مسح";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton1.Click += new System.EventHandler(this.button1_Click);
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
            this.gunaButton2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaButton2.Image = global::WindowsFormsApp1.Properties.Resources.add_32px;
            this.gunaButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton2.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton2.Location = new System.Drawing.Point(458, 192);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.PaleGreen;
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 15;
            this.gunaButton2.Size = new System.Drawing.Size(124, 33);
            this.gunaButton2.TabIndex = 106;
            this.gunaButton2.Text = "إضافة";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton2.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BaseColor = System.Drawing.Color.PaleTurquoise;
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaButton3.Image = global::WindowsFormsApp1.Properties.Resources._9;
            this.gunaButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton3.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton3.Location = new System.Drawing.Point(327, 192);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.PaleGreen;
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Radius = 15;
            this.gunaButton3.Size = new System.Drawing.Size(124, 33);
            this.gunaButton3.TabIndex = 106;
            this.gunaButton3.Text = "تعديل";
            this.gunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton3.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // gunaButton4
            // 
            this.gunaButton4.AnimationHoverSpeed = 0.07F;
            this.gunaButton4.AnimationSpeed = 0.03F;
            this.gunaButton4.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton4.BaseColor = System.Drawing.Color.PaleTurquoise;
            this.gunaButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton4.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaButton4.Image = global::WindowsFormsApp1.Properties.Resources._42;
            this.gunaButton4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton4.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton4.Location = new System.Drawing.Point(197, 192);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.PaleGreen;
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton4.Radius = 15;
            this.gunaButton4.Size = new System.Drawing.Size(124, 33);
            this.gunaButton4.TabIndex = 106;
            this.gunaButton4.Text = "حذف";
            this.gunaButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton4.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // gunaButton5
            // 
            this.gunaButton5.AnimationHoverSpeed = 0.07F;
            this.gunaButton5.AnimationSpeed = 0.03F;
            this.gunaButton5.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton5.BaseColor = System.Drawing.Color.PaleTurquoise;
            this.gunaButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton5.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaButton5.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton5.Image")));
            this.gunaButton5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton5.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton5.Location = new System.Drawing.Point(51, 192);
            this.gunaButton5.Name = "gunaButton5";
            this.gunaButton5.OnHoverBaseColor = System.Drawing.Color.PaleGreen;
            this.gunaButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton5.OnHoverImage = null;
            this.gunaButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton5.Radius = 15;
            this.gunaButton5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gunaButton5.Size = new System.Drawing.Size(140, 33);
            this.gunaButton5.TabIndex = 106;
            this.gunaButton5.Text = "إضافة عداد آخر";
            this.gunaButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton5.Click += new System.EventHandler(this.Ajouter_n_conteur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(755, 499);
            this.Controls.Add(this.gunaButton3);
            this.Controls.Add(this.gunaButton5);
            this.Controls.Add(this.gunaButton4);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer Ajouter_timer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private Guna.UI.WinForms.GunaButton gunaButton5;
        private Guna.UI.WinForms.GunaTextBox ID_txt;
        private Guna.UI.WinForms.GunaTextBox prenom_txt;
        private Guna.UI.WinForms.GunaTextBox nom_txt;
        private Guna.UI.WinForms.GunaTextBox id_co_;
        private Guna.UI.WinForms.GunaTextBox Nb_actuel;
        private Guna.UI.WinForms.GunaDateTimePicker dateTimePicker1;
    }
}

