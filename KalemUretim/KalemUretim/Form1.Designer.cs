
namespace KalemUretim
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Drawing.Printing.PrintDocument printDocument1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.pctsil = new System.Windows.Forms.PictureBox();
            this.pctguncelle = new System.Windows.Forms.PictureBox();
            this.pctkaydet = new System.Windows.Forms.PictureBox();
            this.pctexcel = new System.Windows.Forms.PictureBox();
            this.txtadi = new System.Windows.Forms.TextBox();
            this.txtmiktar = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uretim_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uretilen_miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pctsil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctguncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctkaydet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctexcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(215, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 35);
            this.button1.TabIndex = 136;
            this.button1.Text = "Verileri Getir";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(611, 457);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(40, 20);
            this.txtid.TabIndex = 135;
            // 
            // pctsil
            // 
            this.pctsil.Image = ((System.Drawing.Image)(resources.GetObject("pctsil.Image")));
            this.pctsil.Location = new System.Drawing.Point(103, 147);
            this.pctsil.Name = "pctsil";
            this.pctsil.Size = new System.Drawing.Size(49, 35);
            this.pctsil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctsil.TabIndex = 134;
            this.pctsil.TabStop = false;
            this.pctsil.Click += new System.EventHandler(this.pctsil_Click);
            // 
            // pctguncelle
            // 
            this.pctguncelle.Image = ((System.Drawing.Image)(resources.GetObject("pctguncelle.Image")));
            this.pctguncelle.Location = new System.Drawing.Point(50, 147);
            this.pctguncelle.Name = "pctguncelle";
            this.pctguncelle.Size = new System.Drawing.Size(45, 35);
            this.pctguncelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctguncelle.TabIndex = 131;
            this.pctguncelle.TabStop = false;
            this.pctguncelle.Click += new System.EventHandler(this.pctguncelle_Click);
            // 
            // pctkaydet
            // 
            this.pctkaydet.Image = ((System.Drawing.Image)(resources.GetObject("pctkaydet.Image")));
            this.pctkaydet.Location = new System.Drawing.Point(12, 147);
            this.pctkaydet.Name = "pctkaydet";
            this.pctkaydet.Size = new System.Drawing.Size(31, 35);
            this.pctkaydet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctkaydet.TabIndex = 133;
            this.pctkaydet.TabStop = false;
            this.pctkaydet.Click += new System.EventHandler(this.pctkaydet_Click);
            // 
            // pctexcel
            // 
            this.pctexcel.Image = ((System.Drawing.Image)(resources.GetObject("pctexcel.Image")));
            this.pctexcel.Location = new System.Drawing.Point(157, 147);
            this.pctexcel.Name = "pctexcel";
            this.pctexcel.Size = new System.Drawing.Size(50, 35);
            this.pctexcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctexcel.TabIndex = 132;
            this.pctexcel.TabStop = false;
            this.pctexcel.Click += new System.EventHandler(this.pctexcel_Click);
            // 
            // txtadi
            // 
            this.txtadi.Location = new System.Drawing.Point(18, 98);
            this.txtadi.Name = "txtadi";
            this.txtadi.Size = new System.Drawing.Size(100, 20);
            this.txtadi.TabIndex = 127;
            // 
            // txtmiktar
            // 
            this.txtmiktar.Location = new System.Drawing.Point(143, 101);
            this.txtmiktar.Name = "txtmiktar";
            this.txtmiktar.Size = new System.Drawing.Size(133, 20);
            this.txtmiktar.TabIndex = 125;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(99, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(94, 20);
            this.dateTimePicker1.TabIndex = 124;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 120;
            this.label3.Text = "Ürün Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(139, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 118;
            this.label1.Text = "Üretilen Miktar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(99, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 19);
            this.label5.TabIndex = 117;
            this.label5.Text = "Tarih";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uretim_tarihi,
            this.uretilen_miktar,
            this.urun_adi,
            this.id});
            this.dataGridView1.Location = new System.Drawing.Point(300, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(429, 424);
            this.dataGridView1.TabIndex = 137;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // uretim_tarihi
            // 
            this.uretim_tarihi.DataPropertyName = "uretim_tarihi";
            this.uretim_tarihi.HeaderText = "Tarih";
            this.uretim_tarihi.Name = "uretim_tarihi";
            // 
            // uretilen_miktar
            // 
            this.uretilen_miktar.DataPropertyName = "uretilen_miktar";
            this.uretilen_miktar.HeaderText = "Üretilen Miktar";
            this.uretilen_miktar.Name = "uretilen_miktar";
            // 
            // urun_adi
            // 
            this.urun_adi.DataPropertyName = "urun_adi";
            this.urun_adi.HeaderText = "Ürun Adı";
            this.urun_adi.Name = "urun_adi";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // txtToplam
            // 
            this.txtToplam.Enabled = false;
            this.txtToplam.Location = new System.Drawing.Point(410, 462);
            this.txtToplam.Multiline = true;
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.Size = new System.Drawing.Size(133, 20);
            this.txtToplam.TabIndex = 138;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(416, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 19);
            this.label8.TabIndex = 140;
            this.label8.Text = "Toplam Üretim";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(11, 209);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(94, 20);
            this.dateTimePicker2.TabIndex = 141;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(119, 209);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(94, 20);
            this.dateTimePicker3.TabIndex = 142;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(219, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 23);
            this.button2.TabIndex = 143;
            this.button2.Text = "Ara";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(607, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 19);
            this.label4.TabIndex = 144;
            this.label4.Text = "ID";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(729, 494);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtToplam);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.pctsil);
            this.Controls.Add(this.pctguncelle);
            this.Controls.Add(this.pctkaydet);
            this.Controls.Add(this.pctexcel);
            this.Controls.Add(this.txtadi);
            this.Controls.Add(this.txtmiktar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.Text = "Kalem Uretim";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctsil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctguncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctkaydet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctexcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.PictureBox pctsil;
        private System.Windows.Forms.PictureBox pctguncelle;
        private System.Windows.Forms.PictureBox pctkaydet;
        private System.Windows.Forms.PictureBox pctexcel;
        private System.Windows.Forms.TextBox txtadi;
        private System.Windows.Forms.TextBox txtmiktar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtToplam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn uretim_tarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn uretilen_miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

