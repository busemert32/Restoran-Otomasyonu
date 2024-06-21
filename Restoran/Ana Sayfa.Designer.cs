namespace Restoran
{
    partial class Ana_Sayfa
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
            Button btn_anaS;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ana_Sayfa));
            Button btn_masa;
            ımageList1 = new ImageList(components);
            panel1 = new Panel();
            btn_rapor = new Button();
            btn_personel = new Button();
            btn_mutfak = new Button();
            pictureBox1 = new PictureBox();
            label_restoran = new Label();
            panel2 = new Panel();
            btn_cikis = new Button();
            panel_form = new Panel();
            pictureBox2 = new PictureBox();
            btn_anaS = new Button();
            btn_masa = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel_form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_anaS
            // 
            btn_anaS.BackColor = Color.IndianRed;
            btn_anaS.FlatAppearance.BorderColor = Color.IndianRed;
            btn_anaS.FlatStyle = FlatStyle.Flat;
            btn_anaS.Font = new Font("Segoe UI", 11.25F);
            btn_anaS.ForeColor = Color.Black;
            btn_anaS.ImageAlign = ContentAlignment.TopCenter;
            btn_anaS.ImageKey = "icons8-dog-house-100.png";
            btn_anaS.ImageList = ımageList1;
            btn_anaS.Location = new Point(0, 132);
            btn_anaS.Name = "btn_anaS";
            btn_anaS.Size = new Size(155, 77);
            btn_anaS.TabIndex = 14;
            btn_anaS.Text = "Ana Sayfa";
            btn_anaS.TextAlign = ContentAlignment.BottomCenter;
            btn_anaS.UseVisualStyleBackColor = false;
            btn_anaS.Click += btn_anaS_Click_1;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "icons8-wrong-100.png");
            ımageList1.Images.SetKeyName(1, "icons8-bill-100.png");
            ımageList1.Images.SetKeyName(2, "icons8-dog-house-100.png");
            ımageList1.Images.SetKeyName(3, "icons8-restaurant-menu-100.png");
            ımageList1.Images.SetKeyName(4, "icons8-table-100.png");
            ımageList1.Images.SetKeyName(5, "icons8-waiter-100.png");
            ımageList1.Images.SetKeyName(6, "icons8-chef-hat-100.png");
            ımageList1.Images.SetKeyName(7, "icons8-document-100.png");
            ımageList1.Images.SetKeyName(8, "icons8-restaurant-100.png");
            ımageList1.Images.SetKeyName(9, "icons8-settings-100.png");
            // 
            // btn_masa
            // 
            btn_masa.FlatAppearance.BorderColor = Color.IndianRed;
            btn_masa.FlatStyle = FlatStyle.Flat;
            btn_masa.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_masa.ForeColor = Color.Black;
            btn_masa.ImageAlign = ContentAlignment.TopCenter;
            btn_masa.ImageKey = "icons8-restaurant-100.png";
            btn_masa.ImageList = ımageList1;
            btn_masa.Location = new Point(0, 260);
            btn_masa.Name = "btn_masa";
            btn_masa.Size = new Size(155, 72);
            btn_masa.TabIndex = 0;
            btn_masa.Text = "Masa";
            btn_masa.TextAlign = ContentAlignment.BottomCenter;
            btn_masa.UseVisualStyleBackColor = true;
            btn_masa.Click += btn_masa_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(btn_rapor);
            panel1.Controls.Add(btn_personel);
            panel1.Controls.Add(btn_mutfak);
            panel1.Controls.Add(btn_masa);
            panel1.Controls.Add(btn_anaS);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label_restoran);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(155, 815);
            panel1.TabIndex = 0;
            // 
            // btn_rapor
            // 
            btn_rapor.FlatAppearance.BorderColor = Color.IndianRed;
            btn_rapor.FlatStyle = FlatStyle.Flat;
            btn_rapor.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_rapor.ImageAlign = ContentAlignment.TopCenter;
            btn_rapor.ImageKey = "icons8-document-100.png";
            btn_rapor.ImageList = ımageList1;
            btn_rapor.Location = new Point(0, 639);
            btn_rapor.Name = "btn_rapor";
            btn_rapor.Size = new Size(155, 76);
            btn_rapor.TabIndex = 1;
            btn_rapor.Text = "Rapor";
            btn_rapor.TextAlign = ContentAlignment.BottomCenter;
            btn_rapor.UseVisualStyleBackColor = true;
            btn_rapor.Click += btn_rapor_Click;
            // 
            // btn_personel
            // 
            btn_personel.FlatAppearance.BorderColor = Color.IndianRed;
            btn_personel.FlatStyle = FlatStyle.Flat;
            btn_personel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_personel.ImageAlign = ContentAlignment.TopCenter;
            btn_personel.ImageKey = "icons8-waiter-100.png";
            btn_personel.ImageList = ımageList1;
            btn_personel.Location = new Point(0, 377);
            btn_personel.Name = "btn_personel";
            btn_personel.Size = new Size(155, 76);
            btn_personel.TabIndex = 0;
            btn_personel.Text = "Personel";
            btn_personel.TextAlign = ContentAlignment.BottomCenter;
            btn_personel.UseVisualStyleBackColor = true;
            btn_personel.Click += btn_personel_Click;
            // 
            // btn_mutfak
            // 
            btn_mutfak.FlatAppearance.BorderColor = Color.IndianRed;
            btn_mutfak.FlatStyle = FlatStyle.Flat;
            btn_mutfak.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_mutfak.ImageAlign = ContentAlignment.TopCenter;
            btn_mutfak.ImageKey = "icons8-chef-hat-100.png";
            btn_mutfak.ImageList = ımageList1;
            btn_mutfak.Location = new Point(0, 503);
            btn_mutfak.Name = "btn_mutfak";
            btn_mutfak.Size = new Size(155, 76);
            btn_mutfak.TabIndex = 0;
            btn_mutfak.Text = "Mutfak";
            btn_mutfak.TextAlign = ContentAlignment.BottomCenter;
            btn_mutfak.UseVisualStyleBackColor = true;
            btn_mutfak.Click += btn_mutfak_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.IndianRed;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(42, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label_restoran
            // 
            label_restoran.AutoSize = true;
            label_restoran.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label_restoran.Location = new Point(0, 62);
            label_restoran.Name = "label_restoran";
            label_restoran.Size = new Size(155, 20);
            label_restoran.TabIndex = 7;
            label_restoran.Text = "Restoran Otomasyonu";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btn_cikis);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(155, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(917, 85);
            panel2.TabIndex = 1;
            // 
            // btn_cikis
            // 
            btn_cikis.BackColor = Color.Transparent;
            btn_cikis.FlatAppearance.BorderColor = Color.White;
            btn_cikis.FlatStyle = FlatStyle.Flat;
            btn_cikis.ImageKey = "icons8-wrong-100.png";
            btn_cikis.ImageList = ımageList1;
            btn_cikis.Location = new Point(850, 0);
            btn_cikis.Name = "btn_cikis";
            btn_cikis.Size = new Size(55, 85);
            btn_cikis.TabIndex = 1;
            btn_cikis.UseVisualStyleBackColor = false;
            btn_cikis.Click += btn_cikis_Click;
            // 
            // panel_form
            // 
            panel_form.Controls.Add(pictureBox2);
            panel_form.Dock = DockStyle.Fill;
            panel_form.Location = new Point(155, 85);
            panel_form.Name = "panel_form";
            panel_form.Size = new Size(917, 730);
            panel_form.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources._1509480;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(917, 730);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Ana_Sayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 815);
            Controls.Add(panel_form);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ana_Sayfa";
            Text = "Ana_Sayfa";
            Load += Ana_Sayfa_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel_form.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ImageList ımageList1;
        private Label label_restoran;
        private PictureBox pictureBox1;
        private Button btn_cikis;
        private Button btn_masa;
        private Button btn_personel;
        private Button btn_rapor;
        private Button btn_mutfak;
        private Panel panel_form;
        private PictureBox pictureBox2;
    }
}