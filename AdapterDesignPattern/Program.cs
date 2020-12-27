using AdapterDesignPattern.Concrete;
using AdapterDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Fax fax = new Fax { FaxErrorCode = 4000, ErrorDescription = "Don't get response" };

            IError[] errors =
            {
                new DbError{ErrorNumber=100,Description="Connection is not stable"},
                    new DbError{ErrorNumber=101,Description="Query not totally completed"},
                        new ServiceError{ErrorNumber=300,Description="Role is not approved"},
                        new FaxAdapter(fax)
            };

            foreach (IError error in errors)
            {
                error.SendMail();

                Console.ReadKey();

            }
        }
    }
}
