using System;
using System.Collections.Generic;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
           // ciftBul();
            //tamBolunme();
            //tersKelime();
            cumleDigit();
        }

        public static void ciftBul(){
            List<int> cift=new List<int>();
            Console.WriteLine("Pozitif bir sayı giriniz:");
            int n= int.Parse(Console.ReadLine());
            Console.WriteLine(n+" tane pozitif sayi giriniz: ");
            for(int i=1; i<=n;i++){
                int a= int.Parse(Console.ReadLine());
                if(a%2==0)
                    cift.Add(a);
            }
            Console.WriteLine("Girilen sayılardan çift olanlar:");
            foreach(var item in cift)
                Console.WriteLine(item);
        }

        public static void tamBolunme(){
            List<int> bolen=new List<int>();
            Console.WriteLine("2 adet sayi giriniz:");
            int n= int.Parse(Console.ReadLine());
            int m= int.Parse(Console.ReadLine());
            Console.WriteLine(n+" tane pozitif sayi giriniz: ");
            for(int i=1; i<=n;i++){
                int a= int.Parse(Console.ReadLine());
                if(a%m==0)
                    bolen.Add(a);
            }
            Console.WriteLine("Girilen sayılardan {0}'e tam bölünenler:",m);
            foreach(var item in bolen)
                Console.WriteLine(item);
        }

        public static void tersKelime(){
            List<string> kelimeler=new List<string>();
            Console.WriteLine("1 adet sayi giriniz:");
            int n= int.Parse(Console.ReadLine());
             Console.WriteLine(n+" tane kelime giriniz: ");
            for(int i=1; i<=n;i++){
                string a= Console.ReadLine();
                kelimeler.Add(a);
            }
            kelimeler.Reverse();
            foreach(string item in kelimeler)
                Console.WriteLine(item);
        }

        public static void cumleDigit(){
            int harfsayisi = 0;
            System.Console.WriteLine("Bir cümle girin");
            string cumle = Console.ReadLine();
            string[] kelime = cumle.Split(" ");
            System.Console.WriteLine("Cümlede {0} kelime var.",kelime.Length);
            for (int i = 0; i < kelime.Length; i++)
            {
                 char[] harfdizi = kelime[i].ToCharArray();
                harfsayisi += harfdizi.Length;
            }
            System.Console.WriteLine("Cümlede {0} adet harf var.",harfsayisi);
        }
    }
}
