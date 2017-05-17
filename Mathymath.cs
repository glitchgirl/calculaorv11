using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class Mathymath
    {
            decimal CurrentValue;
            decimal SelectedValue;
            decimal Output;
        public decimal PerformCalculation()
        {
            Console.Write("please input first value");
            string input = Console.ReadLine();
            Decimal.TryParse(input, out CurrentValue);
            Console.Write("Please input second value");
            string changing = Console.ReadLine();
            Decimal.TryParse(changing, out SelectedValue);
            Console.Write("Please input what you want to do");
            string math = Console.ReadLine();   

                //addition use key + or add
                if (math == "+" || math == "add")
                    CurrentValue = CurrentValue + SelectedValue;

                //subtraction use key - or subtract
                else if (math == "-" || math == "subtract")
                    CurrentValue = CurrentValue - SelectedValue;

                //multipication use key * or multiply 
                else if (math == "*" || math == "multiply")
                    CurrentValue = CurrentValue * SelectedValue;

                //division use key / or divide
                else if (math == "/" || math == "divide")
                {
                    if (SelectedValue != 0)
                        CurrentValue = CurrentValue / SelectedValue;
                    else
                    {
                        Console.Write("Can't divide by zero");
                        while (SelectedValue == 0)
                        {
                            Console.Write("Please put in second input");
                            string DontBdumb = Console.ReadLine();
                            Decimal.TryParse(DontBdumb, out SelectedValue);
                        }
                        CurrentValue = CurrentValue / SelectedValue;
                    }
                }

                // clear to clear 
                else if (math == "clear")
                {
                    CurrentValue = 0;
                    SelectedValue = 0;
                }

                //what was typed doesn't make sense
                else
                {
                    Console.Write("That's not an input");
                }

            //write answer
                Output = CurrentValue;
                Console.Write("Output:{0}", Output);
                return Output;
        }
    }
}
