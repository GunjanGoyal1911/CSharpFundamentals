using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryEnum
{ 
    public enum VehicleBrand
     {
        Volvo=1,
        Tesla=2,
        Polstar=3
     }

    internal class Program
    {
        static void Main(string[] args)
        {
            var brand = VehicleBrand.Volvo;
            Console.WriteLine((int)brand);

            var brandId = 2;
            Console.WriteLine((VehicleBrand)brandId);
            

            Console.WriteLine(brand.ToString());

            var brandName = "Polstar";
            var vehicleBrand=(VehicleBrand)Enum.Parse(typeof(VehicleBrand),brandName);
            Console.WriteLine(vehicleBrand);
            Console.ReadLine();

        }
    }
}
