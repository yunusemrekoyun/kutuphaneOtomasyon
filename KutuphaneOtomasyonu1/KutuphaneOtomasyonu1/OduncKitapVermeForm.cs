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
    public partial class OduncKitapVermeForm : Form
    {
        public OduncKitapVermeForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=KADIR\\SQLEXPRESS01;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");
        DataSet daset= new DataSet();
        string connectionString = "Data Source=KADIR\\SQLEXPRESS01;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True";

        private void KitapSayisi()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(KitapSayisi) from Sepet",baglanti);
            KitapSayisiBosLabel.Text = komut.ExecuteScalar().ToString();
        }

        private void TCText_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("SELECT * FROM UyeTablosu WHERE Tc LIKE @Tc", baglanti);
                komut.Parameters.AddWithValue("@Tc", TCText.Text);

                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    AdSoyadText.Text = read["AdSoyad"].ToString();
                    YasText.Text = read["Yas"].ToString();
                    TelefonText.Text = read["Telefon"].ToString();
                }

                baglanti.Close();
            }

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                baglanti.Open();

                SqlCommand komut2 = new SqlCommand("SELECT SUM(KitapSayisi) FROM OduncKitaplar where TC='"+TCText.Text+"'", baglanti);
                KayitliKitapSayisiBosLabel.Text = komut2.ExecuteScalar().ToString();

                baglanti.Close();
            }

            if (TCText.Text == "")
            {
                foreach (Control item in UyeBilgileriGrp.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                        
                    }
                }
                KayitliKitapSayisiBosLabel.Text = "";
            }
        }


        private void TCIleAramaLabel_Click(object sender, EventArgs e)
        {

        }

        private void İptalBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void sepetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Sepet",baglanti);
            adtr.Fill(daset, "Sepet");
            OduncKitapListeleyenDataGridView.DataSource = daset.Tables["Sepet"];  
            baglanti.Close  (); 
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void OduncKitapVermeForm_Load(object sender, EventArgs e)
        {
            sepetListele(); 
        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into sepet(BarkodNo, KitapAdi,Yazari,YayinEvi,SayfaSayisi,KitapSayisi, TeslimTarihi,IadeTarihi) values (@BarkodNo, @KitapAdi,@Yazari,@YayinEvi,@SayfaSayisi,@KitapSayisi, @TeslimTarihi,@IadeTarihi)", baglanti);
            komut.Parameters.AddWithValue("@BarkodNo", BarkodNoText.Text);
            komut.Parameters.AddWithValue("@KitapAdi", KitapAdiText.Text);
            komut.Parameters.AddWithValue("@Yazari", YazariText.Text);
            komut.Parameters.AddWithValue("@YayinEvi", YayinEviText.Text);
            komut.Parameters.AddWithValue("@SayfaSayisi", SayfaSayisiText.Text);
            komut.Parameters.AddWithValue("@KitapSayisi", KitapSayisiText.Text);
            komut.Parameters.AddWithValue("@TeslimTarihi", dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@IadeTarihi", dateTimePicker2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sepete ekleme işlemi başarıyla gerçekleşti", "Ekleme İşlemi ");
            daset.Tables["Sepet"].Clear();
            sepetListele();
            KitapSayisiBosLabel.Text = "";
            KitapSayisi();
            foreach (Control item in KitapBilgileriGrp.Controls )
            {
                if(item is TextBox)
                {
                    if (item!=KitapSayisiText) 
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void BarkodNoText_TextChanged(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand komut = new SqlCommand("select * from Kitap where BarkodNo like '" + BarkodNoText.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                KitapAdiText.Text = read["KitapAdi"].ToString();
                YazariText.Text = read["Yazari"].ToString();
                YayinEviText.Text = read["YayinEvi"].ToString();
                SayfaSayisiText.Text = read["SayfaSayisi"].ToString();
            }

            baglanti.Close();

            if (BarkodNoText.Text == "")
            {
                foreach (Control item in KitapBilgileriGrp.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != KitapSayisiText)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
        }


        private void SilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (OduncKitapListeleyenDataGridView.CurrentRow != null)
                {
                    using (SqlConnection baglanti = new SqlConnection(connectionString))
                    {
                        baglanti.Open();

                        using (SqlCommand komut = new SqlCommand("DELETE FROM Sepet WHERE BarkodNo=@BarkodNo", baglanti))
                        {
                            komut.Parameters.AddWithValue("@BarkodNo", OduncKitapListeleyenDataGridView.CurrentRow.Cells["BarkodNo"].Value.ToString());
                            komut.ExecuteNonQuery();
                        }

                        MessageBox.Show("Silme İşlemi Başarıyla Gerçekleştirildi", "Silme İşlemi");

                        daset.Tables["Sepet"].Clear();
                        sepetListele();
                        KitapSayisiBosLabel.Text = "";
                        KitapSayisi();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir satır seçiniz", "Uyarı");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Hata: " + ex.Message, "Hata");
            }

        }



        private void TeslimEtBtn_Click(object sender, EventArgs e)
        {
            if (KitapSayisiBosLabel.Text != "")
            {
                if (KayitliKitapSayisiBosLabel.Text == "" && int.Parse(KitapSayisiBosLabel.Text) <= 3 || KayitliKitapSayisiBosLabel.Text != "" && int.Parse(KayitliKitapSayisiBosLabel.Text) + int.Parse(KitapSayisiBosLabel.Text) <= 3)
                {
                    if (TCText.Text != "" && AdSoyadText.Text != "" && YasText.Text != "" && TelefonText.Text != "")
                    {
                        for (int i = 0; i < OduncKitapListeleyenDataGridView.Rows.Count - 1; i++)
                        {
                            baglanti.Open();
                            SqlCommand komut = new SqlCommand("insert into OduncKitaplar(TC,AdSoyad,Yas,Telefon,BarkodNo,KitapAdi,Yazari,YayinEvi,SayfaSayisi,KitapSayisi,TeslimTarihi,IadeTarihi) values(@TC,@AdSoyad,@Yas,@Telefon,@BarkodNo,@KitapAdi,@Yazari,@YayinEvi,@SayfaSayisi,@KitapSayisi, @TeslimTarihi,@IadeTarihi)", baglanti);
                            komut.Parameters.AddWithValue("@TC", TCText.Text);
                            komut.Parameters.AddWithValue("@AdSoyad", AdSoyadText.Text);
                            komut.Parameters.AddWithValue("@Yas", YasText.Text);
                            komut.Parameters.AddWithValue("@Telefon", TelefonText.Text);
                            komut.Parameters.AddWithValue("BarkodNo", OduncKitapListeleyenDataGridView.Rows[i].Cells["BarkodNo"].Value.ToString());
                            komut.Parameters.AddWithValue("KitapAdi", OduncKitapListeleyenDataGridView.Rows[i].Cells["KitapAdi"].Value.ToString());
                            komut.Parameters.AddWithValue("Yazari", OduncKitapListeleyenDataGridView.Rows[i].Cells["Yazari"].Value.ToString());
                            komut.Parameters.AddWithValue("YayinEvi", OduncKitapListeleyenDataGridView.Rows[i].Cells["YayinEvi"].Value.ToString());
                            komut.Parameters.AddWithValue("SayfaSayisi", OduncKitapListeleyenDataGridView.Rows[i].Cells["SayfaSayisi"].Value.ToString());
                            komut.Parameters.AddWithValue("KitapSayisi", int.Parse(OduncKitapListeleyenDataGridView.Rows[i].Cells["KitapSayisi"].Value.ToString()));
                            komut.Parameters.AddWithValue("TeslimTarihi", OduncKitapListeleyenDataGridView.Rows[i].Cells["TeslimTarihi"].Value.ToString());
                            komut.Parameters.AddWithValue("IadeTarihi", OduncKitapListeleyenDataGridView.Rows[i].Cells["IadeTarihi"].Value.ToString());
                            komut.ExecuteNonQuery();
                            SqlCommand Komut1 = new SqlCommand("update UyeTablosu set OkunanKitapSayisi= OkunanKitapSayisi+'" + int.Parse(OduncKitapListeleyenDataGridView.Rows[i].Cells["KitapSayisi"].Value.ToString()) + "'where TC='" + TCText + "'", baglanti);
                            Komut1.ExecuteNonQuery();
                            SqlCommand Komut2 = new SqlCommand("update Kitap set StokSayisi = Stoksayisi-'" + int.Parse(OduncKitapListeleyenDataGridView.Rows[i].Cells["KitapSayisi"].Value.ToString()) + "'where BarkodNo='" + OduncKitapListeleyenDataGridView.Rows[i].Cells["BarkodNo"].Value.ToString() + "'", baglanti);
                            Komut2.ExecuteNonQuery();
                            baglanti.Close();

                        }
                        baglanti.Open();
                        SqlCommand komut3 = new SqlCommand("delete from Sepet", baglanti);
                        komut3.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Ödünç Verme İşlemi Tamamlandı");
                        daset.Tables["Sepet"].Clear();
                        sepetListele();
                        TCText.Text = "";
                        KitapSayisiBosLabel.Text = "";
                        KitapSayisi();
                        KayitliKitapSayisiBosLabel.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("lütfen üye ismi seçiniz", "uyarı");
                    }
                }

                else
                {
                    MessageBox.Show("Ödünc Kitap Sayısı 3 ten fazla olamaz", "Uyarı");
                }

            }
            else
            {
                MessageBox.Show("Önce Sepete Kitap Eklemelisiniz", "Uyarı");
            }


        }
    }
}

