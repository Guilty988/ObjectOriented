using System;

namespace ReferanceType;
class Program
{
    static void Main(string[] args)
    {


        Console.WriteLine("");

        int number1 = 10;
        int number2 = 30;
        number1 = number2;
        number2 = 65;
        //number1 ?? ans: 30 cause
        /*numerical types of variable int,double,float,decimal,bool equals = Value type
         * 
         */

        int[] numbers1 = new int[] {10,20,30};
        int[] numbers2 = new int[] { 100, 200, 300 };
        numbers1 = numbers2;
        numbers2[0] = 999;
        //number[0] ?? ans : 999 cause
        /* Array , Class , integer = reference Type
         * 
         */

        /* 
          Value Type and Reference Type
          A data type is a value type if it holds a data value within its own memory space.
          It means the variables of these data types directly contain values. All the value types derive from System.
          ValueType, which in-turn, derives from System.
         */

        /*
         * 
         What Does Reference Type Mean? A reference type is a code object that is not stored directly where it is created,
         but that acts as a kind of pointer to a value stored elsewhere.
         */


    }
}