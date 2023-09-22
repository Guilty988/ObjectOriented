using System;
namespace OOP3
{
    public class TransportCredit : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("vehicle loan payment plan calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}

