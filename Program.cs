using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("please enter the first number");
            int Firstnumber = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter the second number");
            int secondnumber = int.Parse(Console.ReadLine());

            Console.WriteLine("------------------------------------------------");
            for (int f = Firstnumber; f <= secondnumber; f++)
            {

                int k;
                for (k = 2; k <= f; k++)
                {
                    if (f % k == 0)
                    {
                        break;
                    }

                }
                if (f == k)
                {

                    Console.WriteLine(f);

                }
            }
}
