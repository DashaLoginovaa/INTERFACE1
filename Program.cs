using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFACE1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Logger logger = new Logger();
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите первое число");
                    double x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    double y = Convert.ToDouble(Console.ReadLine());
                    double result = calculator.Calculate(x, y);
                    logger.Event($"Произведено сложение чисел {x} и {y}");
                    Console.WriteLine("Сумма равна" + " " + result);

                }
                catch (FormatException)
                {
                    logger.Error("Введено некорректное значение");
                    Console.ReadLine();
                }
            }
        }
    }
}
