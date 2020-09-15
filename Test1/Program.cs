using System;
namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input: ");
            string s = Console.ReadLine();

            int[] numbers = new int[10];
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    numbers[int.Parse(s[i].ToString())]++;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                if (numbers[i] != 0)
                {
                    Console.WriteLine($"{i}: {numbers[i]}");
                }
            }

            Console.ReadKey();
        }
    }
}
