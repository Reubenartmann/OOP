﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_week_2_sem_2
{
    // This is a Fibonacci and Prime number generator
    class Program
    {
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        static void Main()
        {

            //Console.WriteLine("Fibonacci sequence");
            //for (int i = 0; i < 15; i++)
            //{
            //    Console.WriteLine(Fibonacci(i));
            //}


            bool isPrime = true;
            Console.WriteLine("Prime Numbers : ");
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= 100; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    Console.Write("\n" + Fibonacci(i));
                }
                isPrime = true;
            }

            Console.ReadLine();
        }
    }
}
