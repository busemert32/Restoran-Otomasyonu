namespace Restoran
{
    partial class Siparis
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
            Button btn_iptal;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Siparis));
            Button btn_siparis;
            Button btn_öde;
            ımageList1 = new ImageList(components);
            groupBox1 = new GroupBox();
            btn_corba3 = new Button();
            btn_icicek6 = new Button();
            btn_tatli5 = new Button();
            btn_salata2 = new Button();
            btn_pide4 = new Button();
            btn_anayemek1 = new Button();
            label1 = new Label();
            button0 = new Button();
            button_del = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            txt_arama = new TextBox();
            lv_urun_tablosu = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            lv_Siparisler = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            lblMasaNo = new Label();
            btn_geridon = new Button();
            txt_adet = new TextBox();
            button1 = new Button();
            lv_yeni = new ListView();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            btn_iptal = new Button();
            btn_siparis = new Button();
            btn_öde = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_iptal
            // 
            btn_iptal.BackColor = Color.IndianRed;
            btn_iptal.FlatAppearance.BorderColor = Color.IndianRed;
            btn_iptal.FlatStyle = FlatStyle.Popup;
            btn_iptal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_iptal.ForeColor = Color.Black;
            btn_iptal.ImageAlign = ContentAlignment.MiddleLeft;
            btn_iptal.ImageKey = "icons8-cancel-order-100.png";
            btn_iptal.ImageList = ımageList1;
            btn_iptal.Location = new Point(702, 527);
            btn_iptal.Name = "btn_iptal";
            btn_iptal.Size = new Size(121, 63);
            btn_iptal.TabIndex = 58;
            btn_iptal.Text = "İptal";
            btn_iptal.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_iptal.UseVisualStyleBackColor = false;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "icons8-dinner-100.png");
            ımageList1.Images.SetKeyName(1, "icons8-salad-100.png");
            ımageList1.Images.SetKeyName(2, "icons8-bread-100.png");
            ımageList1.Images.SetKeyName(3, "icons8-soup-plate-100.png");
            ımageList1.Images.SetKeyName(4, "icons8-dessert-100.png");
            ımageList1.Images.SetKeyName(5, "icons8-drink-100.png");
            ımageList1.Images.SetKeyName(6, "icons8-create-order-100.png");
            ımageList1.Images.SetKeyName(7, "icons8-cancel-order-100.png");
            ımageList1.Images.SetKeyName(8, "icons8-order-completed-100.png");
            ımageList1.Images.SetKeyName(9, "icons8-back-arrow-100 (1).png");
            ımageList1.Images.SetKeyName(10, "icons8-back-arrow-100.png");
            // 
            // btn_siparis
            // 
            btn_siparis.BackColor = Color.IndianRed;
            btn_siparis.FlatAppearance.BorderColor = Color.IndianRed;
            btn_siparis.FlatStyle = FlatStyle.Popup;
            btn_siparis.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_siparis.ForeColor = Color.Black;
            btn_siparis.ImageAlign = ContentAlignment.MiddleLeft;
            btn_siparis.ImageKey = "icons8-create-order-100.png";
            btn_siparis.ImageList = ımageList1;
            btn_siparis.Location = new Point(773, 444);
            btn_siparis.Name = "btn_siparis";
            btn_siparis.Size = new Size(128, 63);
            btn_siparis.TabIndex = 57;
            btn_siparis.Text = "Sipariş";
            btn_siparis.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_siparis.UseVisualStyleBackColor = false;
            btn_siparis.Click += btn_siparis_Click;
            // 
            // btn_öde
            // 
            btn_öde.BackColor = Color.IndianRed;
            btn_öde.FlatAppearance.BorderColor = Color.IndianRed;
            btn_öde.FlatStyle = FlatStyle.Popup;
            btn_öde.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_öde.ForeColor = Color.Black;
            btn_öde.ImageAlign = ContentAlignment.MiddleLeft;
            btn_öde.ImageKey = "icons8-order-completed-100.png";
            btn_öde.ImageList = ımageList1;
            btn_öde.Location = new Point(636, 444);
            btn_öde.Name = "btn_öde";
            btn_öde.Size = new Size(121, 63);
            btn_öde.TabIndex = 56;
            btn_öde.Text = "Öde";
            btn_öde.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_öde.UseVisualStyleBackColor = false;
            btn_öde.Click += btn_öde_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_corba3);
            groupBox1.Controls.Add(btn_icicek6);
            groupBox1.Controls.Add(btn_tatli5);
            groupBox1.Controls.Add(btn_salata2);
            groupBox1.Controls.Add(btn_pide4);
            groupBox1.Controls.Add(btn_anayemek1);
            groupBox1.Location = new Point(22, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(167, 589);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menü";
            // 
            // btn_corba3
            // 
            btn_corba3.BackColor = Color.IndianRed;
            btn_corba3.FlatAppearance.BorderColor = Color.IndianRed;
            btn_corba3.FlatStyle = FlatStyle.Flat;
            btn_corba3.ImageAlign = ContentAlignment.MiddleLeft;
            btn_corba3.ImageKey = "icons8-soup-plate-100.png";
            btn_corba3.ImageList = ımageList1;
            btn_corba3.Location = new Point(20, 208);
            btn_corba3.Name = "btn_corba3";
            btn_corba3.Size = new Size(126, 72);
            btn_corba3.TabIndex = 22;
            btn_corba3.Text = "Çorbalar";
            btn_corba3.TextAlign = ContentAlignment.MiddleRight;
            btn_corba3.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_corba3.UseVisualStyleBackColor = false;
            btn_corba3.Click += btn_corba3_Click;
            // 
            // btn_icicek6
            // 
            btn_icicek6.BackColor = Color.IndianRed;
            btn_icicek6.FlatAppearance.BorderColor = Color.IndianRed;
            btn_icicek6.FlatStyle = FlatStyle.Flat;
            btn_icicek6.ImageAlign = ContentAlignment.MiddleLeft;
            btn_icicek6.ImageKey = "icons8-drink-100.png";
            btn_icicek6.ImageList = ımageList1;
            btn_icicek6.Location = new Point(20, 497);
            btn_icicek6.Name = "btn_icicek6";
            btn_icicek6.Size = new Size(126, 72);
            btn_icicek6.TabIndex = 21;
            btn_icicek6.Text = "İçicekler";
            btn_icicek6.TextAlign = ContentAlignment.MiddleRight;
            btn_icicek6.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_icicek6.UseVisualStyleBackColor = false;
            btn_icicek6.Click += btn_icicek6_Click;
            // 
            // btn_tatli5
            // 
            btn_tatli5.BackColor = Color.IndianRed;
            btn_tatli5.FlatAppearance.BorderColor = Color.IndianRed;
            btn_tatli5.FlatStyle = FlatStyle.Flat;
            btn_tatli5.ImageAlign = ContentAlignment.MiddleLeft;
            btn_tatli5.ImageKey = "icons8-dessert-100.png";
            btn_tatli5.ImageList = ımageList1;
            btn_tatli5.Location = new Point(20, 401);
            btn_tatli5.Name = "btn_tatli5";
            btn_tatli5.Size = new Size(126, 72);
            btn_tatli5.TabIndex = 20;
            btn_tatli5.Text = "Tatlılar";
            btn_tatli5.TextAlign = ContentAlignment.MiddleRight;
            btn_tatli5.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_tatli5.UseVisualStyleBackColor = false;
            btn_tatli5.Click += btn_tatli5_Click;
            // 
            // btn_salata2
            // 
            btn_salata2.BackColor = Color.IndianRed;
            btn_salata2.FlatAppearance.BorderColor = Color.IndianRed;
            btn_salata2.FlatStyle = FlatStyle.Flat;
            btn_salata2.ImageAlign = ContentAlignment.MiddleLeft;
            btn_salata2.ImageKey = "icons8-salad-100.png";
            btn_salata2.ImageList = ımageList1;
            btn_salata2.Location = new Point(20, 114);
            btn_salata2.Name = "btn_salata2";
            btn_salata2.Size = new Size(126, 72);
            btn_salata2.TabIndex = 19;
            btn_salata2.Text = "Salatalar";
            btn_salata2.TextAlign = ContentAlignment.MiddleRight;
            btn_salata2.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_salata2.UseVisualStyleBackColor = false;
            btn_salata2.Click += btn_salata2_Click;
            // 
            // btn_pide4
            // 
            btn_pide4.BackColor = Color.IndianRed;
            btn_pide4.FlatAppearance.BorderColor = Color.IndianRed;
            btn_pide4.FlatStyle = FlatStyle.Flat;
            btn_pide4.ImageAlign = ContentAlignment.MiddleLeft;
            btn_pide4.ImageKey = "icons8-bread-100.png";
            btn_pide4.ImageList = ımageList1;
            btn_pide4.Location = new Point(20, 304);
            btn_pide4.Name = "btn_pide4";
            btn_pide4.Size = new Size(126, 72);
            btn_pide4.TabIndex = 17;
            btn_pide4.Text = "Pideler";
            btn_pide4.TextAlign = ContentAlignment.MiddleRight;
            btn_pide4.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_pide4.UseVisualStyleBackColor = false;
            btn_pide4.Click += btn_pide4_Click;
            // 
            // btn_anayemek1
            // 
            btn_anayemek1.BackColor = Color.IndianRed;
            btn_anayemek1.FlatAppearance.BorderColor = Color.IndianRed;
            btn_anayemek1.FlatStyle = FlatStyle.Flat;
            btn_anayemek1.ImageAlign = ContentAlignment.MiddleLeft;
            btn_anayemek1.ImageKey = "icons8-dinner-100.png";
            btn_anayemek1.ImageList = ımageList1;
            btn_anayemek1.Location = new Point(20, 20);
            btn_anayemek1.Name = "btn_anayemek1";
            btn_anayemek1.Size = new Size(126, 72);
            btn_anayemek1.TabIndex = 18;
            btn_anayemek1.Text = "Ana Yemekler";
            btn_anayemek1.TextAlign = ContentAlignment.MiddleRight;
            btn_anayemek1.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_anayemek1.UseVisualStyleBackColor = false;
            btn_anayemek1.Click += btn_anayemek1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(229, 112);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 23;
            label1.Text = "Ürün Ara";
            // 
            // button0
            // 
            button0.BackColor = Color.Black;
            button0.FlatAppearance.BorderColor = Color.IndianRed;
            button0.FlatStyle = FlatStyle.Flat;
            button0.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button0.ForeColor = SystemColors.ControlLightLight;
            button0.Location = new Point(791, 389);
            button0.Name = "button0";
            button0.Size = new Size(51, 46);
            button0.TabIndex = 55;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            // 
            // button_del
            // 
            button_del.BackColor = Color.Black;
            button_del.FlatAppearance.BorderColor = Color.IndianRed;
            button_del.FlatStyle = FlatStyle.Flat;
            button_del.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button_del.ForeColor = SystemColors.ControlLightLight;
            button_del.Location = new Point(670, 389);
            button_del.Name = "button_del";
            button_del.Size = new Size(110, 46);
            button_del.TabIndex = 54;
            button_del.Text = "Delete";
            button_del.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.Black;
            button9.FlatAppearance.BorderColor = Color.IndianRed;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button9.ForeColor = SystemColors.ControlLightLight;
            button9.Location = new Point(791, 337);
            button9.Name = "button9";
            button9.Size = new Size(51, 46);
            button9.TabIndex = 53;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.Black;
            button8.FlatAppearance.BorderColor = Color.IndianRed;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button8.ForeColor = SystemColors.ControlLightLight;
            button8.Location = new Point(729, 337);
            button8.Name = "button8";
            button8.Size = new Size(51, 46);
            button8.TabIndex = 52;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Black;
            button7.FlatAppearance.BorderColor = Color.IndianRed;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Location = new Point(670, 337);
            button7.Name = "button7";
            button7.Size = new Size(51, 46);
            button7.TabIndex = 51;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Black;
            button6.FlatAppearance.BorderColor = Color.IndianRed;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Location = new Point(791, 285);
            button6.Name = "button6";
            button6.Size = new Size(51, 46);
            button6.TabIndex = 50;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.FlatAppearance.BorderColor = Color.IndianRed;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(729, 285);
            button5.Name = "button5";
            button5.Size = new Size(51, 46);
            button5.TabIndex = 49;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.FlatAppearance.BorderColor = Color.IndianRed;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(670, 285);
            button4.Name = "button4";
            button4.Size = new Size(51, 46);
            button4.TabIndex = 48;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.FlatAppearance.BorderColor = Color.IndianRed;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(791, 233);
            button3.Name = "button3";
            button3.Size = new Size(51, 46);
            button3.TabIndex = 47;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatAppearance.BorderColor = Color.IndianRed;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(729, 233);
            button2.Name = "button2";
            button2.Size = new Size(51, 46);
            button2.TabIndex = 46;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            // 
            // txt_arama
            // 
            txt_arama.Location = new Point(229, 140);
            txt_arama.Multiline = true;
            txt_arama.Name = "txt_arama";
            txt_arama.PlaceholderText = "Arama Butonu...";
            txt_arama.Size = new Size(219, 36);
            txt_arama.TabIndex = 60;
            txt_arama.TextChanged += txt_arama_TextChanged;
            // 
            // lv_urun_tablosu
            // 
            lv_urun_tablosu.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lv_urun_tablosu.FullRowSelect = true;
            lv_urun_tablosu.GridLines = true;
            lv_urun_tablosu.Location = new Point(229, 189);
            lv_urun_tablosu.Name = "lv_urun_tablosu";
            lv_urun_tablosu.Size = new Size(361, 256);
            lv_urun_tablosu.TabIndex = 61;
            lv_urun_tablosu.UseCompatibleStateImageBehavior = false;
            lv_urun_tablosu.View = View.Details;
            lv_urun_tablosu.DoubleClick += lv_urun_tablosu_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Ürün Ad";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ürün Fiyat";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ürün No";
            // 
            // lv_Siparisler
            // 
            lv_Siparisler.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader7, columnHeader6, columnHeader8, columnHeader9 });
            lv_Siparisler.FullRowSelect = true;
            lv_Siparisler.GridLines = true;
            lv_Siparisler.Location = new Point(229, 455);
            lv_Siparisler.Name = "lv_Siparisler";
            lv_Siparisler.Size = new Size(361, 256);
            lv_Siparisler.TabIndex = 62;
            lv_Siparisler.UseCompatibleStateImageBehavior = false;
            lv_Siparisler.View = View.Details;
            lv_Siparisler.DoubleClick += lv_Siparisler_DoubleClick;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Ürün Ad";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Ürün Adet";
            columnHeader5.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Ürün ID";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Ürün Fiyat";
            columnHeader6.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "SatisId";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "SilinenID";
            // 
            // lblMasaNo
            // 
            lblMasaNo.AutoSize = true;
            lblMasaNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblMasaNo.Location = new Point(62, 108);
            lblMasaNo.Name = "lblMasaNo";
            lblMasaNo.Size = new Size(66, 21);
            lblMasaNo.TabIndex = 63;
            lblMasaNo.Text = "MASA 1";
            // 
            // btn_geridon
            // 
            btn_geridon.BackColor = Color.Transparent;
            btn_geridon.FlatStyle = FlatStyle.Flat;
            btn_geridon.ImageKey = "icons8-back-arrow-100 (1).png";
            btn_geridon.ImageList = ımageList1;
            btn_geridon.Location = new Point(850, 12);
            btn_geridon.Name = "btn_geridon";
            btn_geridon.Size = new Size(55, 56);
            btn_geridon.TabIndex = 65;
            btn_geridon.UseVisualStyleBackColor = false;
            btn_geridon.Click += btn_geridon_Click;
            // 
            // txt_adet
            // 
            txt_adet.Location = new Point(670, 189);
            txt_adet.Multiline = true;
            txt_adet.Name = "txt_adet";
            txt_adet.PlaceholderText = "  Adet...";
            txt_adet.Size = new Size(172, 36);
            txt_adet.TabIndex = 66;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderColor = Color.IndianRed;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(670, 233);
            button1.Name = "button1";
            button1.Size = new Size(51, 46);
            button1.TabIndex = 67;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            // 
            // lv_yeni
            // 
            lv_yeni.Columns.AddRange(new ColumnHeader[] { columnHeader10, columnHeader11, columnHeader12, columnHeader13, columnHeader14 });
            lv_yeni.FullRowSelect = true;
            lv_yeni.Location = new Point(259, 12);
            lv_yeni.Name = "lv_yeni";
            lv_yeni.Size = new Size(406, 97);
            lv_yeni.TabIndex = 68;
            lv_yeni.UseCompatibleStateImageBehavior = false;
            lv_yeni.View = View.Details;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "AdisyonId";
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "UrunId";
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Adet";
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "MasaId";
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "silinenId";
            // 
            // Siparis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(917, 741);
            Controls.Add(lv_yeni);
            Controls.Add(button1);
            Controls.Add(txt_adet);
            Controls.Add(btn_geridon);
            Controls.Add(lblMasaNo);
            Controls.Add(lv_Siparisler);
            Controls.Add(lv_urun_tablosu);
            Controls.Add(txt_arama);
            Controls.Add(btn_iptal);
            Controls.Add(btn_siparis);
            Controls.Add(btn_öde);
            Controls.Add(button0);
            Controls.Add(label1);
            Controls.Add(button_del);
            Controls.Add(groupBox1);
            Controls.Add(button9);
            Controls.Add(button3);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(button4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Siparis";
            Text = "Siparis";
            Load += Siparis_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_corba3;
        private ImageList ımageList1;
        private Button btn_icicek6;
        private Button btn_tatli5;
        private Button btn_salata2;
        private Button btn_pide4;
        private Button btn_anayemek1;
        private Label label1;
        private Button button0;
        private Button button_del;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private TextBox txt_arama;
        private ListView lv_urun_tablosu;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ListView lv_Siparisler;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private Label lblMasaNo;
        private Button btn_geridon;
        private TextBox txt_adet;
        private Button button1;
        private ListView lv_yeni;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
    }
}