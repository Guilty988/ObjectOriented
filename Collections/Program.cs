using System;

namespace Math;
class Program
{

    static void Main(string[] args) {

        //new mean new referance adress
        //We dont use the arrays in real world

        /*string[] names = new string[] {"Doğukan","Murat","Kerem","Hakan"};
        Console.WriteLine(names[0]);
        Console.WriteLine(names[1]);
        Console.WriteLine(names[2]);
        Console.WriteLine(names[3]);

        for (int i = 0; i < names.Length; i++) {

            Console.WriteLine(names[i]);
        }
        */

        //Collection 
        List<string> names2 = new List<string>() { "Doğukan", "Murat", "Kerem", "Hakan" };
        Console.WriteLine(names2[0]);
        Console.WriteLine(names2[1]);
        Console.WriteLine(names2[2]);
        Console.WriteLine(names2[3]);
        names2.Add("İlker");
        Console.WriteLine(names2[4]);
        Console.WriteLine(names2[0]);



    }



}