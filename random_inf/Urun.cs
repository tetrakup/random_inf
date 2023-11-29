using System;

namespace random_inf
{
    public class Urun
    {
        public string Ad;
        public double Fiyat;
        
        //constructor-yapici method
        public Urun(string adi, double fiyati)
        {
            Ad = adi;
            Fiyat = fiyati;
        }

        public void UrunBilgisiGonder()
        {
            Console.WriteLine("Ürün Adı: "+ Ad + "\n"+ "Ürün Fiyatı: "+Fiyat);
        }
        
    }
}