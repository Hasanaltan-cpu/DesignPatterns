using ChainOfResponsibilityPattern.Part4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Part4.Abstract
{
   public abstract  class ExpenseBankHandle
    {
        protected ExpenseBankHandle _next;
        public void SetHandler(ExpenseBankHandle  next) => _next = next;
        //Setter Dependency Injection

        public abstract void HandleBankAmount(Expense expense);

    }
}
