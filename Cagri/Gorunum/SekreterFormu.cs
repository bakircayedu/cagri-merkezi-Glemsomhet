using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cagri.Model;

namespace Cagri.Gorunum
{
    public partial class SekreterFormu : Form
    {
        public SekreterFormu()
        {
            InitializeComponent();
            tmrSekreter.Start();
        }

        private void tmrSekreter_Tick(object sender, EventArgs e)
        {
            if(Global.Bekleyen.Sayi != lstBekleyen.Items.Count)
            {
                lstBekleyen.Items.Clear();
                var cagrilar = Global.Bekleyen.TumunuAl();
                var musteriler = Global.Musteriler.TumunuAl();


                foreach (CagriKaydi item in cagrilar)
                {
                    int yer = Global.Musteriler.Bul(new Musteri { Id = item.MusteriId });
                    lstBekleyen.Items.Add(Global.Musteriler[yer].ToString());
                }
                txtSiradaki.Text = lstBekleyen.Items[0].ToString();
            }
        }

        private void SekreterFormu_Load(object sender, EventArgs e)
        {
            var liste = Temsilci.Listele();
            foreach(var item in liste)
                lstTemsilci.Items.Add(item);
        }

        private void btnKuyruk_Click(object sender, EventArgs e)
        {
            if (txtSiradaki.Text=="" || lstTemsilci.SelectedIndex < 0)
                MessageBox.Show("Lütfen bekleyen müşteriyi ve müşteri temsilcisini seçiniz.",
                    "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                CagriKaydi cagri = (CagriKaydi)Global.Bekleyen.DeQueue(); 
                cagri.TemsilciId = lstTemsilci.SelectedIndex+1;
                cagri.AtamaZaman = DateTime.Now;
                lstBekleyen.Items.RemoveAt(0);
                txtSiradaki.Text = "";
                switch (lstTemsilci.SelectedIndex)
                {
                    case 0: Global.kuyrukBireysel1.EnQueue(cagri); break;
                    case 1: Global.kuyrukBireysel2.EnQueue(cagri); break;
                    case 2: Global.kuyrukTicari1.EnQueue(cagri); break;
                    case 3: Global.kuyrukTicari2.EnQueue(cagri); break;
                }
            }

        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            if (txtSiradaki.Text == "" || lstTemsilci.SelectedIndex < 0)
                MessageBox.Show("Lütfen bekleyen müşteriyi ve müşteri temsilcisini seçiniz.",
                    "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                CagriKaydi cagri = (CagriKaydi)Global.Bekleyen.DeQueue();
                cagri.TemsilciId = lstTemsilci.SelectedIndex + 1;
                cagri.AtamaZaman = DateTime.Now;
                lstBekleyen.Items.RemoveAt(0);
                txtSiradaki.Text = "";
                switch (lstTemsilci.SelectedIndex)
                {
                    case 0: Global.kuyrukBireysel1.OneEkle(cagri); break;
                    case 1: Global.kuyrukBireysel2.OneEkle(cagri); break;
                    case 2: Global.kuyrukTicari1.OneEkle(cagri); break;
                    case 3: Global.kuyrukTicari2.OneEkle(cagri); break;
                }
            }
        }
    }
}
