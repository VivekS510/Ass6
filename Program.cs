using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first Value: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Value: ");
            int second = Convert.ToInt32(Console.ReadLine());
            int sum = first + second;
            if (sum >= 10 && sum <= 20)
            {
                Console.WriteLine("30");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(sum);
                Console.ReadLine();
            }
        }
    }
}
