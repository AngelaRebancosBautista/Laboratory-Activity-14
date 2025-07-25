using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Activity_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("Enter your age in years (1 to 60): ");
            age = int.Parse(Console.ReadLine());

            if (age >= 1 && age <= 60)
            {
                if (age <= 12)
                {
                    Console.WriteLine("Classification: Child");
                }
                else if (age >= 13 && age <= 19)
                {
                    Console.WriteLine("Classification: Teen");
                }
                else if (age >= 20 && age <= 59)
                {
                    Console.WriteLine("Classification: Adult");
                }
                else
                {
                    Console.WriteLine("Classification: Senior");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Age must be between 1 and 60.");
            }
        }
    }
}

