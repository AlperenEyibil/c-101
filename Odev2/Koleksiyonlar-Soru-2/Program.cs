using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar= new int[5];
            int buyuk=0, kucuk=0;

            for(int i= 0; i<sayilar.Length; i++){
                Console.WriteLine("Sayi giriniz");
                sayilar[i]=int.Parse(Console.ReadLine());
            }
            Array.Sort(sayilar);
            buyuk=sayilar[sayilar.Length-1]+sayilar[sayilar.Length-2]+sayilar[sayilar.Length-3];
            kucuk=sayilar[0]+sayilar[1]+sayilar[2];
            Console.WriteLine("Büyüklerin ortalaması: "+((double)buyuk/3));
            Console.WriteLine("Küçüklerin ortalaması: "+((double)kucuk/3));
            Console.WriteLine("Ortalamaların toplamı: "+((double)buyuk/3 + (double)kucuk/3));
        }
    }
}
