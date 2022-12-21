using ClassBasic.Math;
using System;

namespace ClassBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person gunjan = new Person();
            gunjan.firstName = "Gunjan";
            gunjan.lastName = "Goyal";
            gunjan.age = 25;
            gunjan.Introduce();
            Calculator calculator = new Calculator();
            var result = calculator.Add(4, 5);
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
