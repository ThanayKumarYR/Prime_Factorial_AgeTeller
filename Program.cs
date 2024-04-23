using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Factorial_AgeTeller
{
    internal class Program

    {

        static long Fact(int num) 
        {
            if (num == 0) return 1;
            else return num*Fact(num-1);
        }

        static void Isprime(int num) 
        {
            if (num == 0 || num == 1)
            {
                Console.WriteLine($"{num} is neither prime nor const.");
                return;
            }else if (num == 2)
            {
                Console.WriteLine($"{num} is a prime number.");
                return;
            }else 
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine($"{num} is not a prime number.");
                    return;
                }
                else 
                {
                    for (int i = 3; i <= Math.Sqrt(num); i += 2)
                    {
                        if (num % i == 0)
                        {
                            Console.WriteLine($"{num} is not a prime number.");
                            return;
                        }
                    }
                    Console.WriteLine($"{num} is a prime number");
                }
            }
        }
        static void Main(string[] args)

        {
            //Console.WriteLine(fact(30));
            //isprime(97);

            AgeTeller obg = new AgeTeller();
            Console.WriteLine($"Hello {obg.name} your age is {obg.tellage()}");

            Console.ReadLine();

        }
    }
}
