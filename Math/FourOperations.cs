using System;
namespace Math
{
	public class FourOperations
	{
		public void Plus(int number1,int number2)
		{
			int result = number1 + number2;
			Console.WriteLine("Result: " + result);
		}
        public void Minus(int number1, int number2)
        {
            int result = number1 - number2;
            Console.WriteLine("Result: " + result);
        }
        public void Multiplication(int number1, int number2)
        {
            int result = number1 * number2;
            Console.WriteLine("Result: " + result);
        }
        public void Divide(int number1, int number2)
        {
            int result = number1 / number2;
            Console.WriteLine("Result: " + result);
        }

    }
}

