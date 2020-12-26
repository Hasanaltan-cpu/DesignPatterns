using FactoryMethodPattern.Part2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Part2.Concrete
{
    public class PLSLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
           return new PLSLogger();
        }
    }
}
