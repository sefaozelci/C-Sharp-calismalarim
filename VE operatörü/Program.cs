using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VE_operatörü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // && ve operatörü (shift+6)

            int sayi1 = 5;
            int sayi2 = 5;
            int sayi3 = 10;

            bool kontrolet = sayi1==sayi2 && sayi1 < sayi3;
            //sayı1 sayı2'ye eşit ve sayı1 sayı3'ten küçük
            Console.WriteLine(kontrolet);
            Console.ReadLine();









        }
    }
}
