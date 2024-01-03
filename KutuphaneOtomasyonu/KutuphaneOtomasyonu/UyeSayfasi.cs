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
    public partial class UyeSayfasi : Form
    {

        List<Kitap> kitaplarim;
        public UyeSayfasi(List<Kitap>kitaplarim)
        {
            InitializeComponent();
            this.kitaplarim = kitaplarim;
        }


        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Login loginSayfasi = new Login();
            loginSayfasi.Show();
            this.Hide();
            MessageBox.Show("Çıkış yapıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void UyeSayfasi_Load(object sender, EventArgs e)
        {
            foreach (Kitap kitap in kitaplarim)
            {
                dataGridView3.Rows.Add(kitap.getKitapid(), kitap.getKitapIsmi(),kitap.getKitapYazar(),kitap.getKitapDilil(),kitap.getYayınEvi(),kitap.getTur(),kitap.getAdet(),kitap.getSayfaSayisi(),kitap.getBasimYili());
            }
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            int kitapID = Convert.ToInt32( txt_kitapID.Text);
            Kitap hedefKitap=null;
            foreach (Kitap kitap in kitaplarim)
            {
                if (kitap.getKitapid()==kitapID)
                {
                    hedefKitap = kitap;
                }
            }

            dataGridView3.Rows.Clear();
            dataGridView3.Rows.Add(hedefKitap.getKitapid(), hedefKitap.getKitapIsmi(), hedefKitap.getKitapYazar(), hedefKitap.getKitapDilil(), hedefKitap.getYayınEvi(), hedefKitap.getTur(), hedefKitap.getAdet(), hedefKitap.getSayfaSayisi(), hedefKitap.getBasimYili());

        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Remove(dataGridView3.CurrentRow);
            foreach (Kitap hedefKitap in kitaplarim)
            {
                dataGridView3.Rows.Add(hedefKitap.getKitapid(), hedefKitap.getKitapIsmi(), hedefKitap.getKitapYazar(), hedefKitap.getKitapDilil(), hedefKitap.getYayınEvi(), hedefKitap.getTur(), hedefKitap.getAdet(), hedefKitap.getSayfaSayisi(), hedefKitap.getBasimYili());

            }
        }
    }
}
