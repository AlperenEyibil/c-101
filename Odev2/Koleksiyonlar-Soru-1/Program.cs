using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList asallar= new ArrayList();
            ArrayList asalOlmayanlar= new ArrayList();
            int asalOrtalama=0, asalOlmayanOrtalama=0;
            int deger=0;
            for(int i=0;i <6;i++){
                Console.WriteLine("Pozitif sayı giriniz.");
                
                while(!int.TryParse(Console.ReadLine(), out deger) || deger<0){
                    Console.WriteLine("Sadece pozitif sayı giriniz.");
                }
                if(deger==1)
                    asalOlmayanlar.Add(deger);
                else if(deger==2)
                    asallar.Add(deger);
                else{
                    for(int j=2;j<=12;j++){
                        if(deger % j==0 && deger!=3 && deger!=5 && deger!=7 && deger !=11){
                            asalOlmayanlar.Add(deger);
                            break;
                        }
                        else if(j==12)
                            asallar.Add(deger);
                    }
                }
            }
            asallar.Sort();
            asallar.Reverse();
            asalOlmayanlar.Sort();
            asalOlmayanlar.Reverse();
            Console.WriteLine("Asallar");
            foreach (int sayi in asallar){
                Console.WriteLine(sayi);
                asalOrtalama+=sayi;
            }
            Console.WriteLine("Asal Olmayanlar");
            foreach (int sayi in asalOlmayanlar){
                Console.WriteLine(sayi);
                asalOlmayanOrtalama+=sayi;
            }
            Console.WriteLine("asal olanların sayısı: "+asallar.Count);
            Console.WriteLine("asal olanların ortalaması: "+((double) asalOrtalama / asallar.Count));
            Console.WriteLine("asal olmayanların sayısı: "+asallar.Count);
            Console.WriteLine("asal olmayanların ortalaması: "+((double)asalOlmayanOrtalama / asalOlmayanlar.Count));
        }
    }
}
