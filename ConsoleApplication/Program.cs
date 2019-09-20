using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 
            string name = "Logan Cratty";
            string location = "Rexburg, ID";

            //2
            Console.Write("enter name: ");
              string namee = Console.ReadLine();

            Console.Write("enter location: ");
            string locationn = Console.ReadLine();

            //3
            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"I'm from { location}");

            //4
            var currentDate = DateTime.Now;
            Console.WriteLine($"Today is {currentDate.ToString("d")}");

            //5
            var christmas = new DateTime(currentDate.Year,12, 25);
            Console.WriteLine($"date until Christmas {christmas}");
            //7
            Console.WriteLine("Press any key to end: ");
            Console.ReadKey();

        }
    }
}
