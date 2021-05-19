using System;
using System.Collections;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            fizzbuzz(100);

        }

        // Simple fizzbuzz method. Prints Fizz if divisible by 3, buzz if divisible by 5, bizz divisible by 11.
        public static ArrayList fizzbuzz(int n)
        {
            ArrayList answer = new ArrayList();
            for (int i = 1; i <= n; i++)
            {
                String output = "";
                if (i % 3 == 0)
                {
                    output += "fizz";
                }
                if (i % 5 == 0)
                {
                    output += "buzz";
                }
                if (i % 11 == 0)
                {
                    output += "bizz";
                }
                else if (output == "") { output = i.ToString(); }
                answer.Add(output);
                Console.WriteLine(output);
            }
            return answer;
        }
    }
}

