using DependencyInversion;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // High-level module using the abstraction
        ISwitchable lightBulb = new Light();
        lightBulb.TurnOff();
        lightBulb.TurnOn();

        Console.WriteLine();
    }
}