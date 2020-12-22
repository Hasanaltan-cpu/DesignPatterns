using ChainOfResponsibilityPattern.Part3.Abstract;
using ChainOfResponsibilityPattern.Part3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Part3.Concrete
{
    public class Presedent : ExpenseHandlerBase
    {
        public override void HandleExpense(Expenses expense)
        {
            if (expense.Amount>5000)
            {
                Console.WriteLine("Presedent handle the expense..!");
            };
        }
    }
}
