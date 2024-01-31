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
    public partial class OduncKitapForm : Form
    {
        public OduncKitapForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=KADIR\\SQLEXPRESS01;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");
        DataSet daset = new DataSet();

        private void OduncKitapListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from OduncKitaplar", baglanti);
            adtr.Fill(daset, "OduncKitaplar");
            dataGridView1.DataSource = daset.Tables["OduncKitaplar"];
            baglanti.Close();
        }
        private void OduncKitapForm_Load(object sender, EventArgs e)
        {
OduncKitapListele();

        }

        private void IptalBtn_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void TCIleAramaText_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["OduncKitaplar"].Clear();
            
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from OduncKitaplar where TC like '%" + TCIleAramaText.Text + "%'", baglanti);
            adtr.Fill(daset,"OduncKitaplar");
            baglanti.Close();
            if (TCIleAramaText.Text=="")
            {
                daset.Tables["OduncKitaplar"].Clear();
                OduncKitapListele();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["OduncKitaplar"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from OduncKitaplar where BarkodNo like '%" + textBox2.Text + "%'", baglanti);
            adtr.Fill(daset, "OduncKitaplar");
            baglanti.Close();
            if (textBox2.Text == "")
            {
                daset.Tables["OduncKitaplar"].Clear();
                OduncKitapListele();
            }
        }

        private void TeslimAlBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from OduncKitaplar where TC = @TC and BarkodNo= @BarkodNo", baglanti);
            komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["TC"].Value.ToString());
            komut.Parameters.AddWithValue("@BarkodNo", dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString());
            komut.ExecuteNonQuery();
            SqlCommand komut1 = new SqlCommand("update Kitap set StokSayisi= StokSayisi+'" + dataGridView1.CurrentRow.Cells["KitapSayisi"].Value.ToString() +"'where BarkodNo= @BarkodNo", baglanti);
            komut1.Parameters.AddWithValue("@BarkodNo", dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString());
            komut1.ExecuteNonQuery();
            baglanti.Close() ;
            MessageBox.Show("İade İşlemi Başarıyla Gerçekleşti");

            daset.Tables["OduncKitaplar"].Clear();
            OduncKitapListele();
        }
    }
}
