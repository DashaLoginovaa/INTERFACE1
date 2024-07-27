using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFACE1
{
    internal class Calculator: ICalculator
    {
        public double Calculate()
        {
            Console.WriteLine("Введите два числа");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double z = x + y;
            Console.WriteLine("Сумма равна" + " " + z);
            return z;
        }
    }
}
