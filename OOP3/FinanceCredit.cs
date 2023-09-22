using System;
namespace OOP3
{
    public class FinanceCredit : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Finance loan payment plan calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}

