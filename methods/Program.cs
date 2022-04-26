
// https://app.patika.dev/altius //
using System;

namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // erişim_belirtici geri_donustipi metot_adi(parametreListesi/arguman)
            //{
            ////komutlar;
            // return;
            //}

            int a = 2;
            int b = 3;

            Console.WriteLine(a + b); //1. yol


            int sonuc =Topla(a, b);
            Console.WriteLine(sonuc);  //2. yol
            
            Metotlar ornek=new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc)); //3. yol
            
            int sonuc2 = ornek.ArttirVeTopla(ref a, ref b); //4. yol
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a + b));    //referans ataması yapılmasaydı bunun sonucu 5 çıkardı
                                                            //ama ref. atamasından sonra global olarak değerler
                                                            //değişiyor ve bunun sonucu 7 oluyor.

        }

        // called by value // -> Değer tipinde atama
        static int Topla(int deger1, int deger2)
        {
            return (deger1 + deger2);
        }
    }

    class Metotlar
    {
        public void EkranaYazdir (string veri)
        {
            Console.WriteLine(veri);
        }

        //called by reference// -> referans ile atama
        public int ArttirVeTopla (ref int deger1, ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1+deger2;
        }
    }
}
