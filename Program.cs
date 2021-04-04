using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dallanmaKomutları
{
    class Program
    {
        static void Main(string[] args)
        {
        BASADON:
            Console.Clear();
            Console.Write("1.sınav notunu giriniz:");
            int y1 = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("2.sınav notunu giriniz:");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3.sınav notunu giriniz:");
            int y3 = Convert.ToInt32(Console.ReadLine());
            int ort = (y1 + y2 + y3) / 3;
            Console.Write("sınavların ortalaması:{0}",ort);
        SECİM:
            Console.WriteLine("\nbaşka işlem yapmak ister misiniz: (e / h)");
            char secim = Convert.ToChar(Console.ReadLine());
            if (secim=='e'||secim=='E')
            {
                goto BASADON;
            }
            else if (secim=='h'||secim=='H')
            {
                Console.WriteLine("\nİyi günler");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Yanlış seçim yaptınız .. tekrar deneyiniz.");
                goto SECİM;
            }



            Console.ReadKey();

        }
    }
}
