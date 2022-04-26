// https://app.patika.dev/altius //

using System;

namespace method_overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // out parametreler
            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outSayi);
            if(sonuc)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("başarısız");
            }

            metotlar instance = new metotlar();
            instance.Topla(4,5, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            //metot overloading -> method aşırı yükleme

            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade)); //aşağıda string veri olarak yazılan ksıımdan ötürü burada convert yapıyoruz
            instance.EkranaYazdir(ifade);//daha sonrasında int veri olarak girdiğimiz için burada converte gerek yok
            instance.EkranaYazdir("goktug","yildiz");
            //method imzası
            //methodAdi + parametre sayisi + parametre
        }
    }

    class metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }
        public void EkranaYazdir(string veri)   
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
}
