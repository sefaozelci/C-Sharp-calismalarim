using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Eşittir_Operatörü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // eşittir operatörü : ==
            int sayi1 = 4;
            int sayi2 = 4;
            bool kontrolet = sayi1 == sayi2;
            Console.WriteLine(kontrolet);
            Console.ReadLine();

        }
    }
}
