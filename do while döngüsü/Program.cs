using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_döngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 den 10 a kadar olan sayıları ekrana yazdırınız.(do while ile)


            //int a = 1;
            // do
            //{
            // Console.WriteLine(a);
            // a += 1;
            // } while (a <= 10);



            // 1 den 100 e kadar olan sayıların toplamını ekrana yazdıranız.(do while ile)

            int b = 1;
            int toplam = 0;

            do
            {
                toplam += b;
                b++;
                
            } while (b<=100);
            Console.WriteLine(toplam);

            Console.ReadLine();

            

            















        }
    }
}
