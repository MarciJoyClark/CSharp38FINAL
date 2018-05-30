using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOptional
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("I would like 2 numbers, though I don't require the second. Enter the first, now.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Great! Now a second (or not!)");
            string userInput2 = Console.ReadLine();            
                if (String.IsNullOrEmpty(userInput2))
                {
                    int variable = Option.option(userInput);
                    Console.WriteLine("Your first number times 10 = " + variable + ".");
                }
                else
                {
                    int variable = Option.option(userInput);
                    int userInput3 = Convert.ToInt32(userInput2);
                    int variable2 = Option.option2(userInput3);
                    Console.WriteLine("Your first number times 2 = " + variable + ".  Your second times 2 = " + variable2 + ".");
                }
                Console.ReadLine();            
        }
    }
}
