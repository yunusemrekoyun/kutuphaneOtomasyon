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

namespace KutuphaneOtomasyonu1
{
    public partial class UyeEklemeForm : Form
    {

        
        public UyeEklemeForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=KADIR\\SQLEXPRESS01;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");
        private void İptalBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into UyeTablosu(Tc,AdSoyad,Yas,Cinsiyet,Telefon,Adres,Email,OkunanKitapSayisi)values(@Tc,@AdSoyad,@Yas,@Cinsiyet,@Telefon,@Adres,@Email,@OkunanKitapSayisi) ", baglanti);
            komut.Parameters.AddWithValue("@Tc", TCText.Text);
            komut.Parameters.AddWithValue("@AdSoyad", AdSoyadText.Text);
            komut.Parameters.AddWithValue("@Yas", YasText.Text);
            komut.Parameters.AddWithValue("@Cinsiyet", CinsiyetCombo.Text);
            komut.Parameters.AddWithValue("@Telefon", TelefonText.Text);
            komut.Parameters.AddWithValue("@Adres", AdresText.Text);
            komut.Parameters.AddWithValue("@Email", EmailText.Text);
            komut.Parameters.AddWithValue("@OkunanKitapSayisi", OkunanKitapSayisiText.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Üye Kaydı Başarıyla Oluşturuldu");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    if (item!=OkunanKitapSayisiText)
                    {
                        item.Text = "";
                    }
                   
                }
            }
        }

        private void UyeEklemeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
