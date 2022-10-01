using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 12;
            int count = 0;

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
                
            }
            if (count>2)
            {
                Console.WriteLine("Murekkeb ededdir");
            }
            else
            {
                Console.WriteLine("Sade ededdir");
            }
        }
    }
}