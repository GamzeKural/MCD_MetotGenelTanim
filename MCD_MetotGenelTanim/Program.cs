using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_MetotGenelTanim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba");
            selamla();
            Ogrenci o1 = new Ogrenci();
            o1.ogrenciMetot2();
            o1.selamlaOgrenci();

            Ogrenci o2 = new Ogrenci();
            o2.ogrenciMetot2();
            o2.selamlaOgrenci();


            Console.ReadLine();
        }

        static void selamla()
        {
            Console.WriteLine("Merhaba");
        }
    }
}
