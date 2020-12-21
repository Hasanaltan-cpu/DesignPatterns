using BuilderPattern.Part1.Concrete;
using BuilderPattern.Part1.Delegate;
using BuilderPattern.Part1.Directories;
using BuilderPattern.Part1.Interface;
using BuilderPattern.Part2.Abstract;
using BuilderPattern.Part2.Concretes;
using BuilderPattern.Part2.Directories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Part1
            Directory directory = new Directory();
            IBuilder builder_1 = new Builder_1();
            IBuilder builder_2 = new Builder_2();

            directory.Constructor(builder_1);
            Product p_1 = builder_1.GetProduct();
            p_1.Display();

            directory.Constructor(builder_2);
            Product p_2 = builder_2.GetProduct();
            p_2.Display();
            #endregion


            #region Part2

            ProductDirectory productDirectory = new ProductDirectory();
            ProductBuilder productBuilder = new A_ProductBuilder();
            productDirectory.GenerateProduct(productBuilder);

            var model = productBuilder.GetModel();
            Console.WriteLine(model.Id);
            Console.WriteLine(model.ProductName);
            Console.WriteLine(model.UnitPrice);
            Console.WriteLine(model.DiscountPrice);
            Console.WriteLine(model.DiscountedApplied);
            #endregion

            #region Part3


            #endregion


            Console.ReadKey();
        }
    }
}
