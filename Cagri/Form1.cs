using Cagri.Gorunum;
using Cagri.Model;
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


namespace Cagri
{
    public partial class Form1 : Form
    {
        public static Musteri aktifMusteri;
        public Form1()
        {
            InitializeComponent();
            Width = 1600; Height = 700;
            aktifMusteri = new Musteri();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var frmMusteri = new MusteriFormu();
            frmMusteri.MdiParent = this;
            frmMusteri.Left = 4; frmMusteri.Top = 32;
            frmMusteri.Show();

            var frmSekreter = new SekreterFormu();
            frmSekreter.MdiParent = this;
            frmSekreter.Location = new Point(Width - frmSekreter.Width - 16, 32);
            frmSekreter.Show();

            var temsilciler = Temsilci.Listele();


            var frmTemsilci0 = new MusteriTemsilcisiFormu(1);
            frmTemsilci0.Text = temsilciler[0].ToString();
            frmTemsilci0.MdiParent = this;
            frmTemsilci0.Left = 4; frmTemsilci0.Top = frmSekreter.Height + 40;
            frmTemsilci0.Show();

            var frmTemsilci1 = new MusteriTemsilcisiFormu(2);
            frmTemsilci1.Text = temsilciler[1].ToString();
            frmTemsilci1.MdiParent = this;
            frmTemsilci1.Left = 8+frmTemsilci0.Width; frmTemsilci1.Top = frmSekreter.Height + 40;
            frmTemsilci1.Show();

            var frmTemsilci2 = new MusteriTemsilcisiFormu(3);
            frmTemsilci2.Text = temsilciler[2].ToString();
            frmTemsilci2.MdiParent = this;
            frmTemsilci2.Left = 12 + 2*frmTemsilci0.Width; frmTemsilci2.Top = frmSekreter.Height + 40;
            frmTemsilci2.Show();

            var frmTemsilci3 = new MusteriTemsilcisiFormu(4);
            frmTemsilci3.Text=temsilciler[3].ToString();
            frmTemsilci3.MdiParent = this;
            frmTemsilci3.Left = 16 + 3 * frmTemsilci0.Width; frmTemsilci3.Top = frmSekreter.Height + 40;
            frmTemsilci3.Show();
            this.LayoutMdi ( MdiLayout.TileVertical);
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmMusteri = new MusteriFormu();
            frmMusteri.MdiParent = this;
            frmMusteri.Left = 4; frmMusteri.Top = 32;
            frmMusteri.Show();
        }
    }
}
