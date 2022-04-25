using Cagri.Model;
using System;
using System.Windows.Forms;

namespace Cagri.Gorunum
{
    public partial class MusteriFormu : Form
    {
        Musteri musterim;
        CagriKaydi cagriKaydim;
        public MusteriFormu()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Lütfen müşteri tanımlayıcınızı giriniz.", "UYARI",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            tmrMusteri.Enabled = true;
            gboSira.Visible = true;

            musterim = new Musteri() { Id = Convert.ToInt32(txtId.Text), Ad = txtAd.Text };
            Global.Musteriler.EnQueue(musterim);

            Global.AramaZamani = dtpArama.Value;

            cagriKaydim = new CagriKaydi() { Id = Global.CagriSayisi, MusteriId = Convert.ToInt32(txtId.Text) };
            Global.Cagrilar.EnQueue(cagriKaydim);
            Global.Bekleyen.EnQueue(cagriKaydim);
            Global.CagriSayisi++;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tmrMusteri_Tick(object sender, EventArgs e)
        {
            dtpArama.Value = DateTime.Now;
            int yer = Global.Cagrilar.Bul(cagriKaydim);
            cagriKaydim = (CagriKaydi)Global.Cagrilar[yer];
            if (cagriKaydim.TemsilciId == 1) 
                    lblSira.Text = "" + Global.kuyrukBireysel1.Bul(musterim.Id);
            else if (cagriKaydim.TemsilciId == 2)
                lblSira.Text = "" + Global.kuyrukBireysel2.Bul(musterim.Id);
            else if (cagriKaydim.TemsilciId == 3)
                lblSira.Text = "" + Global.kuyrukTicari1.Bul(musterim.Id);
            else if (cagriKaydim.TemsilciId == 2)
                lblSira.Text = "" + Global.kuyrukTicari2.Bul(musterim.Id);
            else 
                lblSira.Text = "Bekleyin!";

            if (cagriKaydim.BitisZamani != null)
                tmrMusteri.Stop();
        }
    }
}
