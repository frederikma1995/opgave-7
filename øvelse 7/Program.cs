using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace øvelse_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a list of numbers, separated by spaces:  ");
            string line = Console.ReadLine();

            List<string> list = line.Split(' ').ToList();
            list.ForEach(Console.WriteLine);
            List<int> numbers = list.ConvertAll(s => Int32.Parse(s));

            Console.Write("The even numbers are ");
            var result = numbers.Where(a => a % 2 == 0).ToList();
            foreach (var item in result)
            {
                Console.Write(item);
                Console.Write(" ");

            }
            Console.WriteLine(".");

            Console.ReadLine();
        }
    }
}
