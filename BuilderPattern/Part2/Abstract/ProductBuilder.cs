using BuilderPattern.Part2.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Part2.Abstract
{
   public abstract class ProductBuilder
    {
        public abstract void GetProductData();
        public abstract void ApplyDiscount();

        public abstract ProductModel GetModel();

    }
}
