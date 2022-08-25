using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=n;i>=0;i--)
                Console.WriteLine(i);
        }
    }
}
