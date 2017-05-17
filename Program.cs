using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt
            Console.WriteLine("Welcome to the best calculator");
            Console.WriteLine("Please type numbers using characters not words. 1 not one");
            Console.WriteLine("Addition: use key + or word add");
            Console.WriteLine("Subtraction: use key - or word subtract");
            Console.WriteLine("Multiplication: use key * or word multiply");
            Console.WriteLine("Division: use key / or word divide");
            Console.WriteLine("Clear: clear");
            Console.WriteLine("Final answer: out");

            
            var instance = new Mathymath();
            instance.PerformCalculation();

            Console.WriteLine("Do you want to do another calculation?");
            string go = Console.ReadLine();
            if (go == "Y")
            {
                var instanceRepeat = new Mathymath();
                instanceRepeat.PerformCalculation();
            }
            Console.WriteLine("PAKC");
            Console.Read();
        }//main
    }//program
}
