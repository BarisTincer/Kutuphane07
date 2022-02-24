using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane07.DATA
{
    public class KullaniciYoneticisi
    {
        public KullaniciYoneticisi()
        {
            Kullanicilar = new List<Kullanici>();
        }
        public List<Kullanici> Kullanicilar { get; set; }
        public void KayitOlma(string adSoyad, string kullaniciAdi, string parola)
        {
            Kullanici kullanici = new Kullanici()
            {
                AdSoyad = adSoyad,
                Parola = parola,
                KullaniciAdi = kullaniciAdi
            };
            Kullanicilar.Add(kullanici);
        }
        public Kullanici GirisYap(string kullaniciAdi, string parola)
        {
            return Kullanicilar.FirstOrDefault(x => x.KullaniciAdi == kullaniciAdi && x.Parola == parola);
        }
        public bool KullaniciVarmi(string kullaniciAdi)
        {
            return Kullanicilar.Any(x => x.KullaniciAdi == kullaniciAdi);
        }
    }
}
