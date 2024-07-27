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
            while (true)
            {
                try
                {
                    calculator.Calculate();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введено некорректное значение");
                    Console.ReadLine();
                }
            }
        }
    }
}
