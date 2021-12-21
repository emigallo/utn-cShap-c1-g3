using Business.Models;
using Business.Models.Operations;
using System;

namespace ConsoleApp
{
     public class Program
    {
        static void Main(string[] args)
        {
           

         

            Calculator calc = new Calculator();

            OperationBase btnAdd = new AddOperation();
            OperationBase btnDiv = new DivideOperation();
            OperationBase btnMul = new MultiplyOperation();
            OperationBase btnSub = new SubstractOperation();

            btnAdd.Printid();
           Console.WriteLine( calc.CalculateResult(4,4,btnAdd) );
        }
    }
}
