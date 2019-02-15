using System;

namespace TASK1
{
    class Program
    {
        public static bool Prime(int num) // create method to determine prime
        {
            bool ok = false;
            if (num == 1)
            {
                ok = true;
            }
            else
            {
                for (int i = 2; i < num; i++) // consider all the divisors of the number
                {
                    if (num % i == 0) // divide and determine
                    {
                        ok = true;
                        break;
                    }

                }
            }
            return ok;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // length of array
            string s = Console.ReadLine();
            string[] array = s.Split();// get array
            int cnt = 0; // get parameter to count primes
            for (int i = 0; i < n; i++) // consider all elements in array
            {
                int num = int.Parse(array[i]); //  get the string and transform to integer
                if (Prime(num) == false || num == 2) // checking for prime
                {
                    cnt++; // count
                }
            }
            Console.WriteLine(cnt); // withdraw count
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(array[i]);
                if (Prime(num) == false || num == 2) // repeat an operation
                {
                    Console.Write(num + " ");// withdraw primes
                }
            }
        }
    }
}
