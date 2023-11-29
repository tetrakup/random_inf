using System;

namespace random_inf
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            string[] Urunler = { "Bilgisayar", "Telefon", "TV", "Kamera", "Hopörler" }; //rastgele bi ürün ismi
            string rasteleUrun = Urunler[r.Next(0,Urunler.Length)];//buradaki 0 başlangic degerini belirtir
            
            double rastgelefiyat = Math.Round((r.NextDouble() * 1000), 3);//virgülden sonra 3 basamak vurgular
                
            
            Urun u = new Urun(rasteleUrun, rastgelefiyat);//urun sinifindan nesne oluturalim.
            //u.UrunBilgisiGonder();

            int sayac = 0;

            while (sayac < 5)
            {
                Console.Write("Ürün bilgisini görmek istiyor musunuz(evet/hayır):");
                string cevap = Console.ReadLine();

                if (cevap.ToLower() == "evet")
                {
                    //ürün bilgisini yazdiralim.
                    u.UrunBilgisiGonder();
                  //  sayac = 0;//evet yazdiğinda sayac sifirlanir.
                }
                else if (cevap.ToLower() == ("hayır")||cevap.ToLower() ==("hayir"))
                {
                    Console.WriteLine("Sistem kapatılıyor, hoşça kalın!");
                    break;
                }
                else
                    Console.WriteLine($"Hatalı giriş yaptınız. Kalan hakkınız:{5 - sayac}");
                sayac++;
                
            }
            if(sayac==5)
            {
                Console.WriteLine("Çok fazla hatalı giriş yaptınız. Sistemden atılıyorsunuz.");
            }
        }
    }
}