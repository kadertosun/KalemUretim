using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KalemUretim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VQG6M4I;Initial Catalog=Depo;Integrated Security=True");
        void VeriListele()
        {
            baglanti.Open();
            SqlDataAdapter veri = new SqlDataAdapter("select *from Kalem", baglanti);
            DataTable table = new DataTable();
            veri.Fill(table);
            dataGridView1.DataSource = table;
            baglanti.Close();
        }
        void ToplamUretilen()
        {
            baglanti.Open();
            SqlCommand doldur = new SqlCommand("select sum(uretilen_miktar) from kalem", baglanti);
            SqlDataReader data = doldur.ExecuteReader();
            while (data.Read())
            {
                txtToplam.Text = data[0].ToString();

            }

            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            VeriListele();
            ToplamUretilen();
        }

        private void pctkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand VeriKaydet = new SqlCommand("insert into kalem(uretim_tarihi,uretilen_miktar,urun_adi) values(@tarih,@miktar,@adi)", baglanti);
            VeriKaydet.Parameters.AddWithValue("@tarih", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            VeriKaydet.Parameters.AddWithValue("@miktar", txtmiktar.Text);
            VeriKaydet.Parameters.AddWithValue("@adi", txtadi.Text);
            VeriKaydet.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Veri Eklendi");


            VeriListele();

        }

        private void pctguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand VeriGuncelle = new SqlCommand("update  kalem set uretim_tarihi=@tarih,uretilen_miktar=@miktar,urun_adi=@adi where id=@Id", baglanti);
            VeriGuncelle.Parameters.AddWithValue("@tarih", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            VeriGuncelle.Parameters.AddWithValue("@miktar", txtmiktar.Text);
            VeriGuncelle.Parameters.AddWithValue("@adi", txtadi.Text);
            VeriGuncelle.Parameters.AddWithValue("@Id", txtid.Text);
            VeriGuncelle.ExecuteNonQuery();
            baglanti.Close();
            VeriListele();
            MessageBox.Show("Güncellendi");

        
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtadi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtmiktar.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
           dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void pctsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand VeriSil = new SqlCommand("Delete from Kalem where id=@Id",baglanti);
            VeriSil.Parameters.AddWithValue("@Id", txtid.Text);
            VeriSil.ExecuteNonQuery();
            baglanti.Close();
            VeriListele();
            MessageBox.Show("Veri silindi");
        }


        Font Baslik = new Font("Bahnschrift SemiBold", 20, FontStyle.Bold);

        Font Ana = new Font("Arial Black", 20, FontStyle.Bold);
        
        SolidBrush sb = new SolidBrush(Color.Black);
        Pen myPen = new Pen(Color.Black);


        private System.Drawing.Printing.PrintDocument pd;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("" + dateTimePicker1.Text, Baslik, sb, 590, 210);
            e.Graphics.DrawString("Üretim Listesi", Ana, sb, 300, 140);
            e.Graphics.DrawLine(myPen, 10, 80, 820, 80);
            e.Graphics.DrawLine(myPen, 10, 200, 820, 200);

            e.Graphics.DrawString("Ürün Adı:", Baslik, sb, 10, 280);
            e.Graphics.DrawString("" + txtadi.Text, Ana, sb, 340, 270);
            e.Graphics.DrawString("Ürünetilen Miktar:", Baslik, sb, 10, 440);
            e.Graphics.DrawString("" + txtmiktar.Text, Ana, sb, 340, 440);
        }

        private void pctexcel_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sql = "SELECT *FROM kalem WHERE uretim_tarihi Between @k1 And @k2";
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, baglanti);
            adapter.SelectCommand.Parameters.AddWithValue("@k1", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
            adapter.SelectCommand.Parameters.AddWithValue("@k2", dateTimePicker3.Value.ToString("yyyy-MM-dd"));
            adapter.Fill(table);
            baglanti.Close();
            dataGridView1.DataSource = table;
        }
    }
}
