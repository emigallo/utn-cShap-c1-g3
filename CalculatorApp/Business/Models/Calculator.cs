using Business.Models.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class Calculator
    {
        public double CalculateResult(double value1, double value2, OperationBase operation)
        {

            return operation.CalculateResult(value1, value2);
        }


    }


}
