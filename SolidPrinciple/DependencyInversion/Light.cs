using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class Light: ISwitchable
    {
        public void TurnOn()
        {
            Console.WriteLine("LightBulb: Turned on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("LightBulb: Turned off.");
        }
    }
}
