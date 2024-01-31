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

namespace KutuphaneOtomasyonu1
{
    public partial class UyeListelemeForm : Form
    {
        public UyeListelemeForm()
        {
            InitializeComponent();
        }

        private void TcAramaLabel_Click(object sender, EventArgs e)
        {
            TCText.Text = UyeListeleyenGrid.CurrentRow.Cells["tc"].Value.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection("Data Source=KADIR\\SQLEXPRESS01;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");
        private void TCText_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from UyeTablosu where Tc like '"+TCText.Text+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read()) 
            {
                AdSoyadText.Text = read["AdSoyad"].ToString();
                YasText.Text = read["Yas"].ToString();
               CinsiyetCombo.Text = read["Cinsiyet"].ToString();
                TelefonText.Text = read["Telefon"].ToString();
                AdresText.Text = read["Adres"].ToString();
                EmailText.Text = read["Email"].ToString();
                OkunanKitapSayisiText.Text = read["OkunanKitapSayisi"].ToString();
                
                

            }
            baglanti.Close();
        }
        DataSet daset = new DataSet();
        private void TCAraText_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["UyeTablosu"].Clear();
            baglanti.Open();
            SqlDataAdapter komut = new SqlDataAdapter("select *from UyeTablosu where Tc like '%" + TCAraText.Text + "%'",baglanti);
            komut.Fill(daset,"UyeTablosu");
            UyeListeleyenGrid.DataSource = daset.Tables["UyeTablosu"];
            baglanti.Close();
        }

        private void İptalBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void uyeListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from UyeTablosu", baglanti);
            adtr.Fill(daset, "UyeTablosu");
            UyeListeleyenGrid.DataSource = daset.Tables["UyeTablosu"];
            baglanti.Close();
        }

        private void SilBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from UyeTablosu where Tc=@Tc",baglanti);
            komut.Parameters.AddWithValue("@Tc", UyeListeleyenGrid.CurrentRow.Cells["Tc"].Value.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close() ;
            MessageBox.Show("Silme İşlemi Başarıyla Gerçekleşti");
            daset.Tables["UyeTablosu"].Clear();
            uyeListele();
            foreach(Control item in Controls)
            {
                if(item is TextBox) 
                {
                    item.Text = "";                
                }
            }
        }

        private void GuncelleBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open() ;
            SqlCommand komut = new SqlCommand("update UyeTablosu set AdSoyad=@AdSoyad, Yas=@Yas, Cinsiyet=@Cinsiyet, Telefon=@Telefon,Adres=@Adres,Email=@Email,OkunanKitapSayisi=@OkunanKitapSayisi where Tc=@Tc ", baglanti);
            komut.Parameters.AddWithValue("@tc", TCText.Text);
            komut.Parameters.AddWithValue("@AdSoyad", AdSoyadText.Text);
            komut.Parameters.AddWithValue("@Yas", YasText.Text);
            komut.Parameters.AddWithValue("@Cinsiyet", CinsiyetCombo.Text);
            komut.Parameters.AddWithValue("@Telefon",TelefonText.Text);
            komut.Parameters.AddWithValue("@Adres", AdresText.Text);
            komut.Parameters.AddWithValue("@Email", EmailText.Text);
            komut.Parameters.AddWithValue("@OkunanKitapSayisi", int.Parse(OkunanKitapSayisiText.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşti");
            daset.Tables["UyeTablosu"].Clear();
            uyeListele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }


        private void UyeListelemeForm_Load(object sender, EventArgs e)
        {
                uyeListele();
        }
    }
}
