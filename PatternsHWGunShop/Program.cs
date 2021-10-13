using PatternsHWGunShop.Gun;
using PatternsHWGunShop.Gun.Builder;
using PatternsHWGunShop.Print;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsHWGunShop
{
    class Program
    {
        static ConsolePrint print = new ConsolePrint();
        static void Main(string[] args)
        {
            Loop1();
        }

        static void Loop1()
        {
            int x;
            IGunBuilder gunBuilder;
            do
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("0 - quit; 1 - pistol; 2 - rifle");
                x = Int32.Parse(Console.ReadLine());
                if (x == 1)
                {
                    gunBuilder = new PistolBuilder();
                }
                else if (x == 2)
                {
                    gunBuilder = new RifleBuilder();
                }
                else
                {
                    continue;
                }
                Loop2(gunBuilder);
            } while (x!=0);
        }

        static void Loop2(IGunBuilder gunBuilder)
        {
            gunBuilder.CreateGun();
            int x;
            do
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("0 - quit; 1 - shoot; 2 - info; 3 - addons");
                x = Int32.Parse(Console.ReadLine());
                if (x == 1)
                {
                    Console.Write("\nEnter range: ");
                    double range = Double.Parse(Console.ReadLine());
                    gunBuilder.Gun.Shoot(print, range);
                }
                else if (x == 2)
                {
                    gunBuilder.Gun.Info(print);
                }
                else if (x == 3)
                {
                    Loop3(gunBuilder);
                }
            } while (x != 0);
        }
        
        static void Loop3(IGunBuilder gunBuilder)
        {
            int x;
            do
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("0 - quit; 1 - suppressor; 2 - magazine extension; 3 - zoom");
                x = Int32.Parse(Console.ReadLine());
                if (x == 1)
                {
                    gunBuilder.SetSuppressor();
                }
                else if (x == 2)
                {
                    gunBuilder.SetExtended();
                }
                else if (x == 3)
                {
                    gunBuilder.SetZoom();
                }
            } while (x != 0);
        }
    }
}
