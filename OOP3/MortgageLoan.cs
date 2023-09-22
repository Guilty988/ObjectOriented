using System;
namespace OOP3
{
    public class MortgageLoan : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Mortgage loan payment plan calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}

