using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TCDD TCDDOtomasyon = new TCDD();

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMKaydet_Click(object sender, EventArgs e)
        {
            Musteri m = new Musteri();
            m.Ad = txtAd.Text;
            m.Soyad = txtSoyad.Text;
            m.TcNo = txtTcNo.Text;
            m.Iletisim.Adres = txtAdres.Text;
            m.Iletisim.Email = txtEmail.Text;
            m.Iletisim.Telefon = txtTel.Text;

            TCDDOtomasyon.MusteriEkle(m);

            MusteriListele();
        }

        public void MusteriListele()
        {
            listBoxMusteri1.Items.Clear();
            listBoxMusteri2.Items.Clear();

            foreach(var m in TCDDOtomasyon.MusteriListesi)
            {
                listBoxMusteri1.Items.Add(m.Ad+" "+m.Soyad);
                listBoxMusteri2.Items.Add(m.Ad + " " + m.Soyad);
            }
        }
        public void SeferListele()
        {
            listBoxSefer.Items.Clear();
            listBoxSefer2.Items.Clear();

            foreach (var s in TCDDOtomasyon.SeferListesi)
            {
                listBoxSefer.Items.Add(s.KalkısYeri+ " " + s.VarısYeri);
                listBoxSefer2.Items.Add(s.KalkısYeri + " " + s.VarısYeri);
            }
        }
        public void RezListele()
        {
            listBoxRez.Items.Clear();
            listBoxRez2.Items.Clear();

            foreach (var r in TCDDOtomasyon.RezervasyonListesi)
            {
                listBoxRez.Items.Add(r.müsteri.Ad + " " + r.müsteri.Soyad +" "+r.sefer.Kalkıs+" "+r.sefer.KalkısYeri);
                listBoxRez2.Items.Add(r.müsteri.Ad + " " + r.müsteri.Soyad + " " + r.sefer.Kalkıs + " " + r.sefer.KalkısYeri);
            }
        }
        public void BiletListele()
        {
            listBoxBilet.Items.Clear();

            foreach (var b in TCDDOtomasyon.BiletListesi)
                listBoxBilet.Items.Add(b.rezervasyon.müsteri.Ad + " " + b.rezervasyon.müsteri.Soyad +" "+b.rezervasyon.sefer.KalkısYeri+" "+b.Ucret+"₺");
     
        }

        private void btnSKaydet_Click(object sender, EventArgs e)
        {
            Sefer s = new Sefer();
            s.KalkısYeri = txtKalkisYeri.Text;
            s.Kalkıs = DateTime.Parse( dtKalkis.Value.ToShortDateString()+" "+txtKalkisSaati.Text);
            s.VarısYeri = txtVarisYeri.Text;
            s.Varıs =DateTime.Parse( dtVaris.Value.ToShortDateString()+" "+txtVarisSaati.Text);
            s.Ucret = double.Parse(txtUcret.Text);

            TCDDOtomasyon.SeferEkle(s);

            SeferListele();
            
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            Musteri m = TCDDOtomasyon.MusteriListesi[listBoxMusteri2.SelectedIndex];
            Sefer s = TCDDOtomasyon.SeferListesi[listBoxSefer2.SelectedIndex];

            TCDDOtomasyon.REzervasyonEkle(new Rezervasyon(m,s));

            RezListele();
        }

        private void btnBiletKes_Click(object sender, EventArgs e)
        {
            Rezervasyon r = TCDDOtomasyon.RezervasyonListesi[listBoxSefer2.SelectedIndex];
            if (rbTam.Checked)
            {
                Bilet b = new StandartBilet(r);
                TCDDOtomasyon.BiletEkle(b);
            }
            else
            {
                Bilet b = new OgrenciBilet(r);
                TCDDOtomasyon.BiletEkle(b);
            }

            BiletListele();
        }
    }
}
