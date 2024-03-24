using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace example_3_10_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool isComposite = false;

            WriteLine("Введите число для проверки на простоту:");
            string userInput = (ReadLine());
            int numberToTest = Convert.ToInt32(userInput);
            int divisor = 2;

            while (divisor <= numberToTest - 1)
            {
                int divider = numberToTest % divisor;

                if (divider == 0)
                {
                    isComposite = true;
                    break;
                }

                divisor++;
            }
            if (isComposite)
            {
                WriteLine("Число составное");
            }
            else
            {
                WriteLine("Число простое");
            }
        }
    }
}