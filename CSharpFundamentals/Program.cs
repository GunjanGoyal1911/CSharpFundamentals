using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public int age;

        public void Introduce()
        {
            Console.WriteLine("My name is " + firstName + " " + lastName);
            Console.WriteLine("My age is " + age);
        }

    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person gunjan = new Person();
            gunjan.firstName = "Gunjan";
            gunjan.lastName = "Goyal";
            gunjan.age = 25;
            gunjan.Introduce();
            Console.ReadLine();

        }
    }
}
