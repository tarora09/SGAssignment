using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class Worker : Iworkable, IEatable
    {
        public void Work()
        {
            Console.WriteLine("Worker is working.");
        }

        public void Eat()
        {
            Console.WriteLine("Worker is eating.");
        }
    }
}
