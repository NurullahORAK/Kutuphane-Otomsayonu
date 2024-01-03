using KutuphaneOtomasyonu.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class AdminSayfasi : Form
    {
        List<Kisi> kisilerim;  // admin sayfası yüklendiğinde varolan kişileri göstermek istiyoruz.
        List<Kitap> kitaplarım;
        public AdminSayfasi(List<Kisi> kisilerim, List<Kitap> kitaplarım)  // parametre olarak gelecek kişileri burada tanımladığımız kisilerime atarız
        {
            InitializeComponent();
            this.kisilerim = kisilerim;
            this.kitaplarım = kitaplarım;
        }

        private void AdminSayfasi_Load(object sender, EventArgs e)
        {
            foreach (Kisi kisi in kisilerim)  // her bir kişiyi kişilerim üzerinden dönüyoruz.
            {
                dataGridView1.Rows.Add(kisi.getId(), kisi.getIsim(), kisi.getSoyisim(), kisi.getOlusturmaTarihi(), kisi.getKullaniciAdi(), kisi.getSifre(), kisi.getYetki());  // burada kişilerin bilgilerini gönderiyoruz.
            }
            foreach (Kitap kitap in kitaplarım)
            {
                dataGridView2.Rows.Add(kitap.getKitapid(), kitap.getKitapIsmi(), kitap.getKitapYazar(), kitap.getKitapDilil(), kitap.getYayınEvi(), kitap.getTur(), kitap.getAdet(), kitap.getSayfaSayisi(), kitap.getBasimYili());
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(Convert.ToInt32(txt_id.Text), txt_isim.Text, txt_soyisim.Text, maskedTextBox1.Text, txt_kullaniciAdi.Text, txt_sifre.Text, txt_yetki.Text);         // bu sefer ekleyeceğimiz deeğerleri txtbox tan alıyoruz.
        }

        private void txt_sil_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow); // seçilmiş satırı kaldır.
        }

        public void textleriDoldur()
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_isim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_soyisim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_kullaniciAdi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_sifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_yetki.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textleriDoldur();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string isim = txt_isim.Text;
            string soyisim = txt_soyisim.Text;
            string tarih = maskedTextBox1.Text;
            string kullanicAdi = txt_kullaniciAdi.Text;
            string sifre = txt_sifre.Text;
            string yetki = txt_yetki.Text;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id, isim, soyisim, tarih, kullanicAdi, sifre, yetki);
        }

        private void btn_kitapekle_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(txt_kitapid.Text, txt_kitapisim.Text, txt_kitapyazar.Text, txt_kitapdili.Text, txt_yayinevi.Text, txt_kitaptur.Text, txt_adet.Text, txt_sayfasayisi.Text, txt_basimyili.Text);
        }
        private void btn_kitapsil_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        }

        private void btn_kitapguncelle_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridView2.SelectedCells[0].RowIndex;
            
            dataGridView2.Rows[selectedRowIndex].Cells[0].Value = txt_kitapid.Text;
            dataGridView2.Rows[selectedRowIndex].Cells[1].Value = txt_kitapisim.Text;
            dataGridView2.Rows[selectedRowIndex].Cells[2].Value = txt_kitapyazar.Text;
            dataGridView2.Rows[selectedRowIndex].Cells[3].Value = txt_kitapdili.Text;
            dataGridView2.Rows[selectedRowIndex].Cells[4].Value = txt_yayinevi.Text;
            dataGridView2.Rows[selectedRowIndex].Cells[5].Value = txt_kitaptur.Text;
            dataGridView2.Rows[selectedRowIndex].Cells[6].Value = txt_adet.Text;
            dataGridView2.Rows[selectedRowIndex].Cells[7].Value = txt_sayfasayisi.Text;
            dataGridView2.Rows[selectedRowIndex].Cells[8].Value = txt_basimyili.Text;



        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kitapid.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txt_kitapisim.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txt_kitapyazar.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txt_kitapdili.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txt_yayinevi.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txt_kitaptur.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txt_adet.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            txt_sayfasayisi.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            txt_basimyili.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
        }

        private void btn_kisiAra_Click(object sender, EventArgs e)
        {
            Kisi hedefKisi = null;
            int secilenKisiID = Convert.ToInt32(textBox1.Text);
            foreach (Kisi kisi in kisilerim)
            {
                if (kisi.getId()==secilenKisiID)
                {
                    hedefKisi = kisi;
                    break;
                }
            }

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(hedefKisi.getId(),hedefKisi.getIsim(),hedefKisi.getSoyisim(),hedefKisi.getOlusturmaTarihi(),hedefKisi.getKullaniciAdi(),hedefKisi.getSifre(),hedefKisi.getYetki());


        }

        private void btn_kisiYenile_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            foreach (Kisi hedefKisi in kisilerim)
            {
                dataGridView1.Rows.Add(hedefKisi.getId(), hedefKisi.getIsim(), hedefKisi.getSoyisim(), hedefKisi.getOlusturmaTarihi(), hedefKisi.getKullaniciAdi(), hedefKisi.getSifre(), hedefKisi.getYetki());

            }
        }

        private void btn_kitapara_Click(object sender, EventArgs e)
        {
            Kitap hedefKitap = null;
            int kitapID=Convert.ToInt32(textBox2.Text);
            foreach (Kitap kitap in kitaplarım)
            {
                if (kitap.getKitapid()==kitapID)
                {
                    hedefKitap = kitap;
                }
            }
            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add(hedefKitap.getKitapid(), hedefKitap.getKitapIsmi(), hedefKitap.getKitapYazar(), hedefKitap.getKitapDilil(), hedefKitap.getYayınEvi(), hedefKitap.getTur(), hedefKitap.getAdet(),hedefKitap.getSayfaSayisi(),hedefKitap.getBasimYili());



        }

        private void btn_kitapyenile_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            foreach (Kitap hedefKitap in kitaplarım)
            {
                dataGridView2.Rows.Add(hedefKitap.getKitapid(), hedefKitap.getKitapIsmi(), hedefKitap.getKitapYazar(), hedefKitap.getKitapDilil(), hedefKitap.getYayınEvi(), hedefKitap.getTur(), hedefKitap.getAdet(), hedefKitap.getSayfaSayisi(), hedefKitap.getBasimYili());

            }


        }

        private void btn_cikisyap_Click(object sender, EventArgs e)
        {
            Login loginSayfasi=new Login();
            loginSayfasi.Show();
            this.Hide();
            MessageBox.Show("Çıkış yapıldı","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
