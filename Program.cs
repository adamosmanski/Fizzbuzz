using System;
using System.Linq;

namespace Fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Enumerable.Range(1, 100).Select(x =>
            {
                var str = "";
                if (x % 3 == 0)
                {
                    str += "Fizz";
                }
                if (x % 5 == 0)
                {
                    str += "Buzz";
                }
                if (str == "")
                {
                    str += x.ToString();
                }
                return str;
            }).ToList().ForEach(Console.WriteLine);
        }
    }
}
