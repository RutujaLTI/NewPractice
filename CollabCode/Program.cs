using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollabCode
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter num1:");
                    double num1 = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter num2:");
                    double num2 = Convert.ToInt64(Console.ReadLine());
                    if (num1 != 0 && num2 != 0)
                    {
                        new Program().sum(num1, num2);
                        new Program().product(num1, num2);
						new Program().diff(num1, num2);
                        new Program().div(num1, num2);
                        Console.ReadKey();
                        break;
                    }
                    else
                        Console.WriteLine("Number 0 not allowed");
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
            
        }

        public void sum(double num1, double num2)
        {
            Console.WriteLine("Sum is "+ (num1+num2));
        }
        public void product(double num1, double num2)
        {
            Console.WriteLine("Product is "+ (num1 * num2));
        }
        public void diff(double num1,double num2)
        {
            Console.WriteLine("Difference is " + (num1-num2));
        }
        public void div(double num1, double num2)
        {
            Console.WriteLine("Division is " + (num1 / num2));
        }
    }
}
