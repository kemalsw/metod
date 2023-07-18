using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen bir sayı daha giriniz: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int sonuc = topla(a, b);
            Console.WriteLine("Sonucunuz: " + sonuc);

            metotlar ornek = new metotlar();
            ornek.ekranayazdir(Convert.ToString(sonuc));
            Console.ReadLine();


        }
        static int topla(int deger1, int deger2)
        {
            return deger1 + deger2;
        }

    }
    class metotlar
    {
        public void ekranayazdir(string veri)
        {
            Console.WriteLine(veri);
        }

    }
}
