using Cagri.Koleksiyon;
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
    public partial class MusteriTemsilcisiFormu : Form
    {
        int Idim;
        Kuyruk kuyrugum = new Kuyruk(20);
        CagriKaydi siradaki;
        public MusteriTemsilcisiFormu(int id)
        {
            InitializeComponent();
            Idim = id;
        }

        private void tmrTemsilci_Tick(object sender, EventArgs e)
        {
            if (kuyrugum.Sayi <= 0) return;
            if(kuyrugum.Sayi != lstCagrilar.Items.Count)
            {
                lstCagrilar.Items.Clear();
                var musteriler = Global.Musteriler.TumunuAl();
                for(int i = 0; i < kuyrugum.Sayi; i++)
                {
                    CagriKaydi item = (CagriKaydi) kuyrugum[i];
                    int yer = Global.Musteriler.Bul(new Musteri { Id = item.MusteriId });
                    lstCagrilar.Items.Add(Global.Musteriler[yer].ToString());
                }
            }
        }

        private void MusteriTemsilcisiFormu_Load(object sender, EventArgs e)
        {
            switch (Idim)
            {
                case 1: kuyrugum = Global.kuyrukBireysel1; break;
                case 2: kuyrugum = Global.kuyrukBireysel2; break;
                case 3: kuyrugum = Global.kuyrukTicari1; break;
                case 4: kuyrugum = Global.kuyrukTicari2; break;
                default: kuyrugum = null; break;
            }
            tmrTemsilci.Start();
        }

        private void btnGorus_Click(object sender, EventArgs e)
        {
            siradaki = (CagriKaydi)kuyrugum.Peek();
            txtSiradaki.Text = lstCagrilar.Items[0].ToString();
            siradaki.BaslamaZamani = DateTime.Now;
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            siradaki.BitisZamani = DateTime.Now;
            lstCagrilar.Items.Remove(txtSiradaki.Text);
            kuyrugum.DeQueue();
            txtSiradaki.Text = "";
        }
    }
}
