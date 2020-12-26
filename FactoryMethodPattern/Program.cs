using FactoryMethodPattern.Part1.Creator;
using FactoryMethodPattern.Part1.Interface;
using FactoryMethodPattern.Part2.Concrete;
using FactoryMethodPattern.Part2.Creator;
using System;


namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Part1
            ProductCreator c = new ProductCreator();
            IProduct product;
            for (int month = 1; month < 12; month++)
            {
                product = c.FactoryMethod(month);
                Console.WriteLine("Coffee Beanssh" + product.ShipFrom());
            }
            #endregion
            #region Part2
            SystemManager systemManager = new SystemManager(new SystemLoggerFactory());
            systemManager.Save();
            #endregion 

            Console.ReadKey();
        }
    }
}
