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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace KutuphaneOtomasyonu1
{
    public partial class KitapListelemeForm : Form
    {
        public KitapListelemeForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=KADIR\\SQLEXPRESS01;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");
        DataSet daset = new DataSet();

        private void KitapListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Kitap", baglanti);
            adtr.Fill(daset, "Kitap");
            KitapListeleyenGrid.DataSource = daset.Tables["Kitap"];
            baglanti.Close();
        }
        private void KitapListelemeForm_Load(object sender, EventArgs e)
        {
            KitapListele();

        }

        private void KitapSilBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Kitap where BarkodNo=@BarkodNo", baglanti);
            komut.Parameters.AddWithValue("@BarkodNo", KitapListeleyenGrid.CurrentRow.Cells["BarkodNo"].Value.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme İşlemi Başarıyla Gerçekleşti");
            daset.Tables["Kitap"].Clear();
            KitapListele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void KitapGuncelleBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Kitap set KitapAdi=@KitapAdi,Yazari=@Yazari,YayinEvi=@YayinEvi,SayfaSayisi=@SayfaSayisi,Turu=@Turu,StokSayisi=@StokSayisi,RafNo=@RafNo,Aciklama=@Aciklama where BarkodNo=@BarkodNo ", baglanti);
            komut.Parameters.AddWithValue("@BarkodNo", KitapBarkodNumarasiText.Text);
            komut.Parameters.AddWithValue("@KitapAdi", KitapAdiText.Text);
            komut.Parameters.AddWithValue("@Yazari", YazariText.Text);
            komut.Parameters.AddWithValue("@YayinEvi", YayineviText.Text);
            komut.Parameters.AddWithValue("@SayfaSayisi", SayfaSayisiText.Text);
            komut.Parameters.AddWithValue("@Turu", TuruCombo.Text);
            komut.Parameters.AddWithValue("@StokSayisi", StokSayisiText.Text);
            komut.Parameters.AddWithValue("@RafNo", RafNumarasiText.Text);
            komut.Parameters.AddWithValue("@Aciklama", AciklamaText.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşti");
            daset.Tables["Kitap"].Clear();
            KitapListele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void KitapBarkodNumarasiIleAramaText_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["Kitap"].Clear();
            baglanti.Open();
            SqlDataAdapter komut = new SqlDataAdapter("select *from Kitap where BarkodNo like '%" + KitapBarkodNumarasiIleAramaText.Text + "%'", baglanti);
            komut.Fill(daset, "Kitap");
            KitapListeleyenGrid.DataSource = daset.Tables["Kitap"];
            baglanti.Close();
        }

        private void KitapBarkodNumarasiText_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Kitap where BarkodNo like '" + KitapBarkodNumarasiText.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                KitapAdiText.Text = read["KitapAdi"].ToString();
                YazariText.Text = read["Yazari"].ToString();
                YayineviText.Text = read["YayinEvi"].ToString();
                SayfaSayisiText.Text = read["SayfaSayisi"].ToString();
                TuruCombo.Text = read["Turu"].ToString();
                StokSayisiText.Text = read["StokSayisi"].ToString();
                RafNumarasiText.Text = read["RafNo"].ToString();
                AciklamaText.Text = read["Aciklama"].ToString();



            }
            baglanti.Close();
        }

        private void KitapEkleBtnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
