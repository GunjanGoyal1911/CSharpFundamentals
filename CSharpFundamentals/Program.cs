using CSharpFundamentals.Math;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
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
