using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Operations
{
    public class SubstractOperation : OperationBase
    {
        private string _id;

        public SubstractOperation()
        {
            this._id = "-";
        }

        public override double CalculateResult(double value1, double value2)
        {
            return value1 - value2;
        }

        public override void Printid()
        {
            Console.WriteLine(this._id);    
        }
    }
}
