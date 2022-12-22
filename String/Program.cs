using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Gunjan";
            var lastName = "Goyal";

            var fullName = firstName + " " + lastName;
            Console.WriteLine("My full name is " + fullName);

            var myFullName = string.Format("My full name is {0} {1}", firstName, lastName);           
            Console.WriteLine(myFullName);

            var names = new string[3] { "Ginni","Vedant","Siddhant" };
            var formattedNames= string.Join(", ", names);
             Console.WriteLine(formattedNames);

            //Verbatim String
            //var text = " Hi Johan\n Look into this path\n c:\\folder1\\folder2\n c:\\folder3\\folder4";
            var text = @" Hi Johan
            Look into this path
            c:\folder1\folder2
            c:\folder3\folder4";
            Console.WriteLine(text);
            Console.ReadLine();
            

        }
    }
}
