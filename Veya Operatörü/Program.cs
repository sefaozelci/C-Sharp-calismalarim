using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veya_Operatörü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // veya operatörü : || 
            int sayi1 = 3;
            int sayi2 = 3;
            int sayi3 = 6;
            bool kontrolet = sayi1 == sayi2 || sayi2 > sayi3;
            Console.WriteLine(kontrolet);
            Console.ReadLine();




        }
    }
}
