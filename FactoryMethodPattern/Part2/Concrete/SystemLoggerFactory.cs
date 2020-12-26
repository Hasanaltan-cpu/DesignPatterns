using FactoryMethodPattern.Part2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Part2.Concrete
{
    public class SystemLoggerFactory : ILoggerFactory
    {
        public ILogger createLogger()
        {
            new SystemLogger();
        }
    }
}
