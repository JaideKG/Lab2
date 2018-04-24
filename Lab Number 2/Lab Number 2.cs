using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Number_2
{
    class Program
    {
        static void Main(string[] args)

        {

            //Get Two Input Numbers
            Console.WriteLine("Welcome to the Grand Circus' Room Detail Generator!");
            Console.WriteLine("Please enter the length");
            double length = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter the width");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the height");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("area");
            double area = (length * width) * 2;
            Console.WriteLine(area);

            Console.WriteLine("perimeter");
            double perimeter = (width * 2) + (length * 2);
            Console.WriteLine(perimeter);

            Console.WriteLine("volume");
            double volume = width * length * height;
            Console.WriteLine(volume);

            Console.WriteLine("\nContinue? (yes/no)");
            string response;
            response = Console.ReadLine();

            
            if (response == "yes")
            {
                Console.WriteLine("");
            }

            else { };

          
            Console.ReadLine();
        }
    }
}
