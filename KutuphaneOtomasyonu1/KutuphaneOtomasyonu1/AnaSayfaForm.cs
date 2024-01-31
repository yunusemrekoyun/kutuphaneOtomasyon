using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu1
{
    public partial class AnaSayfaForm : Form
    {
        public AnaSayfaForm()
        {
            InitializeComponent();
        }
       
        private void AnaSayfaForm_Load(object sender, EventArgs e)
        {

        }

        private void UyeEkleBtn_Click(object sender, EventArgs e)
        {
            UyeEklemeForm uyeekle = new UyeEklemeForm();
            uyeekle.ShowDialog();
        }

        private void UyeListeleBtn_Click(object sender, EventArgs e)
        {
            UyeListelemeForm uyeListeleme = new UyeListelemeForm(); 
            uyeListeleme.ShowDialog();  
        }

        private void KitapEklemeBtn_Click(object sender, EventArgs e)
        {
            KitapEkleForm kitapEkle = new KitapEkleForm();
            kitapEkle.ShowDialog();
        }

        private void KitapListeleBtn_Click(object sender, EventArgs e)
        {
            KitapListelemeForm kitapListelemeForm = new KitapListelemeForm();
            kitapListelemeForm.ShowDialog();
        }

        private void OduncKitapVerBtn_Click(object sender, EventArgs e)
        {
            OduncKitapVermeForm oduncKitapVermeForm = new OduncKitapVermeForm();
            oduncKitapVermeForm.ShowDialog();
        }

        private void OduncKitapListeleBtn_Click(object sender, EventArgs e)
        {
            OduncKitapListelemeForm listele = new OduncKitapListelemeForm();
            listele.ShowDialog();   
        }

        private void OduncKitapIadeBtn_Click(object sender, EventArgs e)
        {
            OduncKitapForm oduncKitapForm = new OduncKitapForm();
            oduncKitapForm.ShowDialog();
        }

        private void SıralamaBtn_Click(object sender, EventArgs e)
        {

        }

        private void CikisBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
