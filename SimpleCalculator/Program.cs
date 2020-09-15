using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean completed = false;
            Boolean completed2 = false;
            Boolean completed3 = false;
            double secondNumber = 0;
            double firstNumber = 0;
                while (completed == false)
                {
                    try
                    {
                    
                        StringBuilder sb = new StringBuilder();

                        //Class to convert user input
                        InputConverter inputConverter = new InputConverter();

                        //Class to perform actual calculations
                        CalculatorUtil calculatorEngine = new CalculatorUtil();

                        if (completed2 == false)
                        {
                            Console.WriteLine("Enter the first number of the equation");

                            firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                            completed2 = true;
                        }
                        if (completed3 == false)
                        {
                            Console.WriteLine("Enter the second number of the equation");

                            secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                            completed3 = true;
                        }

                        Console.WriteLine("Enter the operation sign of the equation");
                        string operation = Console.ReadLine();

                        double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);
                        sb.Append("The result of " + String.Format("{0:0.00}", firstNumber) + operation + String.Format("{0:0.00}", secondNumber) + " is " + String.Format("{0:0.00}", result));
                    //String.Format("{0:0.00}", 123.4567m)
                    Console.WriteLine(sb.ToString());
                        completed = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);

                    }
                }
        }
    }
}
