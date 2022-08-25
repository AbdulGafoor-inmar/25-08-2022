using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeInput
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            Console.WriteLine("enter your name");
            string name = Console.ReadLine();
            try
            {
                if (name.Length > 10)
            {
                throw new Exception("your name should not be greater than 10");
            }
            Console.WriteLine("enter your age");
            
            
                 age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Hello " + name + " your age is " + age);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            
        }
    }
}
