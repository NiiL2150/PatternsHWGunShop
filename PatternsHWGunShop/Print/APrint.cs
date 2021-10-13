using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsHWGunShop.Print
{
    public abstract class APrint : IPrint
    {
        public abstract void Print(string str);
    }
}
