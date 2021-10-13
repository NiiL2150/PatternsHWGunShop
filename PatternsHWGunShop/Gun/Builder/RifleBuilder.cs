using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsHWGunShop.Gun.Builder
{
    class RifleBuilder : AGunBuilder
    {
        public override void CreateGun()
        {
            Gun = new Rifle();
        }
    }
}
