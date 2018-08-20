using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome");
            Console.WriteLine("I will count down the odd numbers between a range you give me");
            int input1 = 0;
            int input2 = 0;
            do
            {


                Console.WriteLine("Please enter the highest number");
                input1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the lowest number");
                input2 = int.Parse(Console.ReadLine());
                if (input2 >= input1)
                {
                    Console.WriteLine("PLease try again");
                }
            } while (input2 >= input1);
            
            for(int i = input1; i >= input2; i--)
            {
                if (i % 2 == 1)
                {

                    Console.WriteLine($"{i}");
                }
               

            }Console.ReadKey();

        }
    }
}
