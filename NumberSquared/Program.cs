using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSquared
{
    class Program
    {
        static int NumSqr(int num)
        {
            int sum = 0;
            int step = 1;
            for (int i = 0; i < num; i++)
            {
                sum += step;
                step += 2;
            }

            Console.WriteLine(sum);
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Number squared is: ");
            NumSqr(num);
        }
    }
}
