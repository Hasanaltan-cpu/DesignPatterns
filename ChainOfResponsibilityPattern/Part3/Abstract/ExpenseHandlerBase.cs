using ChainOfResponsibilityPattern.Part3.Model;


namespace ChainOfResponsibilityPattern.Part3.Abstract
{
   public abstract class ExpenseHandlerBase
    {
        protected ExpenseHandlerBase _next;

        public void SetHandler(ExpenseHandlerBase next) =>  _next = next;
        //Setter Dependency Injection

        public abstract void HandleExpense(Expenses expense);


         
    }

}
