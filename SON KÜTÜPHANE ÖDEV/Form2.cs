using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SON_KÜTÜPHANE_ÖDEV
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-7E68D839\\SQLEXPRESS;Initial Catalog=KitapFormu;Integrated Security=True");
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kitapFormuDataSet.Tbl_KitapFormu' table. You can move, or remove it, as needed.
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.tbl_KitapFormuTableAdapter.Fill(this.kitapFormuDataSet.Tbl_KitapFormu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_KitapFormu (kitapAdi, kitapTuru, yayinEvi, verilisTarihi, uyeAdi, alinisTarihi) values (@e1, @e2, @e3, @e4, @e5, @e6)", baglanti);
            komut.Parameters.AddWithValue("@e1", kitapAdi.Text);
            komut.Parameters.AddWithValue("@e2", kitapTuru.Text);
            komut.Parameters.AddWithValue("@e3", yayinEvi.Text);
            komut.Parameters.AddWithValue("@e4", verilisTarihi.Text);
            komut.Parameters.AddWithValue("@e5", uyeAdi.Text);
            komut.Parameters.AddWithValue("@e6", alinisTarihi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaydınız başarıyla gerçekleşti.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_KitapFormu where kitapAdi=@s1", baglanti);
            komutsil.Parameters.AddWithValue("@s1", kitapAdi.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaydınız silindi.");
        }
    }
}
