using FactoryMethodPattern.Part1.Concrete;
using FactoryMethodPattern.Part1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Part1.Creator
{
  public  class ProductCreator:IProduct
    {
        public  IProduct FactoryMethod(int month)
        {
            if (month >= 4 && month <= 11)
            {
                return new Product_A();
            }
            else if {(month ==1 || month ==2 || month == 3 )
                {
                    return new Product_B();

                }

            }
            else
            {
                return new DefaultProduct();
            }
        }

        public string ShipFrom()
        {
            throw new NotImplementedException();
        }
    }
}
