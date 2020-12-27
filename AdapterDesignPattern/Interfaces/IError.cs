using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Interfaces
{
    interface IError
    {
        int ErrorNumber { get; set; }
        string Description { get; set; }
        void SendMail();
    }
}
