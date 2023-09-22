using System;
using GenericsIntro;

namespace Math;
class Program
{
    static void Main(string[] args) {

        MyList<string> names = new MyList<string>();
        names.Add("Dogukan");
        Console.WriteLine(names.Lenght);
        names.Add("Zorer");
        Console.WriteLine(names.Lenght);
        foreach (var item in names.Items)
        {
            Console.WriteLine(item);
        }


    }




}
