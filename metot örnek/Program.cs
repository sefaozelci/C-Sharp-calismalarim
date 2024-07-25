using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace metot_örnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan aldığımız sayının karesini alalım eğer karesi 25'ten büyükse;
            // karesi 25'ten büyüktür
            // değilse 25'ten küçüktür yazdırsın 

            Console.WriteLine("Bir sayı giriniz:");
            int girilensayi= int.Parse(Console.ReadLine());

            int sonuc= kareal(girilensayi);
            Console.WriteLine(sonuc);
            Console.ReadLine();

















        }
        static int kareal(int a )
        {
            return a * a;
        }
        
    }
}
