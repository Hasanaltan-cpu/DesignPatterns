using ChainOfResponsibilityPattern.Part3.Abstract;
using ChainOfResponsibilityPattern.Part3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Part3.Concrete
{
    public class Manager : ExpenseHandlerBase
    {
        public override void HandleExpense(Expenses expense)
        {
            if (expense.Amount <=1000)
            {
                Console.WriteLine("Manager handle the expense..!");
            }
            else if (_next !=null)
            {
                _next.HandleExpense(expense);
            }
        }
    }
}
