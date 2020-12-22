using DecoratorPattern.Part1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Part1.Clients
{
    public class Client
    {

        public static void Display(string text,IComponent component)
        {
            Console.WriteLine(text + component.Operation());
        }

    }
}
