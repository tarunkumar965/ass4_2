using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass4_2
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        
        public string FullCarName
        {
            get
            {
                return $"{Make} {Model} {Year}";
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car
            {
                Make = "Toyota",
                Model = "Camry",
                Year = 2022
            };

            Console.WriteLine(myCar.FullCarName);
        }
    }
}
