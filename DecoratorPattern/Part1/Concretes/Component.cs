using DecoratorPattern.Part1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Part1.Concretes
{
    public class Component:IComponent
    {
        public string Operation ()
        {
            return "I m Hasan ALTAN and";
        }
    }
}
