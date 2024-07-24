using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giriş_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcı giriş sayfası uygulaması yapacağız
            // kullanıcı adı ve şifresini doğru girerse Tebrikleri başarılı bir şekilde giriş yaptınız
            // yanlış girerse hata verelim ve 3 hak tanıyalım kullanıcıya yanlış girdiği sürece döngü dönmeye devam etsin

            for (int i=1; i<=3; i++)
            {
            Console.WriteLine("Lütfen kullanıcı adınızı giriniz");
            string kullanici = Console.ReadLine();

            Console.WriteLine("Lütfen şifrenizi giriniz:");
            string sifre= Console.ReadLine();

                if (kullanici == "sefa" && sifre == "123")
                {
                    Console.WriteLine("Başarılı bir şekilde giriş yaptınız");
                    break;


                }

                else if (kullanici != "sefa" && sifre != "123") ;
                Console.WriteLine("Hatalı giris");
                
                
                    
            }












        }
    }
}
