using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Part2.Abstract
{
   public abstract class CarDecoratorBase :CarBase 
    {
        private CarBase _carBase;
        public CarDecoratorBase(CarBase carBase) => _carBase = carBase;

    }
}
