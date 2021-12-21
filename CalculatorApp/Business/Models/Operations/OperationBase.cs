using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Operations
{
    public abstract class OperationBase
    {
        public abstract double CalculateResult(double value1, double value2);

        public abstract void Printid();

    }
}
