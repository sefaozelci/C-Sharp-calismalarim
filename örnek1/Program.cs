using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplamcift = 0;
            int cift = 0;
            int tek = 0;
            Console.WriteLine("degerleri giriniz:");
            int[] degerler= Console.ReadLine().Split(' ');
            for (int i=0; i<degerler.Length; i++)
            {
                if (degerler % 2 == 0)
                {
                    
                    cift++;
                }
                if (degerler%2!=0)
                {
                    tek++;
                }

            }











        }
    }
}
