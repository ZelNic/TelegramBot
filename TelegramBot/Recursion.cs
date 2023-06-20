using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBot
{
    internal class Recursion
    {
        private static int total;

        public static int Sum(List<int> numbers)
        {
            if (numbers.Count == 1)
            {
                total += numbers[0];
                Console.WriteLine(total);
                return total;
            }
            else
            {
                total += numbers[numbers.Count - 1];
                if (numbers.Count != 1) numbers.RemoveAt(numbers.Count - 1);
                Sum(numbers);
                return total;
            }
        }
    }
}
