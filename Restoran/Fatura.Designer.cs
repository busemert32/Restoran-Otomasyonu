namespace Restoran
{
    partial class Fatura
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
            Button btn_öde;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fatura));
            Button btn_hesapÖzet;
            ımageList1 = new ImageList(components);
            groupBox3 = new GroupBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            lb_odenecek = new Label();
            lb_toplam = new Label();
            lb_kdv = new Label();
            lb_indirim = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox4 = new GroupBox();
            rbTicket = new RadioButton();
            rbKrediKart = new RadioButton();
            rbNakit = new RadioButton();
            gb_indirim = new GroupBox();
            label5 = new Label();
            txt_indirim = new TextBox();
            groupBox1 = new GroupBox();
            checkBox_indirim = new CheckBox();
            lvUrunler = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            lb_adisyonID = new Label();
            btn_geridon = new Button();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            btn_öde = new Button();
            btn_hesapÖzet = new Button();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            gb_indirim.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_öde
            // 
            btn_öde.BackColor = Color.IndianRed;
            btn_öde.FlatAppearance.BorderColor = Color.Black;
            btn_öde.FlatStyle = FlatStyle.Popup;
            btn_öde.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_öde.ForeColor = Color.Black;
            btn_öde.ImageAlign = ContentAlignment.MiddleLeft;
            btn_öde.ImageKey = "icons8-paid-100.png";
            btn_öde.ImageList = ımageList1;
            btn_öde.Location = new Point(692, 414);
            btn_öde.Name = "btn_öde";
            btn_öde.Size = new Size(141, 104);
            btn_öde.TabIndex = 32;
            btn_öde.Text = "Hesabı Kapat";
            btn_öde.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_öde.UseVisualStyleBackColor = false;
            btn_öde.Click += btn_öde_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "icons8-paid-100.png");
            ımageList1.Images.SetKeyName(1, "icons8-cancel-order-100.png");
            ımageList1.Images.SetKeyName(2, "icons8-document-100.png");
            ımageList1.Images.SetKeyName(3, "icons8-back-arrow-100.png");
            ımageList1.Images.SetKeyName(4, "icons8-back-arrow-100 (1).png");
            // 
            // btn_hesapÖzet
            // 
            btn_hesapÖzet.BackColor = Color.IndianRed;
            btn_hesapÖzet.FlatAppearance.BorderColor = Color.Black;
            btn_hesapÖzet.FlatStyle = FlatStyle.Popup;
            btn_hesapÖzet.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_hesapÖzet.ForeColor = Color.Black;
            btn_hesapÖzet.ImageAlign = ContentAlignment.MiddleLeft;
            btn_hesapÖzet.ImageKey = "icons8-document-100.png";
            btn_hesapÖzet.ImageList = ımageList1;
            btn_hesapÖzet.Location = new Point(692, 524);
            btn_hesapÖzet.Name = "btn_hesapÖzet";
            btn_hesapÖzet.Size = new Size(141, 104);
            btn_hesapÖzet.TabIndex = 33;
            btn_hesapÖzet.Text = "Hesap Özeti";
            btn_hesapÖzet.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_hesapÖzet.UseVisualStyleBackColor = false;
            btn_hesapÖzet.Click += btn_hesapÖzet_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(lb_odenecek);
            groupBox3.Controls.Add(lb_toplam);
            groupBox3.Controls.Add(lb_kdv);
            groupBox3.Controls.Add(lb_indirim);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox3.Location = new Point(56, 414);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(246, 195);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ödeme Bilgileri";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(155, 123);
            label12.Name = "label12";
            label12.Size = new Size(26, 21);
            label12.TabIndex = 11;
            label12.Text = "TL";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(155, 92);
            label11.Name = "label11";
            label11.Size = new Size(26, 21);
            label11.TabIndex = 10;
            label11.Text = "TL";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(155, 59);
            label10.Name = "label10";
            label10.Size = new Size(26, 21);
            label10.TabIndex = 9;
            label10.Text = "TL";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(155, 26);
            label9.Name = "label9";
            label9.Size = new Size(26, 21);
            label9.TabIndex = 8;
            label9.Text = "TL";
            // 
            // lb_odenecek
            // 
            lb_odenecek.AutoSize = true;
            lb_odenecek.Location = new Point(96, 123);
            lb_odenecek.Name = "lb_odenecek";
            lb_odenecek.Size = new Size(19, 21);
            lb_odenecek.TabIndex = 7;
            lb_odenecek.Text = "0";
            // 
            // lb_toplam
            // 
            lb_toplam.AutoSize = true;
            lb_toplam.Location = new Point(96, 92);
            lb_toplam.Name = "lb_toplam";
            lb_toplam.Size = new Size(19, 21);
            lb_toplam.TabIndex = 6;
            lb_toplam.Text = "0";
            // 
            // lb_kdv
            // 
            lb_kdv.AutoSize = true;
            lb_kdv.Location = new Point(96, 59);
            lb_kdv.Name = "lb_kdv";
            lb_kdv.Size = new Size(19, 21);
            lb_kdv.TabIndex = 5;
            lb_kdv.Text = "0";
            // 
            // lb_indirim
            // 
            lb_indirim.AutoSize = true;
            lb_indirim.Location = new Point(96, 26);
            lb_indirim.Name = "lb_indirim";
            lb_indirim.Size = new Size(19, 21);
            lb_indirim.TabIndex = 4;
            lb_indirim.Text = "0";
            lb_indirim.TextChanged += lb_indirim_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 123);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 3;
            label4.Text = "Toplam";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 92);
            label3.Name = "label3";
            label3.Size = new Size(43, 21);
            label3.TabIndex = 2;
            label3.Text = "Fiyat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 59);
            label2.Name = "label2";
            label2.Size = new Size(40, 21);
            label2.TabIndex = 1;
            label2.Text = "KDV";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 26);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 0;
            label1.Text = "İndirim";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(rbTicket);
            groupBox4.Controls.Add(rbKrediKart);
            groupBox4.Controls.Add(rbNakit);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox4.Location = new Point(338, 414);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(255, 195);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ödeme Türü";
            // 
            // rbTicket
            // 
            rbTicket.AutoSize = true;
            rbTicket.Font = new Font("Segoe UI", 12F);
            rbTicket.Location = new Point(40, 101);
            rbTicket.Name = "rbTicket";
            rbTicket.Size = new Size(68, 25);
            rbTicket.TabIndex = 2;
            rbTicket.TabStop = true;
            rbTicket.Text = "Ticket";
            rbTicket.UseVisualStyleBackColor = true;
            // 
            // rbKrediKart
            // 
            rbKrediKart.AutoSize = true;
            rbKrediKart.Font = new Font("Segoe UI", 12F);
            rbKrediKart.Location = new Point(40, 70);
            rbKrediKart.Name = "rbKrediKart";
            rbKrediKart.Size = new Size(96, 25);
            rbKrediKart.TabIndex = 1;
            rbKrediKart.TabStop = true;
            rbKrediKart.Text = "Kredi Kart";
            rbKrediKart.UseVisualStyleBackColor = true;
            // 
            // rbNakit
            // 
            rbNakit.AutoSize = true;
            rbNakit.Font = new Font("Segoe UI", 12F);
            rbNakit.Location = new Point(40, 39);
            rbNakit.Name = "rbNakit";
            rbNakit.Size = new Size(65, 25);
            rbNakit.TabIndex = 0;
            rbNakit.TabStop = true;
            rbNakit.Text = "Nakit";
            rbNakit.UseVisualStyleBackColor = true;
            // 
            // gb_indirim
            // 
            gb_indirim.Controls.Add(label5);
            gb_indirim.Controls.Add(txt_indirim);
            gb_indirim.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            gb_indirim.Location = new Point(578, 221);
            gb_indirim.Name = "gb_indirim";
            gb_indirim.Size = new Size(255, 112);
            gb_indirim.TabIndex = 5;
            gb_indirim.TabStop = false;
            gb_indirim.Text = "Özel Aktivite";
            gb_indirim.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 25);
            label5.Name = "label5";
            label5.Size = new Size(104, 21);
            label5.TabIndex = 12;
            label5.Text = "İndirim Tutarı";
            // 
            // txt_indirim
            // 
            txt_indirim.Location = new Point(14, 49);
            txt_indirim.Name = "txt_indirim";
            txt_indirim.Size = new Size(170, 29);
            txt_indirim.TabIndex = 0;
            txt_indirim.TextChanged += txt_indirim_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox_indirim);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(578, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(255, 94);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Özel İndirim";
            // 
            // checkBox_indirim
            // 
            checkBox_indirim.AutoSize = true;
            checkBox_indirim.Location = new Point(22, 41);
            checkBox_indirim.Name = "checkBox_indirim";
            checkBox_indirim.Size = new Size(154, 25);
            checkBox_indirim.TabIndex = 0;
            checkBox_indirim.Text = "İndirim Uygulama";
            checkBox_indirim.UseVisualStyleBackColor = true;
            checkBox_indirim.CheckedChanged += checkBox_indirim_CheckedChanged;
            // 
            // lvUrunler
            // 
            lvUrunler.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lvUrunler.FullRowSelect = true;
            lvUrunler.GridLines = true;
            lvUrunler.Location = new Point(56, 76);
            lvUrunler.Name = "lvUrunler";
            lvUrunler.Size = new Size(428, 257);
            lvUrunler.TabIndex = 34;
            lvUrunler.UseCompatibleStateImageBehavior = false;
            lvUrunler.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Ürün Ad";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Adet";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ürün ID";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Fiyat";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "SatisId";
            // 
            // lb_adisyonID
            // 
            lb_adisyonID.AutoSize = true;
            lb_adisyonID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lb_adisyonID.Location = new Point(127, 47);
            lb_adisyonID.Name = "lb_adisyonID";
            lb_adisyonID.Size = new Size(25, 21);
            lb_adisyonID.TabIndex = 13;
            lb_adisyonID.Text = "ID";
            // 
            // btn_geridon
            // 
            btn_geridon.BackColor = Color.Transparent;
            btn_geridon.FlatStyle = FlatStyle.Flat;
            btn_geridon.ImageKey = "icons8-back-arrow-100 (1).png";
            btn_geridon.ImageList = ımageList1;
            btn_geridon.Location = new Point(838, 12);
            btn_geridon.Name = "btn_geridon";
            btn_geridon.Size = new Size(55, 56);
            btn_geridon.TabIndex = 66;
            btn_geridon.UseVisualStyleBackColor = false;
            btn_geridon.Click += btn_geridon_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // Fatura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(917, 730);
            Controls.Add(btn_geridon);
            Controls.Add(lb_adisyonID);
            Controls.Add(lvUrunler);
            Controls.Add(btn_hesapÖzet);
            Controls.Add(btn_öde);
            Controls.Add(gb_indirim);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Fatura";
            Text = "Fatura";
            Load += Fatura_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            gb_indirim.ResumeLayout(false);
            gb_indirim.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox3;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label lb_odenecek;
        private Label lb_toplam;
        private Label lb_kdv;
        private Label lb_indirim;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox4;
        private RadioButton rbTicket;
        private RadioButton rbKrediKart;
        private RadioButton rbNakit;
        private GroupBox gb_indirim;
        private Label label5;
        private TextBox txt_indirim;
        private GroupBox groupBox1;
        private CheckBox checkBox_indirim;
        private ImageList ımageList1;
        private ListView lvUrunler;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label lb_adisyonID;
        private Button btn_geridon;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}