using AdapterDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Concrete
{
    public class FaxAdapter : IError
    {
        private Fax _fax;

        public FaxAdapter(Fax fax)
        {
            _fax = fax;
        }
        public int ErrorNumber { get => _fax.FaxErrorCode; set => _fax.FaxErrorCode=value; }
        public string Description { get => _fax.ErrorDescription; set =>_fax.ErrorDescription=value; }

        public void SendMail()
        {
            Console.WriteLine("{0} {1} Fax Failure has been sent",ErrorNumber.ToString(),Description);
        }
    }
}
