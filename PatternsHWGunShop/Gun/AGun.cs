using PatternsHWGunShop.Print;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsHWGunShop.Gun
{
    public abstract class AGun : IGun
    {
        public AGun(double _damage, double _rangeDecrease, int _price, int _magazine)
        {
            Damage = _damage;
            RangeDecrease = _rangeDecrease;
            Price = _price;
            Magazine = _magazine;
        }
        private double _damage;
        private double _rangeDecrease;
        private int _price;
        private int _magazine;

        public double Damage
        {
            get
            {
                return _damage * (Suppressor ? 0.95 : 1);
            }
            set
            {
                _damage = value;
            }
        }
        public double RangeDecrease
        {
            get
            {
                return _rangeDecrease * (Suppressor ? 0.95 : 1);
            }
            set
            {
                _rangeDecrease = value;
            }
        }
        public int Price
        {
            get
            {
                return _price + (Suppressor ? 50 : 0) + (Extended ? 100 : 0) 
                    + (Zoom ? 20 : 0);
            }
            set
            {
                _price = value;
            }
        }
        public int Magazine
        {
            get
            {
                return _magazine * (Extended ? 2 : 1);
            }
            set
            {
                _magazine = value;
            }
        }

        public bool Suppressor { get; set; }
        public bool Extended { get; set; }
        public bool Zoom { get; set; }

        public void Shoot(IPrint print, double range)
        {
            print.Print($"{this.GetType().Name} dealt {DamageDecrease(range)} damage");
        }
        public void Info(IPrint print)
        {
            print.Print($"{this.GetType().Name}:\n" +
                $"DMG: {Damage}\n" +
                $"DMG decrease per meter: {RangeDecrease}\n" +
                $"Costs {Price}$\n" +
                $"Has {Magazine} bullets in magazine\n" +
                (Suppressor?"Has":"Doesn't have") + " suppressor\n" +
                (Zoom ? "Has" : "Doesn't have") + " zoom\n" +
                (Extended ? "Has" : "Doesn't have") + " extended magazine\n");
        }

        public virtual double DamageDecrease(double range)
        {
            return Damage * (Math.Pow(RangeDecrease, range));
        }
    }
}
