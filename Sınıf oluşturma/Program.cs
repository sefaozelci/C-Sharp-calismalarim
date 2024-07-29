using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıf_oluşturma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba1 = new Araba();
            Console.WriteLine(araba1);
            Console.ReadLine();
            araba1.kapisayisi = 4;
            araba1.arabarengi = "kırmızı";
            araba1.arabamodel = "bmw";

            araba1.kapilarikilitle();
            araba1.motorcalistir();

            Console.WriteLine("arabanın kapi sayisi"+araba1.kapisayisi);
            Console.WriteLine("araba rengi"+araba1.arabarengi );
            Console.WriteLine("arabanın modeli"+araba1.arabamodel);
            Console.ReadLine();






        }
    }
}