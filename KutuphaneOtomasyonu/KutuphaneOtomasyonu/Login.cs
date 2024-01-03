using KutuphaneOtomasyonu.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class Login : Form
    {

        List<Kisi> kisilerim = new List<Kisi>();  // Kisi adında bir koleksiyon oluşturduk ve kişilerim adında da bir nesne oluşturduk.
        List<Kitap>kitaplarım = new List<Kitap>();

        public Login()
        {
            InitializeComponent();
        }
        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi, sifre = "";
            kullaniciAdi = txt_kullaniciAdi.Text;// kullanici adı boşluğunda ki değeri aldı
            sifre = txt_sifre.Text;

            bool kontrol = false;



            foreach (Kisi kisi in kisilerim)
            {
                if (kullaniciAdi.ToLower() == kisi.getKullaniciAdi() && sifre.ToLower() == kisi.getSifre() && kisi.getYetki() == "admin")
                {
                    // admin sayfasına yönlendirilir.
                    AdminSayfasi adminSayfasi = new AdminSayfasi(kisilerim,kitaplarım);   // burada ki kişileri parametre olarak gönderdik
                    adminSayfasi.Show();  // show metodu ile admin sayfası gösterilir.
                    this.Hide();  // Hide metodu ile de önceki sayfayı saklamış olduk.
                    kontrol = true;
                    break;
                }
                else if(kullaniciAdi.ToLower() == kisi.getKullaniciAdi() && sifre.ToLower() == kisi.getSifre() && kisi.getYetki() == "üye")
                {
                    // üye sayfasına yönlendirilir.
                    UyeSayfasi uyeSayfasi = new UyeSayfasi(kitaplarım);
                    uyeSayfasi.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }
                
                
            }

            if (!kontrol)
            {
                MessageBox.Show("Hatalı Giriş","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {
            kisilerim.Add(new Kisi(1, "Nurullah", "ORAK", "a", DateTime.Now, "a", "admin"));
            kisilerim.Add(new Kisi(2, "Enes", "Doner", "ensdnr", DateTime.Now, "190534", "üye"));
            kisilerim.Add(new Kisi(3, "Samet", "Kopar", "smtkopar", DateTime.Now, "190734", "üye"));
            kisilerim.Add(new Kisi(4, "Furkan", "Çakmak", "frkncakmak", DateTime.Now, "190506", "üye"));


            kitaplarım.Add(new Kitap(1, "İçimizdeki Şeytan","Sebahattin Ali","Türkçe","Yapı Kredi Yayınları","roman",100,250,2016));
            kitaplarım.Add(new Kitap(2,"Tutunamayanlar","Oğuz Atay","Türkçe","İletişim Yayıncılık","roman",350,760,2015));
            kitaplarım.Add(new Kitap(3,"Uçurtma Avcısı","Khaled Hosseini","İngilizce","everest yayıncılık","roman",100,350,2010));
            kitaplarım.Add(new Kitap(4,"Küçük Prens","Antoine de Saint-Exupery","İngilizce","Can çocuk yayınları","roman",50,60,2018));
            kitaplarım.Add(new Kitap(5,"Kürk Mantolu Madonna","Sebahattin Ali","Türkçe","Yapı Kredi Yayınları","rooman",650,220,2015));
            

        }
    }
}
