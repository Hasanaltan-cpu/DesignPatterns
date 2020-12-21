using SingletonPattern.Part1;
using SingletonPattern.Part2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Note:We can not create an Part1 class with "new" way.Because we will create objects with Singleton.
            #region Part1
            

            var systemManager = SystemManager.CreateSingletonObject();
            systemManager.SystemMessage();
            #endregion

            #region Part2
            int plus_1 = SingletonClass.Class.Calculate(5, 3);
            systemManager.SystemMessage();
            #endregion
        }
    }
}
