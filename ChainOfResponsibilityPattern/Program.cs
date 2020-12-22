using ChainOfResponsibilityPattern.Part1;
using ChainOfResponsibilityPattern.Part2.Abstract;
using ChainOfResponsibilityPattern.Part2.Concrete;
using ChainOfResponsibilityPattern.Part3.Concrete;
using ChainOfResponsibilityPattern.Part3.Model;
using ChainOfResponsibilityPattern.Part4.Concrete;
using ChainOfResponsibilityPattern.Part4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Part1
            Handler start = null;
            for (int i = 5; i >0; i--)
            {
                Console.WriteLine($"Handler {i} deals up a limit of {i*1000}");
                start = new Handler(i, start);

            }
            int[] request = { 20000, 999, 1500, 4500, 3850 };
            foreach (var item in request)
            {
                Console.WriteLine(start.HandlerRequest(item));

            }
            Console.ReadKey();
            #endregion

            #region Part2
            PlayerHandler aviPlayer = new HandlerAvi();
            PlayerHandler mp3Player = new Handlermp3();
            PlayerHandler mp4player = new Handlermp4();

            //First request follow the chains..

            mp3Player.nextHandler = mp4player;
            mp4player.nextHandler = aviPlayer;

            mp3Player.Player("video.mpg");
            mp3Player.Player("video.avi");
            mp3Player.Player("video.mp4");
            mp3Player.Player("video.swf");
            mp3Player.Player("video.mp3");

            #endregion

            #region Part3
            Manager manager = new Manager();
            VicePresedent vicePresedent = new VicePresedent();
            Presedent presedent = new Presedent();

            manager.SetHandler(vicePresedent);
            vicePresedent.SetHandler(presedent);

            Expenses officeStuff = new Expenses { Amount = 980, Details="Office Stuff"};
            manager.HandleExpense(officeStuff);

            Expenses Course = new Expenses { Amount = 2500, Details = "Course " };
            manager.HandleExpense(Course);

            Expenses expense = new Expenses { Amount = 5500, Details = " Expense " };
            manager.HandleExpense(expense);


            #endregion

            #region Part4
            BookingClerk bookingClerk = new BookingClerk();
            SemiManager semimanager = new SemiManager();
            Ceo ceo = new Ceo();
            Part4.Concrete.Ceo manager1 = new Part4.Concrete.Ceo();

            bookingClerk.SetHandler(semimanager);
            semimanager.SetHandler(ceo);

            Expense smallamountcredit = new  Expense { Amount = 1000 };
            bookingClerk.HandleBankAmount(smallamountcredit);

            Expense avarageamountcredit = new Expense { Amount = 2500 };
            semimanager.HandleBankAmount(avarageamountcredit);

            Expense bigamaountcredit = new Expense { Amount = 3500 };
            ceo.HandleBankAmount(bigamaountcredit);

            #endregion

        }
    }
}
