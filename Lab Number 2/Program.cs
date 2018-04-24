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
            Console.WriteLine("Please enter the length");
            String input1 = Console.ReadLine();
            Console.WriteLine("Please enter the width");
            String input2 = Console.ReadLine();

            //int length1 = int.Parse(input1);
            //int width1 = int.Parse(input2);
            //int total = length1 + width1;
            int perimeter = input1[0] + input2[0];
            int area = input1[1] + input2[1];
            int ones = input1[2] + input2[2];
            if (((perimeter == input1[0] + input2[0]) && (area == input1[1] + input2[2])))
            {
                Console.WriteLine("True");

            }
            else
            {
                Console.WriteLine("False");
            }
            Console.ReadLine();
        }
    }
}
