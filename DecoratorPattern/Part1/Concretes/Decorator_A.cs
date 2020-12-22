using DecoratorPattern.Part1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Part1.Concretes
{
    public class Decorator_A:IComponent
    {
        IComponent _component;
        public Decorator_A(IComponent component) => _component = component;

        public string Operation()
        {
            string text = _component.Operation();
            text += "With defined Software Networks ";
            return text;
        }
    }
}
