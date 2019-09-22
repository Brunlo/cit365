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
            //Get these values however you like.
            DateTime daysLeft = DateTime.Parse("12/25/2019 12:00:01 AM");
            DateTime startDate = DateTime.Now;

            //Calculate countdown timer.
            TimeSpan t = daysLeft - startDate;
            string countDown = string.Format("{0} Days, {1} Hours, {2} Minutes, {3} Seconds til launch.", t.Days, t.Hours, t.Minutes, t.Seconds);
            Console.WriteLine($"Days until Christmas {countDown}");

            //6
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            //7
            Console.WriteLine("Press any key to end: ");
            Console.ReadKey();

        }
    }
}
