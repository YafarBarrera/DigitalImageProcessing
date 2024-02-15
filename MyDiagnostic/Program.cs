using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDiagnostic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO FIBONACCI SEQUENCE CALCULATOR");
            Console.WriteLine("Enter a number of position you want to know!: ");
            int num1 =0,num2=1, fib=0;
            int num = int.Parse(Console.ReadLine());
            if (num >= 0)
            {
                if (num == 0)
                {
                    Console.WriteLine("The number is: " + fib);
                }
                else if (num == 1)
                {
                    Console.WriteLine("The number is: " + 1);
                }
                else
                {
                    num -= 1;
                    for (int i = 0; i < num; i++)
                    {
                        fib = num1 + num2;
                        num1 = num2;
                        num2 = fib;
                    }
                    Console.WriteLine("The number is: " + fib);
                }
            }          
            Console.ReadKey();
        }
    }
}
