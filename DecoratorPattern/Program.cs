using DecoratorPattern.Part1.Clients;
using DecoratorPattern.Part1.Concretes;
using DecoratorPattern.Part1.Interface;
using DecoratorPattern.Part2.Client;
using DecoratorPattern.Part2.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Part1
            IComponent component = new Component();
            Client.Display("1.Basic Component:", component);
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Client.Display("2.Component A-Decorator added", new Decorator_A(component));
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Client.Display("3.Component B-Decorator added", new Decorator_B(component));
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Decorator_B decorator_B= new Decorator_B(new Component());
           
            Console.WriteLine("\t\t\t" + decorator_B.AdditionBehaviourOfDecoratorB());


            #endregion
            #region Part2

            //We ve not database that's why we create a car.
            var mycar = new SUV { Make = "Dodge", Model = "2019 Ram Power Wagon", HirePrice = 55000 };
            //It is assumed as a database please.

            HireOffer hireOffer = new HireOffer(mycar);
            hireOffer.DiscountPercentage = 10;

            Console.WriteLine("First Hire Price:{0}", mycar.HirePrice);
            Console.WriteLine("Discount Applied Price:{ 0}", hireOffer.HirePrice);
            #endregion
            Console.ReadKey();

        }
    }
}
