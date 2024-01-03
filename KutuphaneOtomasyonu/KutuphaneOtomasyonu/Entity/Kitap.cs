using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Entity
{
    public class Kitap
    {
        public int Kitapid { get; set; }
        public string KitapIsmi { get; set; }
        public string KitapYazar { get; set; }
        public string KitapDili { get; set; }
        public string YayınEvi { get; set; }
        public string Tur { get; set; }
        public int Adet { get; set; }
        public int SayfaSayisi { get; set; }
        public int BasimYili { get; set; }


        public Kitap()
        {

        }
        public Kitap(int kitapid, string kitapIsmi, string kitapYazar, string kitapDili, string yayınEvi, string tur, int adet, int sayfaSayisi, int basimYili)   // yapıcı metod kullanarak set edecez
        {
            this.Kitapid = kitapid;
            this.KitapIsmi = kitapIsmi;
            this.KitapYazar = kitapYazar;
            this.KitapDili = kitapDili;
            this.YayınEvi = yayınEvi;
            this.Tur = tur;
            this.Adet = adet;
            this.SayfaSayisi = sayfaSayisi;
            this.BasimYili = basimYili;


        }

        public int getKitapid()
        {
            return this.Kitapid;
        }
        public string getKitapIsmi()
        {
            return this.KitapIsmi;
        }
        public string getKitapYazar()
        {
            return this.KitapYazar;
        }
        public string getKitapDilil()
        {
            return this.KitapDili;
        }
        public string getYayınEvi()
        {
            return this.YayınEvi;
        }
        public string getTur()
        {
            return this.Tur;
        }
        public int getAdet()
        {
            return this.Adet;
        }
        public int getSayfaSayisi()
        {
            return this.SayfaSayisi;
        }

        public int getBasimYili()
        {
            return this.BasimYili;
        }



    }
}
