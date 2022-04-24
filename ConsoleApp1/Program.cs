using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();
            int[] list = new int[15];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = rand.Next(100);
                Console.WriteLine(i + " = " + list[i]);
            }

            Console.WriteLine("Aritmetic Mean = " + AritmeticMean(list));
            Console.ReadLine();
        }

        public static int AritmeticMean(int[] list)
        {
            int sum = 0;
            int countOfList = list.Length;
            foreach (int item in list)
            {
                sum += item;
            }
            return sum / countOfList;
        }
    }
}