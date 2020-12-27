using AdapterDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Concrete
{
    public class DbError:IError
    {
        private int _errorNumber;
        private string _description;
        public int ErrorNumber
        {
            get { return _errorNumber; }
            set { _errorNumber = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
     int IError.ErrorNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void SendMail()
        {
            Console.WriteLine("{0} {1} => Db Failure Has been sent", ErrorNumber.ToString(), Description);
        }
    }
}
