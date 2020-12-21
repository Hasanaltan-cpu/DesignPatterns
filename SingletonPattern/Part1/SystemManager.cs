using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Part1
{
    public class SystemManager
    {
        private static SystemManager _systemManager; // we definited a field

        private SystemManager()
        {
            //Main purpose is close to accesable from out.
        }

        //This method is major for creating an singleton object.

        public static SystemManager CreateSingletonObject()
        {
            if (_systemManager==null)
            {
                //_systemManager object is null i mean if it is empty return me SystemManager() object;
                _systemManager = new SystemManager();
            }
            //If it is not this object was created before.!!
            return _systemManager;//return me an object which was created.

        }

        public void SystemMessage()
        {
            Console.WriteLine("a");
            Console.ReadKey();
        }
    }
}
