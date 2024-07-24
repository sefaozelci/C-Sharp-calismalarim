using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break_ve_continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // break anahtar kelimesi 
            //continue anahtar kelimesi 
            for (int a=1; a<=10; a++)
            {
                if ( a==8)
                {
                    //break; // break kullanılırsa tamamen döngünün dışına çıkar
                    continue; // döngüyü sadece 1 kereye mahsus kırar


                }
                Console.WriteLine("a nın degeri:"+a);

            }
            Console.ReadLine();

















        }
    }
}
