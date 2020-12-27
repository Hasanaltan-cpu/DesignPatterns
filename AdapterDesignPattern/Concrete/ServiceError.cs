using AdapterDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Concrete
{
    public class ServiceError : IError
    {
        private int _errorNumber;
        private string _description;

        public int ErrorNumber { get => _errorNumber; set => _errorNumber=value; }
        public string Description { get => _description; set => _description=value; }

        public void SendMail()
        {
            Console.WriteLine("{0} {1} => Service Error has been sent", ErrorNumber.ToString(), Description);
        }
    }
}
