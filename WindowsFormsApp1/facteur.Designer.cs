
namespace WindowsFormsApp1
{
    partial class facteur
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(facteur));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.prenom_txt = new Guna.UI.WinForms.GunaComboBox();
            this.nom_txt = new Guna.UI.WinForms.GunaComboBox();
            this.id_client = new Guna.UI.WinForms.GunaComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Id_con = new Guna.UI.WinForms.GunaComboBox();
            this.nouveau_ = new Guna.UI.WinForms.GunaTextBox();
            this.aucien_ = new Guna.UI.WinForms.GunaTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.prix_mai = new Guna.UI.WinForms.GunaTextBox();
            this.ID_facteur_txt = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.prix_sans = new Guna.UI.WinForms.GunaTextBox();
            this.prix_mettre = new Guna.UI.WinForms.GunaTextBox();
            this.prix_avec = new Guna.UI.WinForms.GunaTextBox();
            this.date_ = new Guna.UI.WinForms.GunaDateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaButton5 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.date1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.date2 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 26);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 89;
            this.label3.Text = ": الرقم التسلسلي للمشترك  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 16);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 87;
            this.label1.Text = ": الرقم التسلسلي للعداد  ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(0, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(755, 253);
            this.dataGridView1.TabIndex = 79;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(306, 48);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 78;
            this.label11.Text = ": العدد القديم";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 48);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 77;
            this.label7.Text = ": العدد الجديد";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(303, 54);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 72;
            this.label10.Text = ": النسب";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 54);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 71;
            this.label6.Text = ": الاسم  ";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.prenom_txt);
            this.groupBox2.Controls.Add(this.nom_txt);
            this.groupBox2.Controls.Add(this.id_client);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(381, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(376, 75);
            this.groupBox2.TabIndex = 97;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المشترك";
            // 
            // prenom_txt
            // 
            this.prenom_txt.BackColor = System.Drawing.Color.Transparent;
            this.prenom_txt.BaseColor = System.Drawing.Color.White;
            this.prenom_txt.BorderColor = System.Drawing.Color.Silver;
            this.prenom_txt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.prenom_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prenom_txt.FocusedColor = System.Drawing.Color.Empty;
            this.prenom_txt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.prenom_txt.ForeColor = System.Drawing.Color.Black;
            this.prenom_txt.Location = new System.Drawing.Point(0, 48);
            this.prenom_txt.Name = "prenom_txt";
            this.prenom_txt.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.prenom_txt.OnHoverItemForeColor = System.Drawing.Color.White;
            this.prenom_txt.Radius = 10;
            this.prenom_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.prenom_txt.Size = new System.Drawing.Size(124, 26);
            this.prenom_txt.TabIndex = 115;
            this.prenom_txt.SelectedIndexChanged += new System.EventHandler(this.prenom_txt_SelectedIndexChanged);
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
            this.nom_txt.Location = new System.Drawing.Point(173, 50);
            this.nom_txt.Name = "nom_txt";
            this.nom_txt.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.nom_txt.OnHoverItemForeColor = System.Drawing.Color.White;
            this.nom_txt.Radius = 10;
            this.nom_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nom_txt.Size = new System.Drawing.Size(124, 26);
            this.nom_txt.TabIndex = 116;
            this.nom_txt.SelectedIndexChanged += new System.EventHandler(this.nom_txt_SelectedIndexChanged);
            // 
            // id_client
            // 
            this.id_client.BackColor = System.Drawing.Color.Transparent;
            this.id_client.BaseColor = System.Drawing.Color.White;
            this.id_client.BorderColor = System.Drawing.Color.Silver;
            this.id_client.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.id_client.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_client.FocusedColor = System.Drawing.Color.Empty;
            this.id_client.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.id_client.ForeColor = System.Drawing.Color.Black;
            this.id_client.Location = new System.Drawing.Point(92, 19);
            this.id_client.Name = "id_client";
            this.id_client.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.id_client.OnHoverItemForeColor = System.Drawing.Color.White;
            this.id_client.Radius = 10;
            this.id_client.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.id_client.Size = new System.Drawing.Size(124, 26);
            this.id_client.TabIndex = 117;
            this.id_client.SelectedIndexChanged += new System.EventHandler(this.id_client_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(156, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 20);
            this.label15.TabIndex = 100;
            this.label15.Text = "**";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(63, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 20);
            this.label14.TabIndex = 100;
            this.label14.Text = "**";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Id_con);
            this.groupBox3.Controls.Add(this.nouveau_);
            this.groupBox3.Controls.Add(this.aucien_);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(3, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(378, 75);
            this.groupBox3.TabIndex = 98;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "العداد";
            // 
            // Id_con
            // 
            this.Id_con.BackColor = System.Drawing.Color.Transparent;
            this.Id_con.BaseColor = System.Drawing.Color.White;
            this.Id_con.BorderColor = System.Drawing.Color.Silver;
            this.Id_con.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Id_con.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Id_con.FocusedColor = System.Drawing.Color.Empty;
            this.Id_con.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Id_con.ForeColor = System.Drawing.Color.Black;
            this.Id_con.Location = new System.Drawing.Point(90, 9);
            this.Id_con.Name = "Id_con";
            this.Id_con.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Id_con.OnHoverItemForeColor = System.Drawing.Color.White;
            this.Id_con.Radius = 10;
            this.Id_con.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Id_con.Size = new System.Drawing.Size(124, 26);
            this.Id_con.TabIndex = 114;
            this.Id_con.SelectedIndexChanged += new System.EventHandler(this.Id_con_SelectedIndexChanged);
            // 
            // nouveau_
            // 
            this.nouveau_.BackColor = System.Drawing.Color.Transparent;
            this.nouveau_.BaseColor = System.Drawing.Color.White;
            this.nouveau_.BorderColor = System.Drawing.Color.Silver;
            this.nouveau_.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nouveau_.FocusedBaseColor = System.Drawing.Color.White;
            this.nouveau_.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.nouveau_.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.nouveau_.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nouveau_.Location = new System.Drawing.Point(18, 40);
            this.nouveau_.Name = "nouveau_";
            this.nouveau_.PasswordChar = '\0';
            this.nouveau_.Radius = 10;
            this.nouveau_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nouveau_.SelectedText = "";
            this.nouveau_.Size = new System.Drawing.Size(97, 26);
            this.nouveau_.TabIndex = 109;
            this.nouveau_.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nouveau_.TextChanged += new System.EventHandler(this.nouveau__TextChanged);
            // 
            // aucien_
            // 
            this.aucien_.BackColor = System.Drawing.Color.Transparent;
            this.aucien_.BaseColor = System.Drawing.Color.White;
            this.aucien_.BorderColor = System.Drawing.Color.Silver;
            this.aucien_.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.aucien_.Enabled = false;
            this.aucien_.FocusedBaseColor = System.Drawing.Color.White;
            this.aucien_.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.aucien_.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.aucien_.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.aucien_.Location = new System.Drawing.Point(205, 41);
            this.aucien_.Name = "aucien_";
            this.aucien_.PasswordChar = '\0';
            this.aucien_.Radius = 10;
            this.aucien_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.aucien_.SelectedText = "";
            this.aucien_.Size = new System.Drawing.Size(99, 26);
            this.aucien_.TabIndex = 109;
            this.aucien_.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(-4, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 20);
            this.label16.TabIndex = 100;
            this.label16.Text = "**";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(357, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 20);
            this.label17.TabIndex = 100;
            this.label17.Text = "**";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(61, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 20);
            this.label18.TabIndex = 100;
            this.label18.Text = "**";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(184, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 20);
            this.label13.TabIndex = 100;
            this.label13.Text = "**";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton1.Location = new System.Drawing.Point(150, 209);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.PaleGreen;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 15;
            this.gunaButton1.Size = new System.Drawing.Size(124, 33);
            this.gunaButton1.TabIndex = 105;
            this.gunaButton1.Text = "طباعة";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaButton2
            // 
            this.gunaButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.PaleTurquoise;
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton2.Image")));
            this.gunaButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton2.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton2.Location = new System.Drawing.Point(448, 209);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.PaleGreen;
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 15;
            this.gunaButton2.Size = new System.Drawing.Size(124, 33);
            this.gunaButton2.TabIndex = 107;
            this.gunaButton2.Text = "إضافة";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton2.Click += new System.EventHandler(this.button5_Click);
            // 
            // gunaButton3
            // 
            this.gunaButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BaseColor = System.Drawing.Color.PaleTurquoise;
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton3.Image")));
            this.gunaButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton3.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton3.Location = new System.Drawing.Point(299, 209);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.PaleGreen;
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Radius = 15;
            this.gunaButton3.Size = new System.Drawing.Size(124, 33);
            this.gunaButton3.TabIndex = 108;
            this.gunaButton3.Text = "مسح";
            this.gunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton3.Click += new System.EventHandler(this.button2_Click);
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
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 17);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 101;
            this.label2.Text = ": الرقم التسلسلي للفاتورة  ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(162, 79);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(136, 13);
            this.label9.TabIndex = 98;
            this.label9.Text = ": مبلغ الفاتورة+واجب الصيانة";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(497, 46);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 102;
            this.label8.Text = ": واجب الصيانة ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(184, 48);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 102;
            this.label12.Text = ": ثمن المتر الواحد ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 75);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 99;
            this.label4.Text = ": مبلغ الفاتورة";
            // 
            // prix_mai
            // 
            this.prix_mai.BackColor = System.Drawing.Color.Transparent;
            this.prix_mai.BaseColor = System.Drawing.Color.White;
            this.prix_mai.BorderColor = System.Drawing.Color.Silver;
            this.prix_mai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prix_mai.Enabled = false;
            this.prix_mai.FocusedBaseColor = System.Drawing.Color.White;
            this.prix_mai.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.prix_mai.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.prix_mai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.prix_mai.Location = new System.Drawing.Point(323, 41);
            this.prix_mai.Name = "prix_mai";
            this.prix_mai.PasswordChar = '\0';
            this.prix_mai.Radius = 10;
            this.prix_mai.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.prix_mai.SelectedText = "";
            this.prix_mai.Size = new System.Drawing.Size(124, 26);
            this.prix_mai.TabIndex = 109;
            this.prix_mai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ID_facteur_txt
            // 
            this.ID_facteur_txt.BackColor = System.Drawing.Color.Transparent;
            this.ID_facteur_txt.BaseColor = System.Drawing.Color.White;
            this.ID_facteur_txt.BorderColor = System.Drawing.Color.Silver;
            this.ID_facteur_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ID_facteur_txt.Enabled = false;
            this.ID_facteur_txt.FocusedBaseColor = System.Drawing.Color.White;
            this.ID_facteur_txt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ID_facteur_txt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.ID_facteur_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ID_facteur_txt.Location = new System.Drawing.Point(323, 12);
            this.ID_facteur_txt.Name = "ID_facteur_txt";
            this.ID_facteur_txt.PasswordChar = '\0';
            this.ID_facteur_txt.Radius = 10;
            this.ID_facteur_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ID_facteur_txt.SelectedText = "";
            this.ID_facteur_txt.Size = new System.Drawing.Size(124, 26);
            this.ID_facteur_txt.TabIndex = 109;
            this.ID_facteur_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 17);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 97;
            this.label5.Text = ": التاريخ الفاتورة";
            // 
            // prix_sans
            // 
            this.prix_sans.BackColor = System.Drawing.Color.Transparent;
            this.prix_sans.BaseColor = System.Drawing.Color.White;
            this.prix_sans.BorderColor = System.Drawing.Color.Silver;
            this.prix_sans.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prix_sans.Enabled = false;
            this.prix_sans.FocusedBaseColor = System.Drawing.Color.White;
            this.prix_sans.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.prix_sans.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.prix_sans.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.prix_sans.Location = new System.Drawing.Point(323, 73);
            this.prix_sans.Name = "prix_sans";
            this.prix_sans.PasswordChar = '\0';
            this.prix_sans.Radius = 10;
            this.prix_sans.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.prix_sans.SelectedText = "";
            this.prix_sans.Size = new System.Drawing.Size(124, 26);
            this.prix_sans.TabIndex = 109;
            this.prix_sans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prix_mettre
            // 
            this.prix_mettre.BackColor = System.Drawing.Color.Transparent;
            this.prix_mettre.BaseColor = System.Drawing.Color.White;
            this.prix_mettre.BorderColor = System.Drawing.Color.Silver;
            this.prix_mettre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prix_mettre.Enabled = false;
            this.prix_mettre.FocusedBaseColor = System.Drawing.Color.White;
            this.prix_mettre.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.prix_mettre.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.prix_mettre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.prix_mettre.Location = new System.Drawing.Point(33, 42);
            this.prix_mettre.Name = "prix_mettre";
            this.prix_mettre.PasswordChar = '\0';
            this.prix_mettre.Radius = 10;
            this.prix_mettre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.prix_mettre.SelectedText = "";
            this.prix_mettre.Size = new System.Drawing.Size(124, 26);
            this.prix_mettre.TabIndex = 109;
            this.prix_mettre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prix_avec
            // 
            this.prix_avec.BackColor = System.Drawing.Color.Transparent;
            this.prix_avec.BaseColor = System.Drawing.Color.White;
            this.prix_avec.BorderColor = System.Drawing.Color.Silver;
            this.prix_avec.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prix_avec.Enabled = false;
            this.prix_avec.FocusedBaseColor = System.Drawing.Color.White;
            this.prix_avec.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.prix_avec.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.prix_avec.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.prix_avec.Location = new System.Drawing.Point(31, 73);
            this.prix_avec.Name = "prix_avec";
            this.prix_avec.PasswordChar = '\0';
            this.prix_avec.Radius = 10;
            this.prix_avec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.prix_avec.SelectedText = "";
            this.prix_avec.Size = new System.Drawing.Size(124, 26);
            this.prix_avec.TabIndex = 109;
            this.prix_avec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // date_
            // 
            this.date_.BackColor = System.Drawing.Color.Transparent;
            this.date_.BaseColor = System.Drawing.Color.White;
            this.date_.BorderColor = System.Drawing.Color.Silver;
            this.date_.CustomFormat = null;
            this.date_.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.date_.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.date_.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_.ForeColor = System.Drawing.Color.Black;
            this.date_.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_.Location = new System.Drawing.Point(34, 8);
            this.date_.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_.Name = "date_";
            this.date_.OnHoverBaseColor = System.Drawing.Color.White;
            this.date_.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.date_.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.date_.OnPressedColor = System.Drawing.Color.Black;
            this.date_.Radius = 10;
            this.date_.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.date_.Size = new System.Drawing.Size(123, 30);
            this.date_.TabIndex = 109;
            this.date_.Text = "01/04/2021";
            this.date_.Value = new System.DateTime(2021, 4, 1, 10, 46, 24, 615);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.date_);
            this.groupBox4.Controls.Add(this.prix_avec);
            this.groupBox4.Controls.Add(this.prix_mettre);
            this.groupBox4.Controls.Add(this.prix_sans);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.ID_facteur_txt);
            this.groupBox4.Controls.Add(this.prix_mai);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(71, 101);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(633, 108);
            this.groupBox4.TabIndex = 98;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "الفاتورة";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.gunaButton5);
            this.panel1.Controls.Add(this.gunaButton4);
            this.panel1.Controls.Add(this.date1);
            this.panel1.Controls.Add(this.date2);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Location = new System.Drawing.Point(190, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 133);
            this.panel1.TabIndex = 110;
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
            this.gunaButton5.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaButton5.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton5.Image")));
            this.gunaButton5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton5.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton5.Location = new System.Drawing.Point(70, 69);
            this.gunaButton5.Name = "gunaButton5";
            this.gunaButton5.OnHoverBaseColor = System.Drawing.Color.PaleGreen;
            this.gunaButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton5.OnHoverImage = null;
            this.gunaButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton5.Radius = 15;
            this.gunaButton5.Size = new System.Drawing.Size(124, 33);
            this.gunaButton5.TabIndex = 123;
            this.gunaButton5.Text = "إلغاء";
            this.gunaButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton5.Click += new System.EventHandler(this.gunaButton5_Click);
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
            this.gunaButton4.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton4.Image")));
            this.gunaButton4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton4.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton4.Location = new System.Drawing.Point(242, 69);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.PaleGreen;
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton4.Radius = 15;
            this.gunaButton4.Size = new System.Drawing.Size(124, 33);
            this.gunaButton4.TabIndex = 123;
            this.gunaButton4.Text = "طباعة";
            this.gunaButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton4.Click += new System.EventHandler(this.gunaButton4_Click);
            // 
            // date1
            // 
            this.date1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date1.BackColor = System.Drawing.Color.Transparent;
            this.date1.BaseColor = System.Drawing.Color.White;
            this.date1.BorderColor = System.Drawing.Color.Silver;
            this.date1.CustomFormat = null;
            this.date1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.date1.FocusedColor = System.Drawing.Color.PaleGreen;
            this.date1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date1.ForeColor = System.Drawing.Color.Black;
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date1.Location = new System.Drawing.Point(247, 12);
            this.date1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date1.Name = "date1";
            this.date1.OnHoverBaseColor = System.Drawing.Color.White;
            this.date1.OnHoverBorderColor = System.Drawing.Color.PaleGreen;
            this.date1.OnHoverForeColor = System.Drawing.Color.Black;
            this.date1.OnPressedColor = System.Drawing.Color.Black;
            this.date1.Radius = 10;
            this.date1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.date1.Size = new System.Drawing.Size(123, 30);
            this.date1.TabIndex = 122;
            this.date1.Text = "01/04/2021";
            this.date1.Value = new System.DateTime(2021, 4, 1, 10, 46, 24, 615);
            // 
            // date2
            // 
            this.date2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date2.BackColor = System.Drawing.Color.Transparent;
            this.date2.BaseColor = System.Drawing.Color.White;
            this.date2.BorderColor = System.Drawing.Color.Silver;
            this.date2.CustomFormat = null;
            this.date2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.date2.FocusedColor = System.Drawing.Color.PaleGreen;
            this.date2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date2.ForeColor = System.Drawing.Color.Black;
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date2.Location = new System.Drawing.Point(59, 12);
            this.date2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date2.Name = "date2";
            this.date2.OnHoverBaseColor = System.Drawing.Color.White;
            this.date2.OnHoverBorderColor = System.Drawing.Color.PaleGreen;
            this.date2.OnHoverForeColor = System.Drawing.Color.Black;
            this.date2.OnPressedColor = System.Drawing.Color.Black;
            this.date2.Radius = 10;
            this.date2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.date2.Size = new System.Drawing.Size(123, 30);
            this.date2.TabIndex = 121;
            this.date2.Text = "01/04/2021";
            this.date2.Value = new System.DateTime(2021, 4, 1, 10, 46, 24, 615);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(188, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 13);
            this.label19.TabIndex = 119;
            this.label19.Text = ": إلى";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(376, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(25, 13);
            this.label20.TabIndex = 120;
            this.label20.Text = ": من";
            // 
            // facteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(755, 499);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.gunaButton3);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "facteur";
            this.Text = "facteur";
            this.Load += new System.EventHandler(this.facteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaTextBox nouveau_;
        private Guna.UI.WinForms.GunaTextBox aucien_;
        private Guna.UI.WinForms.GunaComboBox Id_con;
        private Guna.UI.WinForms.GunaComboBox prenom_txt;
        private Guna.UI.WinForms.GunaComboBox nom_txt;
        private Guna.UI.WinForms.GunaComboBox id_client;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox prix_mai;
        private Guna.UI.WinForms.GunaTextBox ID_facteur_txt;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox prix_sans;
        private Guna.UI.WinForms.GunaTextBox prix_mettre;
        private Guna.UI.WinForms.GunaTextBox prix_avec;
        private Guna.UI.WinForms.GunaDateTimePicker date_;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton gunaButton5;
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private Guna.UI.WinForms.GunaDateTimePicker date1;
        private Guna.UI.WinForms.GunaDateTimePicker date2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}