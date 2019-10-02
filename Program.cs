using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            string inputString;
            //showing selection options
            do
            {
                Console.WriteLine("1-Enter triangle dimensions");
                Console.WriteLine("2-Exit");
                Console.WriteLine("Enter number: ");
                inputString = Console.ReadLine();
            } while (!(int.TryParse(inputString, out input)) || input < 0 || input > 3);
            

            //taking inputs
            if (input == 1)
            {
                Console.WriteLine("Enter number1");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter number2");
                int num2 = int.Parse(Console.ReadLine());
           
                Console.WriteLine("Enter number3");
                int num3 = int.Parse(Console.ReadLine());

                string output = TriangleSolver.Analyze(num1, num2, num3);
                Console.WriteLine(output);
            }
            //for exiting program
            else
            {
                Environment.Exit(-1);
            }

            Console.ReadLine();

        }
    }
}
