using Business.Models;
using Business.Operations;
using Business.Utils;
using System;
using Console;


namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorWithHistory calc = new CalculatorWithHistory();

           string str = System.Console.ReadLine();
            System.Console.WriteLine(str);

            calc.Add(4);
            OperationBase add = new AddOperation(3.3);
            calc.Add(add);
            System.Console.WriteLine(add.GetInput());

            OperationBase mult = new MultiplyOperation(2.4);
            calc.Add(mult);
            System.Console.WriteLine(mult.GetInput());

            double result = calc.Do();
            System.Console.WriteLine(result);

            calc.Copy();

            System.Console.WriteLine("Contains " + calc.ContainsOperation(new MultiplyOperation(3.3)));
            System.Console.WriteLine("Cadena de string: " + calc.GetInputs());
            System.Console.WriteLine("Cadena de string solo suma: " + calc.GetOnlyAddOperationInputs());
        }

        //private static double CalculateResultAndShowInConsole(double val1, double val2, OperationBase op)
        //{
        //    //Calculator calc = new Calculator();

        //    //double result = calc.CalculateResult(val1, val2, op);
        //    //System.Console.WriteLine(result);

        //    //return result;
        //}

        
    }
}