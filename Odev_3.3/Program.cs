using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Kullanıcı programdan çıkmak isteyene kadar kullanıcıdan sayı talep edin 
            kullanıcı çıkış yapmak istediğinde kullanıcıdan sayı istemeyi bırakıp 
            girdiği sayıların ortalamasını gösterin ve çıkış işlemini gerçekleştirin.
            */

            //Exit for send code "1453"
            int input = 1, last = 0;
            Console.WriteLine("Send '0000' for exit.");
            while (input != 0000)
            { 
                for (int i = 1; i < 1000; i++)
                {
                    Console.Write(i + ". Sayı: ");
                    input = int.Parse(Console.ReadLine());

                    last = last + input;

                    if (input == 0000)
                    {
                        i--;
                        last = last / i;
                        Console.Clear();
                        Console.WriteLine("Hesaplama işlemi sonlandı.\n"+
                        "Ortalama sonucu: " + last +
                        "\n\nPress any button for exit.");
                        Console.ReadKey();
                        break;
                    }
                }
            }
        }
    }
}
