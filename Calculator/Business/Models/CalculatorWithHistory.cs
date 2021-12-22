using System;
using System.Collections.Generic;
using System.Linq;
using Business.Interfaces;
using Business.Operations;

namespace Business.Models
{
    public class CalculatorWithHistory : ICopy
    {
        public CalculatorWithHistory()
        {
            this.FullCopy = true;
        }

        private ValueInput Input { get; set; }

        public bool FullCopy { get; set; }

        public double Do()
        {
            double result = this.Input.Value;

            foreach (OperationBase op in this.Input.GetOperations())
            {
                result = op.CalculateResult(result);
            }

            return result;
        }

        public void Add(double value)
        {
            this.Input = new ValueInput(value);
        }

        public void Add(OperationBase op)
        {
            this.Input.AddOperation(op);
        }

        /// <summary>
        ///  TODO - Devolver en formato string, todos los inputs ingresados al momento
        ///  Formato: + 3 - 4 / 9
        /// </summary>
        /// <returns></returns>
        public string GetInputs()
        {
            string result = new string(String.Empty);

            foreach (OperationBase op in this.Input.GetOperations())
            {
                result += op.GetInput();
            }
            return result;

        }

        /// <summary>
        /// TODO - Como el 'GetInputs()' pero solamente las operaciones de suma
        /// </summary>
        /// <returns></returns>
        public string GetOnlyAddOperationInputs()
        {

            List<string> result = new List<string>();
            string list = new String("");

            foreach (OperationBase op in this.Input.GetOperations())
            {
                //Opcion 1
                //if (op.GetInput().Contains('+'))
                //{
                    //result += op.GetInput();
                //}

                result.Add(op.GetInput());

            }
                result.Where(e => e.Contains('+')).ToList().ForEach(a => list+=a);
                return list;
        }

        /// <summary>
        /// TODO - Devolver true si la 'operacion' esta contenida en la list de 'Operations'
        /// </summary>
        /// <param name="operation"></param>
        /// <returns></returns>
        public Boolean ContainsOperation(OperationBase operation)
        {

            foreach (OperationBase op in this.Input.GetOperations())
            {
                if (operation.Equals(op))
                {
                    return true; 
                }

            }
            return false;
        }
    }
}

// 4
// + 3
// / 2
// * 3
// - 3
// + 2