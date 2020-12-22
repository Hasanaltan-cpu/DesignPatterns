using ChainOfResponsibilityPattern.Part4.Abstract;
using ChainOfResponsibilityPattern.Part4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Part4.Concrete
{
    public class Ceo : ExpenseBankHandle
    {
        public override void HandleBankAmount(Expense expense)
        {
            if (expense.Amount > 3000)
            {
                Console.WriteLine("Ceo handle the expense..!");
            }
          
        }
    }
}
