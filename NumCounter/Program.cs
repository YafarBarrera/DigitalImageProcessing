using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, min, max, numax=0, numin=0;
            Console.WriteLine("Enter 3 numbers");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());

            if (num1 >= num2) { max = num1; min = num2; } else { max = num2; min = num1; }

            if (max >= num3) {} else { max = num3;}

            if (num2 >= num3) {
                if (num2>=max) { max = num2; }
            } else { if (num3 >= max) { max = num3; } }


            if (min < num3) { } else { min = num3; }

            if (num2 < num3)
            {
                if (num2 < min) { min = num2; }
            }
            else { if (num3 < min) { min = num3; } }

            if (max==num1) { numax++; }
            if (max == num2) { numax++; }
            if (max == num3) { numax++; }

            if (min == num1) { numin++; }
            if (min == num2) { numin++; }
            if (min == num3) { numin++; }

            Console.WriteLine("El número mayor es:" + max + " y este se repite " + numax + " veces");
            Console.WriteLine("El número menor es:" + min + " y este se repite " + numin + " veces");
            Console.ReadKey();
        }
    }
}
