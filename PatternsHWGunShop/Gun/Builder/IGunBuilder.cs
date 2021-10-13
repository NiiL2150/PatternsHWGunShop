using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsHWGunShop.Gun.Builder
{
    interface IGunBuilder
    {
        IGun Gun { get; set; }
        void CreateGun();
        void SetSuppressor(bool value);
        void SetExtended(bool value);
        void SetZoom(bool value);
        void SetSuppressor();
        void SetExtended();
        void SetZoom();
    }
}
