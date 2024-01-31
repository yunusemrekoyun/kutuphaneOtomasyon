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
    public partial class KitapEkleForm : Form
    {
        public KitapEkleForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=KADIR\\SQLEXPRESS01;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");
        private void KitapEkleForm_Load(object sender, EventArgs e)
        {

        }

        private void KitapEkleBtnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KitapEkleBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Kitap(BarkodNo,KitapAdi,Yazari,YayinEvi,SayfaSayisi,Turu,StokSayisi,RafNo,Aciklama,KayitTarihi)values(@BarkodNo,@KitapAdi,@Yazari,@YayinEvi,@SayfaSayisi,@Turu,@StokSayisi,@RafNo,@Aciklama,@KayitTarihi) ", baglanti);
            komut.Parameters.AddWithValue("@BarkodNo", KitapBarkodNumarasiText.Text);
            komut.Parameters.AddWithValue("@KitapAdi", KitapAdiText.Text);
            komut.Parameters.AddWithValue("@Yazari", YazariText.Text);
            komut.Parameters.AddWithValue("@Yayinevi", YayineviText.Text);
            komut.Parameters.AddWithValue("@SayfaSayisi", SayfaSayisiText.Text);
            komut.Parameters.AddWithValue("@Turu", TuruCombo.Text);
            komut.Parameters.AddWithValue("@StokSayisi", StokSayisiText.Text);
            komut.Parameters.AddWithValue("@RafNo", RafNumarasiText.Text);
            komut.Parameters.AddWithValue("@Aciklama", AciklamaText.Text);
            komut.Parameters.AddWithValue("@KayitTarihi", DateTime.Now.ToShortDateString());

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Kaydı Başarıyla Oluşturuldu");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    
                        item.Text = "";
                    

                }
            }
        }
    }
}
