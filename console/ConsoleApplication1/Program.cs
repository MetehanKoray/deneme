using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            int sonuc;
            Console.WriteLine("Birinci sayıyı girin.");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci Sayıyı girin");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üçüncü sayıyı girin");
            c = Convert.ToInt32(Console.ReadLine());
            sonuc = a + b + c;
            Console.WriteLine(sonuc);
            Console.ReadLine();,
        }
    }
}
