using System;

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
}
