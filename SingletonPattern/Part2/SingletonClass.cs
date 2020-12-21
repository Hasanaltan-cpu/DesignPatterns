using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Part2
{
    public class SingletonClass
    { 
        private SingletonClass()
        {

        }

        private static SingletonClass _singleObject = new SingletonClass();

        public static SingletonClass Class
        {
            get { return _singleObject; }
        }
        public int Calculate(int s1,int s2)
        {
            return s1 * s2;
        }
    }
}
