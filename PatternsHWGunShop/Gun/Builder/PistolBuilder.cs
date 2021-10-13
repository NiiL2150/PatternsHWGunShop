using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsHWGunShop.Gun.Builder
{
    class PistolBuilder : AGunBuilder
    {
        public override void CreateGun()
        {
            Gun = new Pistol();
        }
    }
}
