namespace Restoran
{
    partial class HesapOdemeleriForm
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
            dataGridView1 = new DataGridView();
            ID = new DataGridViewButtonColumn();
            ADISYONID = new DataGridViewTextBoxColumn();
            ODEMETURID = new DataGridViewTextBoxColumn();
            ARATOPLAM = new DataGridViewTextBoxColumn();
            KDVTUTARI = new DataGridViewTextBoxColumn();
            INDIRIM = new DataGridViewTextBoxColumn();
            TOPLAMTUTAR = new DataGridViewTextBoxColumn();
            TARIH = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.IndianRed;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, ADISYONID, ODEMETURID, ARATOPLAM, KDVTUTARI, INDIRIM, TOPLAMTUTAR, TARIH });
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(-1, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(918, 740);
            dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // ADISYONID
            // 
            ADISYONID.HeaderText = "ADISYONID";
            ADISYONID.Name = "ADISYONID";
            // 
            // ODEMETURID
            // 
            ODEMETURID.HeaderText = "ODEMETURID";
            ODEMETURID.Name = "ODEMETURID";
            // 
            // ARATOPLAM
            // 
            ARATOPLAM.HeaderText = "ARATOPLAM";
            ARATOPLAM.Name = "ARATOPLAM";
            // 
            // KDVTUTARI
            // 
            KDVTUTARI.HeaderText = "KDVTUTARI";
            KDVTUTARI.Name = "KDVTUTARI";
            // 
            // INDIRIM
            // 
            INDIRIM.HeaderText = "INDIRIM";
            INDIRIM.Name = "INDIRIM";
            // 
            // TOPLAMTUTAR
            // 
            TOPLAMTUTAR.HeaderText = "TOPLAMTUTAR";
            TOPLAMTUTAR.Name = "TOPLAMTUTAR";
            // 
            // TARIH
            // 
            TARIH.FillWeight = 120F;
            TARIH.HeaderText = "TARIH";
            TARIH.Name = "TARIH";
            TARIH.Width = 120;
            // 
            // HesapOdemeleriForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 741);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HesapOdemeleriForm";
            Text = "HesapOdemeleriForm";
            Load += HesapOdemeleriForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewButtonColumn ID;
        private DataGridViewTextBoxColumn ADISYONID;
        private DataGridViewTextBoxColumn ODEMETURID;
        private DataGridViewTextBoxColumn ARATOPLAM;
        private DataGridViewTextBoxColumn KDVTUTARI;
        private DataGridViewTextBoxColumn INDIRIM;
        private DataGridViewTextBoxColumn TOPLAMTUTAR;
        private DataGridViewTextBoxColumn TARIH;
    }
}