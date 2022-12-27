using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Frist Number:");
            int sum1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Second Number:");
            int sum2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Perfect Resualt:");
            {
                if (sum1 >= 0 && sum2 >= 6 && sum1 < 7)
                    Console.WriteLine("6");
                if (sum2 >= 28 && sum1 <= 28)
                    Console.WriteLine("28");
                if (sum2 >= 496 && sum1 <= 496)
                    Console.WriteLine("496");
                if (sum2 >= 8128 && sum1 <= 8128)
                    Console.WriteLine("8128");
                if (sum2 >= 33550336 && sum1 <= 33550336)
                    Console.WriteLine("33550336");
            }
        }
    }
}
