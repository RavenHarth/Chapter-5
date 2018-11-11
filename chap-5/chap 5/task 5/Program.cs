using System;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int number = Int32.Parse(Console.ReadLine());

            switch (number)
            {
                case 0: Console.WriteLine("нула"); break;
                case 1: Console.WriteLine("едно"); break;
                case 2: Console.WriteLine("две"); break;
                case 3: Console.WriteLine("три"); break;
                case 4: Console.WriteLine("четири"); break;
                case 5: Console.WriteLine("пет"); break;
                case 6: Console.WriteLine("шест"); break;
                case 7: Console.WriteLine("седем"); break;
                case 8: Console.WriteLine("осем"); break;
                case 9: Console.WriteLine("девет"); break;
                default: Console.WriteLine("Wrong input, only 0-9"); break;
            }
        }
    }
}
