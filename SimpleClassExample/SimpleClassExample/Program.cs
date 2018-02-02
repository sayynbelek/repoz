using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Class Types *****\n");

            Car Chuck = new Car();
            Chuck.PrintState();
            Car mary = new Car();
            mary.PrintState();
            Car daisy = new Car();
            daisy.PrintState();

            Motorcycle c = new Motorcycle(5);
            c.SetDriverName("Tiny");
            c.PopAWheely();
            Console.WriteLine("Rider name is {0}", c.name);
           
            Console.ReadLine();
        }
    }
}