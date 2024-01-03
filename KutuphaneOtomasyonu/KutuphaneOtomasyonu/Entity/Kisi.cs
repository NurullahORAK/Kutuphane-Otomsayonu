using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Entity
{
    public class Kisi
    {
        private int Id { get; set; }  // propertyler tanımlandı
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string KullaniciAdi { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public string Sifre { get; set; }
        public string Yetki { get; set; }



        public Kisi()
        {

        }
        public Kisi(int _id, string _isim, string _soyisim, string _kullaniciAdi, DateTime _olusturmaTarihi, string _sifre, string _yetki)
        {
            this.Id = _id;
            this.Isim = _isim;
            this.Soyisim = _soyisim;
            this.KullaniciAdi = _kullaniciAdi;
            this.OlusturmaTarihi = _olusturmaTarihi;
            this.Sifre = _sifre;
            this.Yetki = _yetki;
        }

        public void setId(int id)
        {
            this.Id = id;
        }

        public int getId() { return this.Id; }
        public void setIsım(string isim)
        {
            this.Isim = isim;
        }
        public string getIsim()

        {
            return this.Isim;
        }

        public void setSoyisim(string soyisim)
        {
            this.Soyisim = soyisim;
        }
        public string getSoyisim()
        {
            return this.Soyisim;
        }
        public void setKullaniciAdi(string kullaniciAdi)
        {
            this.KullaniciAdi = kullaniciAdi;
        }

        public string getKullaniciAdi()
        {
            return this.KullaniciAdi;
        }

        public void setOlusturmaTarihi(DateTime olusturmaTarihi)
        {
            this.OlusturmaTarihi = olusturmaTarihi;
        }

        public DateTime getOlusturmaTarihi()
        {
            return this.OlusturmaTarihi;
        }

        public void setSifre(string sifre)
        {
            this.Sifre = sifre;
        }
        public string getSifre()
        {
            return this.Sifre;
        }

        public void setYetki(string yetki)
        {
            this.Yetki = yetki;
        }

        public string getYetki()
        {
            return this.Yetki;
        }

        public override string ToString()  // tostring metodunu override edersek bize içine yazdığımız değerleri okutur.
        {
            return "İsim ve Soyisim: " + this.Isim + " " + this.Soyisim;
        }



    }
}
