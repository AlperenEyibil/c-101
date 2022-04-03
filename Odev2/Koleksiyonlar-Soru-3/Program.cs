using System;
using System.Collections;
namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] sesliH={'a','e','ı','i','o','ö','u','ü'};
            string input= Console.ReadLine();
            ArrayList sesliInput= new ArrayList();

            foreach(var harf in input){
                foreach(var sesli in sesliH){
                    if(sesli==harf){
                        sesliInput.Add(harf);
                        break;
                    }
                }
            }
            foreach(var item in sesliInput)
                Console.Write(item+" ");
        }
    }
}
