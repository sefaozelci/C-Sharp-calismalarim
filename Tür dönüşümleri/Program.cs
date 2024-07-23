using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tür_dönüşümleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int a = 5;
            //byte b = (byte)a;
            //Console.WriteLine(b.GetType());
            // Console.WriteLine(b);




            // string sayi1 = "1";
            //string sayi2 = "2";
            //int a = Convert.ToInt32(sayi1);
            //int b= Convert.ToInt32(sayi2);
            //Console.WriteLine(a+b);
            //convert.Toınt32 string değerleri dönüştürürken kullanılabilir.



            //Kullanıcıdan alınan değerler string değerlerdir

            //Console.WriteLine("Lütfen yasınızı giriniz:");
            // string kullanici_yas = Console.ReadLine();
            // int kullanici_yasInt = int.Parse(kullanici_yas);
            // int kullanici_yasInt2 = Convert.ToInt32(kullanici_yas);
            // Console.WriteLine(kullanici_yasInt);
            //Console.WriteLine(kullanici_yasInt2);


            // kullanıcıdan iki tane sayı alan ve ikisinin toplamını ekrana yazdıran programı yazınız

            Console.WriteLine("Lütfen bir sayi giriniz:");
            string sayi1 = Console.ReadLine();
            Console.WriteLine("Lütfen ikinci bir sayi giriniz:");
            string sayi2 = Console.ReadLine();
            int sayi11 = Convert.ToInt32(sayi1);
            int sayi22 = Convert.ToInt32(sayi2);

            Console.WriteLine("iki sayının toplamı:"+(sayi11+sayi22));
            Console.ReadLine();








            Console.ReadLine();
            



















        }
    }
}
