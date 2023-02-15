using System;
using System.Linq;


namespace Micran_Test_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            char split = Console.ReadKey().KeyChar;
            Console.ReadLine();

            var length = int.Parse(Console.ReadLine());

            var collection = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray();

            string result = "";

            for (int i = 0; i < length; i++)
            {
                if (collection[i] > collection[length - 1])
                {
                    count++;
                    result += collection[i].ToString() + split;
                }
            }

            Console.WriteLine(count);

            if (count > 0)
            {
                Console.WriteLine(result.TrimEnd(split));
            }

            Console.ReadLine();
        }
    }
}