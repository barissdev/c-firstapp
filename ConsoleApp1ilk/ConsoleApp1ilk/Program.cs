using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1ilk
{
    internal class Program
    {
        static void Main(string[] args )
        {
            Console.WriteLine("BARZO BAR'A HOŞ GELDİNİZ");


            Console.WriteLine("İsminizi girin");
            string isim = Console.ReadLine();
            Console.WriteLine("Soyisminizi girin");
            string soyad = Console.ReadLine();

            Console.WriteLine("Son olarak yaşınız nedir?");
            int yas = Convert.ToInt16(Console.ReadLine());

            if (yas >= 18)

                Console.WriteLine("Girebilirsiniz Efendim");

            else

            Console.WriteLine("Giremezsiniz Efendim, maalesef yaşınız 18 den küçük");

            Console.ReadLine();


        }
    }
}
