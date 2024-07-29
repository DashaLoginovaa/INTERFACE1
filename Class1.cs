using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFACE1
{
    internal class Calculator: ICalculator
    {
        public double Calculate(double x, double y)
        {
            return x + y;
        }

    }
}
