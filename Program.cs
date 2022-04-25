using System;

namespace array_sinifi_metodlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //        SORTING (sıralamak)     //
            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };

            Console.WriteLine("*** SIRASIZ LİSTE ***");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }


            Console.WriteLine("*** SIRALI LİSTE ***");
            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //     clear    //
            Console.WriteLine("*** Array Clear ***");
            
            //sayiDizisi elemanlarını kullanarak 2.indexten itibaren 2 tane elemanı sıfırlar
            Array.Clear(sayiDizisi, 2, 2);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //   Reverse   //
            Console.WriteLine("*** Array Reverse ***");

            Array.Reverse(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //  indexOf  //
            Console.WriteLine("*** Array IndexOf ***");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

            //   Resize   // --> index normalde 8 elemanlıydı. biz 9 elemana çevirdik ve dokuzuncu elemanı da 99 olarak atadık.
            Console.WriteLine("*** Array Resize ***");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            int Dizi = new int[15];
            foreach (var sayim in Dizi)
            Console.WriteLine(sayim);
        }
    }
}
