using DecoratorPattern.Part1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Part1.Concretes
{
    public class Decorator_B:IComponent
    {
        IComponent _component;

        public Decorator_B(IComponent component) => _component = component;

        public string Operation()
        {
            string text = _component.Operation();
            text += "searching how it is used and ";
            return text;
        }

        public string AdditionBehaviourOfDecoratorB()
        {
            return "I m on the PostGraduate Step";
        }
    }
}
