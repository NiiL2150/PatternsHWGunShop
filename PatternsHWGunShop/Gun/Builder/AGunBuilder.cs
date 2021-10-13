using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsHWGunShop.Gun.Builder
{
    abstract class AGunBuilder : IGunBuilder
    {
        public IGun Gun { get; set; }
        public abstract void CreateGun();
        public void SetExtended(bool value)
        {
            Gun.Extended = value;
        }
        public void SetExtended()
        {
            Gun.Extended = !(Gun.Extended);
        }
        public void SetSuppressor(bool value)
        {
            Gun.Suppressor = value;
        }
        public void SetSuppressor()
        {
            Gun.Suppressor = !(Gun.Suppressor);
        }
        public void SetZoom(bool value)
        {
            Gun.Zoom = value;
        }
        public void SetZoom()
        {
            Gun.Zoom = !(Gun.Zoom);
        }
    }
}
