using PrototypeDesignPattern.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g1 = new Game(2, "Uncharted", "War", true);
            Game g2 = (Game)g1.Clone();
            if (g1.Equals(g2))
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Different");
            }
            Console.Read();
        }
    }
}
