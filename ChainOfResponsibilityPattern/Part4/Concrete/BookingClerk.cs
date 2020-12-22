using ChainOfResponsibilityPattern.Part4.Abstract;
using ChainOfResponsibilityPattern.Part4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Part4.Concrete
{
   public  class BookingClerk : ExpenseBankHandle
    {
     

        public override void HandleBankAmount(Expense expense)
        {
            if (expense.Amount<= 1000)
            {
                Console.WriteLine("BookingClerk handle the expense..!");
            }
            else if (_next != null)
            {
                _next.HandleBankAmount(expense);
            };
            

        }
    }

}
