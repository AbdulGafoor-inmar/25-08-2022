using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caluculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  Simple Caluculator *****");
            Console.WriteLine("enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            Console.WriteLine("enter operation");
            string op = Console.ReadLine();
            if(op=="+")
            {
                result = num1 + num2;
            }
            else if (op == "-")
            {
                result = num1 - num2;
            }
            else if (op == "*")
            {
                result = num1 * num2;
            }
            else if (op == "/")
            {
                result = num1 / num2;
            }
            else if (op == "%")
            {
                result = num1 % num2;
            }
            Console.WriteLine("the result is : "+result );
        }
    }
}
