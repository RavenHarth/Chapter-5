﻿using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number A: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number B: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Enter third number C: ");
            int c = Int32.Parse(Console.ReadLine());

            if (a > b)
                if (a > c) Console.WriteLine("A is the biggest");
                else if (a < c) Console.WriteLine("C is the biggest");
                else Console.WriteLine("A and C are the biggest");
            else if (a < b)
                if (b > c) Console.WriteLine("B is the biggest");
                else if (b < c) Console.WriteLine("C is the biggest");
                else Console.WriteLine("B and C are the biggest");
            else if (a == b)
                if (a == c) Console.WriteLine("All are equal");
                else if (a < c) Console.WriteLine("C is the biggest");
                else Console.WriteLine("A and B are the biggest");
        }
    }
}
   