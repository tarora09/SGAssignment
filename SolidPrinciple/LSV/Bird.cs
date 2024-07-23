using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSV
{
    public abstract class Bird
    {
        public abstract void Move();
    }

    // Subclass for birds that can fly
    public class Sparrow : Bird
    {
        public override void Move()
        {
            Console.WriteLine("Sparrow: Flying");
        }
    }

    // Subclass for birds that cannot fly
    public class Penguin : Bird
    {
        public override void Move()
        {
            Console.WriteLine("Penguin: Swimming");
        }
    }

}
