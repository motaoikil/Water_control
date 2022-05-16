
namespace WindowsFormsApp1
{
    partial class parametre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(parametre));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nouveau = new Guna.UI.WinForms.GunaTextBox();
            this.nouveau2 = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.auncien_ = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.prix_mai = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.prix_mettre = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gunaButton4 = new Guna.UI.WinForms.GunaButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nouveau);
            this.groupBox1.Controls.Add(this.nouveau2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.auncien_);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(92, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(533, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تغيير كلمة السر";
            // 
            // nouveau
            // 
            this.nouveau.BackColor = System.Drawing.Color.Transparent;
            this.nouveau.BaseColor = System.Drawing.Color.White;
            this.nouveau.BorderColor = System.Drawing.Color.Silver;
            this.nouveau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nouveau.FocusedBaseColor = System.Drawing.Color.White;
            this.nouveau.FocusedBorderColor = System.Drawing.Color.PaleGreen;
            this.nouveau.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.nouveau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nouveau.Location = new System.Drawing.Point(299, 49);
            this.nouveau.Name = "nouveau";
            this.nouveau.PasswordChar = '●';
            this.nouveau.Radius = 10;
            this.nouveau.SelectedText = "";
            this.nouveau.Size = new System.Drawing.Size(124, 30);
            this.nouveau.TabIndex = 112;
            this.nouveau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nouveau.UseSystemPasswordChar = true;
            this.nouveau.TextChanged += new System.EventHandler(this.nouveau_TextChanged);
            // 
            // nouveau2
            // 
            this.nouveau2.BackColor = System.Drawing.Color.Transparent;
            this.nouveau2.BaseColor = System.Drawing.Color.White;
            this.nouveau2.BorderColor = System.Drawing.Color.Silver;
            this.nouveau2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nouveau2.FocusedBaseColor = System.Drawing.Color.White;
            this.nouveau2.FocusedBorderColor = System.Drawing.Color.PaleGreen;
            this.nouveau2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.nouveau2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nouveau2.Location = new System.Drawing.Point(22, 49);
            this.nouveau2.Name = "nouveau2";
            this.nouveau2.PasswordChar = '●';
            this.nouveau2.Radius = 10;
            this.nouveau2.SelectedText = "";
            this.nouveau2.Size = new System.Drawing.Size(124, 30);
            this.nouveau2.TabIndex = 112;
            this.nouveau2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nouveau2.UseSystemPasswordChar = true;
            this.nouveau2.TextChanged += new System.EventHandler(this.nouveau2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 22);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 0;
            this.label2.Tag = "";
            this.label2.Text = ": كلمة السر القديمة";
            // 
            // auncien_
            // 
            this.auncien_.BackColor = System.Drawing.Color.Transparent;
            this.auncien_.BaseColor = System.Drawing.Color.White;
            this.auncien_.BorderColor = System.Drawing.Color.Silver;
            this.auncien_.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.auncien_.FocusedBaseColor = System.Drawing.Color.White;
            this.auncien_.FocusedBorderColor = System.Drawing.Color.PaleGreen;
            this.auncien_.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.auncien_.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.auncien_.Location = new System.Drawing.Point(178, 12);
            this.auncien_.Name = "auncien_";
            this.auncien_.PasswordChar = '●';
            this.auncien_.Radius = 10;
            this.auncien_.SelectedText = "";
            this.auncien_.Size = new System.Drawing.Size(124, 30);
            this.auncien_.TabIndex = 112;
            this.auncien_.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.auncien_.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 58);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(147, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = ": اعادة كتابة كلمة السر الجديدة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 58);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = ": كلمة السر الجديدة";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.prix_mai);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.prix_mettre);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(92, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(533, 57);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اعدادات الفاتورة";
            // 
            // prix_mai
            // 
            this.prix_mai.BackColor = System.Drawing.Color.Transparent;
            this.prix_mai.BaseColor = System.Drawing.Color.White;
            this.prix_mai.BorderColor = System.Drawing.Color.Silver;
            this.prix_mai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prix_mai.FocusedBaseColor = System.Drawing.Color.White;
            this.prix_mai.FocusedBorderColor = System.Drawing.Color.PaleGreen;
            this.prix_mai.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.prix_mai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.prix_mai.Location = new System.Drawing.Point(53, 14);
            this.prix_mai.Name = "prix_mai";
            this.prix_mai.PasswordChar = '\0';
            this.prix_mai.Radius = 10;
            this.prix_mai.SelectedText = "";
            this.prix_mai.Size = new System.Drawing.Size(124, 30);
            this.prix_mai.TabIndex = 112;
            this.prix_mai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(24, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 20);
            this.label4.TabIndex = 110;
            this.label4.Text = "**";
            // 
            // prix_mettre
            // 
            this.prix_mettre.BackColor = System.Drawing.Color.Transparent;
            this.prix_mettre.BaseColor = System.Drawing.Color.White;
            this.prix_mettre.BorderColor = System.Drawing.Color.Silver;
            this.prix_mettre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prix_mettre.FocusedBaseColor = System.Drawing.Color.White;
            this.prix_mettre.FocusedBorderColor = System.Drawing.Color.PaleGreen;
            this.prix_mettre.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.prix_mettre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.prix_mettre.Location = new System.Drawing.Point(311, 14);
            this.prix_mettre.Name = "prix_mettre";
            this.prix_mettre.PasswordChar = '\0';
            this.prix_mettre.Radius = 10;
            this.prix_mettre.SelectedText = "";
            this.prix_mettre.Size = new System.Drawing.Size(124, 30);
            this.prix_mettre.TabIndex = 112;
            this.prix_mettre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(276, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 20);
            this.label7.TabIndex = 75;
            this.label7.Text = "**";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(181, 23);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 108;
            this.label8.Text = ": واجب الصيانة ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(442, 23);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 106;
            this.label12.Text = ": ثمن المتر الواحد ";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.gunaButton4.Location = new System.Drawing.Point(299, 242);
            this.gunaButton4.Name = "gunaButton4";
            this.gunaButton4.OnHoverBaseColor = System.Drawing.Color.PaleGreen;
            this.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton4.OnHoverImage = null;
            this.gunaButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton4.Radius = 15;
            this.gunaButton4.Size = new System.Drawing.Size(130, 31);
            this.gunaButton4.TabIndex = 109;
            this.gunaButton4.Text = "حفظ";
            this.gunaButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton4.Click += new System.EventHandler(this.button1_Click);
            // 
            // parametre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(755, 499);
            this.Controls.Add(this.gunaButton4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "parametre";
            this.Text = "parametre";
            this.Load += new System.EventHandler(this.parametre_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaButton gunaButton4;
        private Guna.UI.WinForms.GunaTextBox nouveau;
        private Guna.UI.WinForms.GunaTextBox nouveau2;
        private Guna.UI.WinForms.GunaTextBox auncien_;
        private Guna.UI.WinForms.GunaTextBox prix_mai;
        private Guna.UI.WinForms.GunaTextBox prix_mettre;
    }
}