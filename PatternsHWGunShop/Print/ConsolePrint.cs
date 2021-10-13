using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsHWGunShop.Print
{
    class ConsolePrint : APrint
    {
        public override void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
