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
    public partial class OduncKitapListelemeForm : Form
    {
        public OduncKitapListelemeForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=KADIR\\SQLEXPRESS01;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");
        DataSet daset = new DataSet();
        private void OduncKitapListelemeForm_Load(object sender, EventArgs e)
        {
            OduncKitapListele();
            comboBox1.SelectedIndex = 0;    
        }

        private void OduncKitapListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from OduncKitaplar", baglanti);
            adtr.Fill(daset, "OduncKitaplar");
            dataGridView1.DataSource = daset.Tables["OduncKitaplar"];
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            daset.Tables["OduncKitaplar"].Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                OduncKitapListele();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select * from OduncKitaplar where '"+DateTime.Now.ToShortDateString()+"'> IadeTarihi", baglanti);
                adtr.Fill(daset, "OduncKitaplar");
                dataGridView1.DataSource = daset.Tables["OduncKitaplar"];
                baglanti.Close();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select * from OduncKitaplar where '" + DateTime.Now.ToShortDateString() + "'<=IadeTarihi", baglanti);
                adtr.Fill(daset, "OduncKitaplar");
                dataGridView1.DataSource = daset.Tables["OduncKitaplar"];
                baglanti.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
