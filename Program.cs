using System;

namespace Tanimlama__Erisim_ve_Dongulerle_Dizi_Kullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi tanımlama
            string[] renkler = new string[5];

            string[] hayvanlar = {"kedi", "kopek","kus","maymun"};

            int[] dizi;
            dizi = new int[5];

            //dizilere değer atama ve erişim
            renkler[0] = "mavi";
            
            dizi[3]=10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Dongulerle dizi kullanımı
            //Klavyeden gelen n tane sayının ortalamasını veren program
            Console.WriteLine("dizinin eleman sayısını giriniz:");
            int diziuzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziuzunlugu];

            for (int i = 0; i < diziuzunlugu; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz:",i+1);
                sayiDizisi[i]=int.Parse(Console.ReadLine());

            } 

            int toplam=0;
            foreach (var sayi in sayiDizisi)
            {
                toplam +=sayi;

            }
            Console.WriteLine("Ortalama:"+ toplam/diziuzunlugu);
        }
    }
}
