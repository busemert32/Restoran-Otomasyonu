namespace Restoran
{
    partial class GİRİS_EKRANI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GİRİS_EKRANI));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            cb_Kullanici = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btn_giris = new Button();
            btn_cikis = new Button();
            txt_sifre = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 201);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(69, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // cb_Kullanici
            // 
            cb_Kullanici.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Kullanici.FormattingEnabled = true;
            cb_Kullanici.Location = new Point(45, 257);
            cb_Kullanici.Name = "cb_Kullanici";
            cb_Kullanici.Size = new Size(232, 23);
            cb_Kullanici.TabIndex = 1;
            cb_Kullanici.SelectedIndexChanged += cb_Kullanici_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(46, 229);
            label1.Name = "label1";
            label1.Size = new Size(95, 21);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(46, 289);
            label2.Name = "label2";
            label2.Size = new Size(42, 21);
            label2.TabIndex = 4;
            label2.Text = "Şifre";
            // 
            // btn_giris
            // 
            btn_giris.BackColor = Color.IndianRed;
            btn_giris.Location = new Point(45, 359);
            btn_giris.Name = "btn_giris";
            btn_giris.Size = new Size(93, 45);
            btn_giris.TabIndex = 7;
            btn_giris.Text = "Giriş";
            btn_giris.UseVisualStyleBackColor = false;
            btn_giris.Click += btn_giris_Click;
            // 
            // btn_cikis
            // 
            btn_cikis.BackColor = Color.IndianRed;
            btn_cikis.Location = new Point(184, 359);
            btn_cikis.Name = "btn_cikis";
            btn_cikis.Size = new Size(93, 45);
            btn_cikis.TabIndex = 8;
            btn_cikis.Text = "Çıkış";
            btn_cikis.UseVisualStyleBackColor = false;
            btn_cikis.Click += btn_cikis_Click;
            // 
            // txt_sifre
            // 
            txt_sifre.Location = new Point(45, 313);
            txt_sifre.Name = "txt_sifre";
            txt_sifre.PasswordChar = '*';
            txt_sifre.Size = new Size(232, 23);
            txt_sifre.TabIndex = 9;
            // 
            // GİRİS_EKRANI
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Control;
            ClientSize = new Size(320, 425);
            Controls.Add(txt_sifre);
            Controls.Add(btn_cikis);
            Controls.Add(btn_giris);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cb_Kullanici);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "GİRİS_EKRANI";
            Text = "GİRİS_EKRANI";
            Load += GİRİS_EKRANI_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private ComboBox cb_Kullanici;
        private Label label1;
        private Label label2;
        private Button btn_giris;
        private Button btn_cikis;
        private TextBox txt_sifre;
    }
}