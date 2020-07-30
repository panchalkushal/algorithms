using Algorithms.Algorithms;
using Data;
using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            bool procStop = false;
            while (true)
            {
                if (procStop) break;

                Console.WriteLine("\n\n**** **** **** ****");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Fibonacci implementation 1");
                Console.WriteLine("2. Fibonacci implementation 2");
                Console.WriteLine("**** **** **** ****");
                Console.Write("Enter your choice:");

                string readString = Console.ReadLine();
                string n = "";
                int num;

                switch (readString)
                {                    
                    case "1":
                        n = UserInput.GetFibN();
                        
                        if (int.TryParse(n, out num))
                        {
                            Fibonacci.GenerateFibN1(num);
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid input");
                        }

                        break;
                    case "2":
                        n = UserInput.GetFibN();     
                        
                        if (int.TryParse(n, out num))
                        {
                            Fibonacci.GenerateFibN2(num);
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid input");
                        }

                        break;
                    default:
                        procStop = true;
                        break;
                }
            }
        }
    }
}
