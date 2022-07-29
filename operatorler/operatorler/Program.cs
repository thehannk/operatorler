using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 3;
            int y = 3;
            
            //atama ve işlemli atama
            y += 2; //y=y+2;
            y /= 1;
            x *= 2;

            //mantıksal operatörler || veya, && ve, ! değil
            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
                Console.WriteLine("Amazing!");
            if(isSuccess || isCompleted)
                Console.WriteLine("Brilliant!");
            if (isSuccess && !isCompleted)
                Console.WriteLine("Thats fine!");

            //ilişkisel operatörler >,<,<=,>=,==,!=
            int b = 4;
            int a = 3;
            bool sonuc = a < b;

            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a < b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;

            //aritmatik operatörler /,*,+,-
            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 * sayi2;
            sonuc1 = sayi1 + sayi2;
            sonuc1 = sayi1 ++;

            //mod alma
            int sonuc2 = 100%3;
            Console.WriteLine(sonuc2);

        }
    }
}
