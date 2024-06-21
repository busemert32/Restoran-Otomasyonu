namespace Restoran
{
    partial class Mutfak
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
            Button btnEkle;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mutfak));
            Button btnDegis;
            Button btnBul;
            Button btnSil;
            ımageList1 = new ImageList(components);
            rbAnaKategori = new RadioButton();
            rbAltkategori = new RadioButton();
            panelAnakategori = new Panel();
            txtKategoriID = new TextBox();
            txt_KategoriAd = new TextBox();
            label7 = new Label();
            panelUrun = new Panel();
            cbKategoriler = new ComboBox();
            txtUrunId = new TextBox();
            txt_ürünAd = new TextBox();
            txt_ürünfiyat = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            txtArama = new TextBox();
            label4 = new Label();
            lv_ürünListesi = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            lvkategoriler = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            btnEkle = new Button();
            btnDegis = new Button();
            btnBul = new Button();
            btnSil = new Button();
            panelAnakategori.SuspendLayout();
            panelUrun.SuspendLayout();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.IndianRed;
            btnEkle.FlatAppearance.BorderColor = Color.IndianRed;
            btnEkle.FlatStyle = FlatStyle.Popup;
            btnEkle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnEkle.ForeColor = Color.Black;
            btnEkle.ImageAlign = ContentAlignment.MiddleLeft;
            btnEkle.ImageKey = "icons8-plus-100.png";
            btnEkle.ImageList = ımageList1;
            btnEkle.Location = new Point(114, 408);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(149, 63);
            btnEkle.TabIndex = 57;
            btnEkle.Text = "EKLE";
            btnEkle.TextAlign = ContentAlignment.MiddleRight;
            btnEkle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "icons8-trash-100.png");
            ımageList1.Images.SetKeyName(1, "icons8-search-100.png");
            ımageList1.Images.SetKeyName(2, "icons8-plus-100.png");
            ımageList1.Images.SetKeyName(3, "icons8-change-100.png");
            // 
            // btnDegis
            // 
            btnDegis.BackColor = Color.IndianRed;
            btnDegis.FlatAppearance.BorderColor = Color.IndianRed;
            btnDegis.FlatStyle = FlatStyle.Popup;
            btnDegis.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnDegis.ForeColor = Color.Black;
            btnDegis.ImageAlign = ContentAlignment.MiddleLeft;
            btnDegis.ImageKey = "icons8-change-100.png";
            btnDegis.ImageList = ımageList1;
            btnDegis.Location = new Point(291, 408);
            btnDegis.Name = "btnDegis";
            btnDegis.Size = new Size(149, 63);
            btnDegis.TabIndex = 58;
            btnDegis.Text = "DEĞİŞTİR";
            btnDegis.TextAlign = ContentAlignment.MiddleRight;
            btnDegis.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDegis.UseVisualStyleBackColor = false;
            btnDegis.Click += btnDegis_Click;
            // 
            // btnBul
            // 
            btnBul.BackColor = Color.IndianRed;
            btnBul.FlatAppearance.BorderColor = Color.IndianRed;
            btnBul.FlatStyle = FlatStyle.Popup;
            btnBul.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnBul.ForeColor = Color.Black;
            btnBul.ImageAlign = ContentAlignment.MiddleLeft;
            btnBul.ImageKey = "icons8-search-100.png";
            btnBul.ImageList = ımageList1;
            btnBul.Location = new Point(468, 408);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(149, 63);
            btnBul.TabIndex = 59;
            btnBul.Text = "BUL";
            btnBul.TextAlign = ContentAlignment.MiddleRight;
            btnBul.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBul.UseVisualStyleBackColor = false;
            btnBul.Click += btnBul_Click_1;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.IndianRed;
            btnSil.FlatAppearance.BorderColor = Color.IndianRed;
            btnSil.FlatStyle = FlatStyle.Popup;
            btnSil.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSil.ForeColor = Color.Black;
            btnSil.ImageAlign = ContentAlignment.MiddleLeft;
            btnSil.ImageKey = "icons8-trash-100.png";
            btnSil.ImageList = ımageList1;
            btnSil.Location = new Point(641, 408);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(149, 63);
            btnSil.TabIndex = 61;
            btnSil.Text = "SİL";
            btnSil.TextAlign = ContentAlignment.MiddleRight;
            btnSil.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // rbAnaKategori
            // 
            rbAnaKategori.AutoSize = true;
            rbAnaKategori.Font = new Font("Segoe UI", 12F);
            rbAnaKategori.Location = new Point(499, 38);
            rbAnaKategori.Name = "rbAnaKategori";
            rbAnaKategori.Size = new Size(157, 25);
            rbAnaKategori.TabIndex = 25;
            rbAnaKategori.TabStop = true;
            rbAnaKategori.Text = "Ürün Kategori Ekle";
            rbAnaKategori.UseVisualStyleBackColor = true;
            rbAnaKategori.CheckedChanged += rbAnaKategori_CheckedChanged_1;
            // 
            // rbAltkategori
            // 
            rbAltkategori.AutoSize = true;
            rbAltkategori.Font = new Font("Segoe UI", 12F);
            rbAltkategori.Location = new Point(338, 38);
            rbAltkategori.Name = "rbAltkategori";
            rbAltkategori.Size = new Size(95, 25);
            rbAltkategori.TabIndex = 24;
            rbAltkategori.TabStop = true;
            rbAltkategori.Text = "Ürün Ekle";
            rbAltkategori.UseVisualStyleBackColor = true;
            rbAltkategori.CheckedChanged += rbAltkategori_CheckedChanged;
            // 
            // panelAnakategori
            // 
            panelAnakategori.Controls.Add(txtKategoriID);
            panelAnakategori.Controls.Add(txt_KategoriAd);
            panelAnakategori.Controls.Add(label7);
            panelAnakategori.Location = new Point(329, 91);
            panelAnakategori.Name = "panelAnakategori";
            panelAnakategori.Size = new Size(301, 178);
            panelAnakategori.TabIndex = 23;
            // 
            // txtKategoriID
            // 
            txtKategoriID.Location = new Point(258, 73);
            txtKategoriID.Name = "txtKategoriID";
            txtKategoriID.Size = new Size(17, 23);
            txtKategoriID.TabIndex = 4;
            // 
            // txt_KategoriAd
            // 
            txt_KategoriAd.Location = new Point(152, 73);
            txt_KategoriAd.Name = "txt_KategoriAd";
            txt_KategoriAd.Size = new Size(100, 23);
            txt_KategoriAd.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(33, 77);
            label7.Name = "label7";
            label7.Size = new Size(95, 21);
            label7.TabIndex = 0;
            label7.Text = "Kategori Adı";
            // 
            // panelUrun
            // 
            panelUrun.Controls.Add(cbKategoriler);
            panelUrun.Controls.Add(txtUrunId);
            panelUrun.Controls.Add(txt_ürünAd);
            panelUrun.Controls.Add(txt_ürünfiyat);
            panelUrun.Controls.Add(label5);
            panelUrun.Controls.Add(label6);
            panelUrun.Controls.Add(label8);
            panelUrun.Location = new Point(329, 91);
            panelUrun.Name = "panelUrun";
            panelUrun.Size = new Size(301, 178);
            panelUrun.TabIndex = 26;
            panelUrun.Paint += panelUrun_Paint;
            // 
            // cbKategoriler
            // 
            cbKategoriler.FormattingEnabled = true;
            cbKategoriler.Location = new Point(138, 41);
            cbKategoriler.Name = "cbKategoriler";
            cbKategoriler.Size = new Size(121, 23);
            cbKategoriler.TabIndex = 16;
            cbKategoriler.SelectedIndexChanged += cbKategoriler_SelectedIndexChanged;
            // 
            // txtUrunId
            // 
            txtUrunId.Location = new Point(244, 75);
            txtUrunId.Name = "txtUrunId";
            txtUrunId.Size = new Size(15, 23);
            txtUrunId.TabIndex = 7;
            // 
            // txt_ürünAd
            // 
            txt_ürünAd.Location = new Point(138, 75);
            txt_ürünAd.Name = "txt_ürünAd";
            txt_ürünAd.Size = new Size(100, 23);
            txt_ürünAd.TabIndex = 14;
            // 
            // txt_ürünfiyat
            // 
            txt_ürünfiyat.Location = new Point(138, 109);
            txt_ürünfiyat.Name = "txt_ürünfiyat";
            txt_ürünfiyat.Size = new Size(100, 23);
            txt_ürünfiyat.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(29, 107);
            label5.Name = "label5";
            label5.Size = new Size(86, 21);
            label5.TabIndex = 2;
            label5.Text = "Ürün Fiyatı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(29, 77);
            label6.Name = "label6";
            label6.Size = new Size(72, 21);
            label6.TabIndex = 1;
            label6.Text = "Ürün Adı";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(29, 42);
            label8.Name = "label8";
            label8.Size = new Size(107, 21);
            label8.TabIndex = 0;
            label8.Text = "Ürün Kategori";
            // 
            // txtArama
            // 
            txtArama.Location = new Point(484, 325);
            txtArama.Multiline = true;
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(146, 32);
            txtArama.TabIndex = 17;
            txtArama.Visible = false;
            txtArama.TextChanged += txtArama_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(262, 332);
            label4.Name = "label4";
            label4.Size = new Size(216, 25);
            label4.TabIndex = 18;
            label4.Text = "Aramak istediğiniz ürün:";
            label4.Visible = false;
            // 
            // lv_ürünListesi
            // 
            lv_ürünListesi.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lv_ürünListesi.FullRowSelect = true;
            lv_ürünListesi.GridLines = true;
            lv_ürünListesi.Location = new Point(239, 491);
            lv_ürünListesi.Name = "lv_ürünListesi";
            lv_ürünListesi.Size = new Size(417, 191);
            lv_ürünListesi.TabIndex = 15;
            lv_ürünListesi.UseCompatibleStateImageBehavior = false;
            lv_ürünListesi.View = View.Details;
            lv_ürünListesi.SelectedIndexChanged += lv_ürünListesi_SelectedIndexChanged;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Urun Id";
            columnHeader3.Width = 0;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "UrunTurNo";
            columnHeader4.Width = 0;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Kategori";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Urun Adı";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Fiyat";
            columnHeader7.TextAlign = HorizontalAlignment.Right;
            columnHeader7.Width = 100;
            // 
            // lvkategoriler
            // 
            lvkategoriler.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lvkategoriler.FullRowSelect = true;
            lvkategoriler.GridLines = true;
            lvkategoriler.Location = new Point(239, 491);
            lvkategoriler.Name = "lvkategoriler";
            lvkategoriler.Size = new Size(417, 191);
            lvkategoriler.TabIndex = 13;
            lvkategoriler.UseCompatibleStateImageBehavior = false;
            lvkategoriler.View = View.Details;
            lvkategoriler.SelectedIndexChanged += lvkategoriler_SelectedIndexChanged_1;
            lvkategoriler.MouseDoubleClick += lvkategoriler_MouseDoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "TurId";
            columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Kategori";
            columnHeader2.Width = 100;
            // 
            // Mutfak
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(917, 741);
            Controls.Add(btnSil);
            Controls.Add(btnBul);
            Controls.Add(btnDegis);
            Controls.Add(panelUrun);
            Controls.Add(btnEkle);
            Controls.Add(rbAnaKategori);
            Controls.Add(rbAltkategori);
            Controls.Add(panelAnakategori);
            Controls.Add(txtArama);
            Controls.Add(label4);
            Controls.Add(lv_ürünListesi);
            Controls.Add(lvkategoriler);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Mutfak";
            Text = "Mutfak";
            Load += Mutfak_Load_1;
            panelAnakategori.ResumeLayout(false);
            panelAnakategori.PerformLayout();
            panelUrun.ResumeLayout(false);
            panelUrun.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbAnaKategori;
        private RadioButton rbAltkategori;
        private Panel panelAnakategori;
        private TextBox txtKategoriID;
        private TextBox txt_KategoriAd;
        private Label label7;
        private TextBox txtArama;
        private Label label4;
        private TextBox txtUrunId;
        private ListView lv_ürünListesi;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ListView lvkategoriler;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Panel panelUrun;
        private TextBox txt_ürünAd;
        private TextBox txt_ürünfiyat;
        private Label label5;
        private Label label6;
        private Label label8;
        private ImageList ımageList1;
        private ComboBox cbKategoriler;
    }
}