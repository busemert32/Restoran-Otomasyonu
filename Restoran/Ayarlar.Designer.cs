namespace Restoran
{
    partial class Ayarlar
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ayarlar));
            ımageList1 = new ImageList(components);
            lv_Personeller = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            groupBox1 = new GroupBox();
            txtPersonelID = new TextBox();
            btn_degis1 = new Button();
            cbPersonel = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            txtSifreYeniTekrar = new TextBox();
            txtSifreYeni = new TextBox();
            groupBox2 = new GroupBox();
            btnYeni = new Button();
            btnBilgiDegistir = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            txtAd = new TextBox();
            cbGorevi = new ComboBox();
            txtGorevId = new TextBox();
            txtSifreTekrar = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label12 = new Label();
            txtPersonelID2 = new TextBox();
            label13 = new Label();
            label14 = new Label();
            txtSifre = new TextBox();
            txtSoyad = new TextBox();
            groupBox3 = new GroupBox();
            btn_degis2 = new Button();
            label8 = new Label();
            label9 = new Label();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            groupBox4 = new GroupBox();
            lblBilgi = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "icons8-delete-user-male-100.png");
            ımageList1.Images.SetKeyName(1, "icons8-remove-user-group-man-man-100.png");
            ımageList1.Images.SetKeyName(2, "icons8-change-user-100.png");
            ımageList1.Images.SetKeyName(3, "icons8-checked-user-male-100.png");
            ımageList1.Images.SetKeyName(4, "icons8-add-user-100.png");
            ımageList1.Images.SetKeyName(5, "icons8-change-100.png");
            // 
            // lv_Personeller
            // 
            lv_Personeller.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lv_Personeller.FullRowSelect = true;
            lv_Personeller.Location = new Point(6, 22);
            lv_Personeller.Name = "lv_Personeller";
            lv_Personeller.Size = new Size(471, 142);
            lv_Personeller.TabIndex = 59;
            lv_Personeller.UseCompatibleStateImageBehavior = false;
            lv_Personeller.View = View.Details;
            lv_Personeller.SelectedIndexChanged += lv_Personeller_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "PersonelID";
            columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "PersonelGorevId";
            columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Görev";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Ad";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Soyad";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPersonelID);
            groupBox1.Controls.Add(btn_degis1);
            groupBox1.Controls.Add(cbPersonel);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtSifreYeniTekrar);
            groupBox1.Controls.Add(txtSifreYeni);
            groupBox1.Location = new Point(12, 194);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(267, 255);
            groupBox1.TabIndex = 60;
            groupBox1.TabStop = false;
            // 
            // txtPersonelID
            // 
            txtPersonelID.Location = new Point(239, 34);
            txtPersonelID.Name = "txtPersonelID";
            txtPersonelID.Size = new Size(22, 23);
            txtPersonelID.TabIndex = 81;
            // 
            // btn_degis1
            // 
            btn_degis1.BackColor = Color.IndianRed;
            btn_degis1.FlatAppearance.BorderColor = Color.IndianRed;
            btn_degis1.FlatStyle = FlatStyle.Popup;
            btn_degis1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_degis1.ImageAlign = ContentAlignment.MiddleLeft;
            btn_degis1.ImageKey = "icons8-change-100.png";
            btn_degis1.ImageList = ımageList1;
            btn_degis1.Location = new Point(112, 157);
            btn_degis1.Name = "btn_degis1";
            btn_degis1.Size = new Size(137, 63);
            btn_degis1.TabIndex = 66;
            btn_degis1.Text = "DEĞİŞTİR";
            btn_degis1.TextAlign = ContentAlignment.MiddleRight;
            btn_degis1.UseVisualStyleBackColor = false;
            btn_degis1.Click += btn_degis1_Click;
            // 
            // cbPersonel
            // 
            cbPersonel.FormattingEnabled = true;
            cbPersonel.Location = new Point(112, 34);
            cbPersonel.Name = "cbPersonel";
            cbPersonel.Size = new Size(121, 23);
            cbPersonel.TabIndex = 65;
            cbPersonel.SelectedIndexChanged += cbPersonel_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(18, 118);
            label10.Name = "label10";
            label10.Size = new Size(88, 21);
            label10.TabIndex = 64;
            label10.Text = "Şifre Tekrar";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(18, 80);
            label11.Name = "label11";
            label11.Size = new Size(75, 21);
            label11.TabIndex = 63;
            label11.Text = "Yeni Şifre";
            // 
            // txtSifreYeniTekrar
            // 
            txtSifreYeniTekrar.Location = new Point(112, 116);
            txtSifreYeniTekrar.Name = "txtSifreYeniTekrar";
            txtSifreYeniTekrar.Size = new Size(100, 23);
            txtSifreYeniTekrar.TabIndex = 62;
            // 
            // txtSifreYeni
            // 
            txtSifreYeni.Location = new Point(112, 78);
            txtSifreYeni.Name = "txtSifreYeni";
            txtSifreYeni.Size = new Size(100, 23);
            txtSifreYeni.TabIndex = 61;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnYeni);
            groupBox2.Controls.Add(btnBilgiDegistir);
            groupBox2.Controls.Add(btnSil);
            groupBox2.Controls.Add(btnEkle);
            groupBox2.Controls.Add(txtAd);
            groupBox2.Controls.Add(cbGorevi);
            groupBox2.Controls.Add(txtGorevId);
            groupBox2.Controls.Add(txtSifreTekrar);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtPersonelID2);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(txtSifre);
            groupBox2.Controls.Add(txtSoyad);
            groupBox2.Location = new Point(307, 106);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(305, 404);
            groupBox2.TabIndex = 61;
            groupBox2.TabStop = false;
            // 
            // btnYeni
            // 
            btnYeni.BackColor = Color.IndianRed;
            btnYeni.FlatAppearance.BorderColor = Color.IndianRed;
            btnYeni.FlatStyle = FlatStyle.Popup;
            btnYeni.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnYeni.ImageAlign = ContentAlignment.MiddleLeft;
            btnYeni.ImageKey = "icons8-add-user-100.png";
            btnYeni.ImageList = ımageList1;
            btnYeni.Location = new Point(12, 245);
            btnYeni.Name = "btnYeni";
            btnYeni.Size = new Size(137, 63);
            btnYeni.TabIndex = 81;
            btnYeni.Text = "EKLE";
            btnYeni.TextAlign = ContentAlignment.MiddleRight;
            btnYeni.UseVisualStyleBackColor = false;
            btnYeni.Click += btnYeni_Click;
            // 
            // btnBilgiDegistir
            // 
            btnBilgiDegistir.BackColor = Color.IndianRed;
            btnBilgiDegistir.FlatAppearance.BorderColor = Color.IndianRed;
            btnBilgiDegistir.FlatStyle = FlatStyle.Popup;
            btnBilgiDegistir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnBilgiDegistir.ImageAlign = ContentAlignment.MiddleLeft;
            btnBilgiDegistir.ImageKey = "icons8-change-user-100.png";
            btnBilgiDegistir.ImageList = ımageList1;
            btnBilgiDegistir.Location = new Point(155, 314);
            btnBilgiDegistir.Name = "btnBilgiDegistir";
            btnBilgiDegistir.Size = new Size(137, 63);
            btnBilgiDegistir.TabIndex = 80;
            btnBilgiDegistir.Text = "DEĞİŞTİR";
            btnBilgiDegistir.TextAlign = ContentAlignment.MiddleRight;
            btnBilgiDegistir.UseVisualStyleBackColor = false;
            btnBilgiDegistir.Click += btnBilgiDegistir_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.IndianRed;
            btnSil.FlatAppearance.BorderColor = Color.IndianRed;
            btnSil.FlatStyle = FlatStyle.Popup;
            btnSil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSil.ImageAlign = ContentAlignment.MiddleLeft;
            btnSil.ImageKey = "icons8-delete-user-male-100.png";
            btnSil.ImageList = ımageList1;
            btnSil.Location = new Point(12, 314);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(137, 63);
            btnSil.TabIndex = 79;
            btnSil.Text = "SİL";
            btnSil.TextAlign = ContentAlignment.MiddleRight;
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.IndianRed;
            btnEkle.FlatAppearance.BorderColor = Color.IndianRed;
            btnEkle.FlatStyle = FlatStyle.Popup;
            btnEkle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnEkle.ImageAlign = ContentAlignment.MiddleLeft;
            btnEkle.ImageKey = "icons8-checked-user-male-100.png";
            btnEkle.ImageList = ımageList1;
            btnEkle.Location = new Point(155, 245);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(137, 63);
            btnEkle.TabIndex = 78;
            btnEkle.Text = "KAYDET";
            btnEkle.TextAlign = ContentAlignment.MiddleRight;
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(109, 28);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(119, 23);
            txtAd.TabIndex = 76;
            // 
            // cbGorevi
            // 
            cbGorevi.FormattingEnabled = true;
            cbGorevi.Location = new Point(109, 193);
            cbGorevi.Name = "cbGorevi";
            cbGorevi.Size = new Size(119, 23);
            cbGorevi.TabIndex = 70;
            cbGorevi.SelectedIndexChanged += cbGorevi_SelectedIndexChanged;
            // 
            // txtGorevId
            // 
            txtGorevId.Location = new Point(234, 193);
            txtGorevId.Name = "txtGorevId";
            txtGorevId.Size = new Size(19, 23);
            txtGorevId.TabIndex = 75;
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Location = new Point(109, 151);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.Size = new Size(119, 23);
            txtSifreTekrar.TabIndex = 74;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(20, 193);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 73;
            label1.Text = "Görev";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(20, 155);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 72;
            label2.Text = "Şifre Tekrar";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(20, 70);
            label12.Name = "label12";
            label12.Size = new Size(53, 21);
            label12.TabIndex = 71;
            label12.Text = "Soyad";
            // 
            // txtPersonelID2
            // 
            txtPersonelID2.Location = new Point(234, 28);
            txtPersonelID2.Name = "txtPersonelID2";
            txtPersonelID2.Size = new Size(19, 23);
            txtPersonelID2.TabIndex = 69;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(20, 113);
            label13.Name = "label13";
            label13.Size = new Size(42, 21);
            label13.TabIndex = 68;
            label13.Text = "Şifre";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(20, 28);
            label14.Name = "label14";
            label14.Size = new Size(29, 21);
            label14.TabIndex = 67;
            label14.Text = "Ad";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(109, 109);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(119, 23);
            txtSifre.TabIndex = 66;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(109, 68);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(119, 23);
            txtSoyad.TabIndex = 65;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_degis2);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(textBox11);
            groupBox3.Controls.Add(textBox12);
            groupBox3.Location = new Point(638, 194);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(267, 255);
            groupBox3.TabIndex = 62;
            groupBox3.TabStop = false;
            groupBox3.Visible = false;
            // 
            // btn_degis2
            // 
            btn_degis2.BackColor = Color.IndianRed;
            btn_degis2.FlatAppearance.BorderColor = Color.IndianRed;
            btn_degis2.FlatStyle = FlatStyle.Popup;
            btn_degis2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_degis2.ImageAlign = ContentAlignment.MiddleLeft;
            btn_degis2.ImageKey = "icons8-change-100.png";
            btn_degis2.ImageList = ımageList1;
            btn_degis2.Location = new Point(105, 129);
            btn_degis2.Name = "btn_degis2";
            btn_degis2.Size = new Size(137, 63);
            btn_degis2.TabIndex = 66;
            btn_degis2.Text = "DEĞİŞTİR";
            btn_degis2.TextAlign = ContentAlignment.MiddleRight;
            btn_degis2.UseVisualStyleBackColor = false;
            btn_degis2.Click += btn_degis2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(25, 102);
            label8.Name = "label8";
            label8.Size = new Size(88, 21);
            label8.TabIndex = 65;
            label8.Text = "Şifre Tekrar";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(25, 64);
            label9.Name = "label9";
            label9.Size = new Size(75, 21);
            label9.TabIndex = 64;
            label9.Text = "Yeni Şifre";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(119, 62);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(100, 23);
            textBox11.TabIndex = 63;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(119, 100);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(100, 23);
            textBox12.TabIndex = 62;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lv_Personeller);
            groupBox4.Location = new Point(220, 540);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(483, 170);
            groupBox4.TabIndex = 63;
            groupBox4.TabStop = false;
            // 
            // lblBilgi
            // 
            lblBilgi.AutoSize = true;
            lblBilgi.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblBilgi.Location = new Point(306, 68);
            lblBilgi.Name = "lblBilgi";
            lblBilgi.Size = new Size(106, 25);
            lblBilgi.TabIndex = 64;
            lblBilgi.Text = "Giriş Yapan";
            lblBilgi.Click += lblBilgi_Click;
            // 
            // Ayarlar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(917, 741);
            Controls.Add(lblBilgi);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ayarlar";
            Text = "Ayarlar";
            Load += Ayarlar_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ImageList ımageList1;
        private ListView lv_Personeller;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private GroupBox groupBox1;
        private Button btn_degis1;
        private ComboBox cbPersonel;
        private Label label10;
        private Label label11;
        private TextBox txtSifreYeniTekrar;
        private TextBox txtSifreYeni;
        private GroupBox groupBox2;
        private Button btnBilgiDegistir;
        private Button btnSil;
        private Button btnEkle;
        private TextBox txtAd;
        private ComboBox cbGorevi;
        private TextBox txtGorevId;
        private TextBox txtSifreTekrar;
        private Label label1;
        private Label label2;
        private Label label12;
        private TextBox txtPersonelID2;
        private Label label13;
        private Label label14;
        private TextBox txtSifre;
        private TextBox txtSoyad;
        private GroupBox groupBox3;
        private Button btn_degis2;
        private Label label8;
        private Label label9;
        private TextBox textBox11;
        private TextBox textBox12;
        private GroupBox groupBox4;
        private Label lblBilgi;
        private TextBox txtPersonelID;
        private Button btnYeni;
    }
}