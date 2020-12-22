using DecoratorPattern.Part2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Part2.Client
{
   public  class HireOffer:CarDecoratorBase
    {
        private readonly CarBase _carBase;

        public override string Make { get ; set ; }
        public override string Model { get ; set ; }
        public override decimal HirePrice { get => _carBase.HirePrice - _carBase.HirePrice * DiscountPercentage / 100; set { } }
        public HireOffer(CarBase carBase) : base(carBase) => _carBase = carBase;
        public int DiscountPercentage { get; set; }
    }
}

