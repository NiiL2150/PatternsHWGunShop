using PatternsHWGunShop.Print;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsHWGunShop.Gun
{
    public interface IGun
    {
        bool Suppressor { get; set; }
        bool Extended { get; set; }
        bool Zoom { get; set; }

        double Damage { get; set; }
        double RangeDecrease { get; set; }
        int Price { get; set; }
        int Magazine { get; set; }

        void Shoot(IPrint print, double range);
        void Info(IPrint print);
        double DamageDecrease(double range);
    }
}
