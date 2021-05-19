using System;
using System.Collections;

namespace FizzBuzz
{
   public class Program
    {
        static void Main(string[] args)
        {
            var resultList = fizzbuzz(3);
            string result = resultList[resultList.Count - 1].ToString();
            Console.WriteLine(result);

        }

        // Simple fizzbuzz method. Prints Fizz if divisible by 3, buzz if divisible by 5, fuzz if divisible by 7.
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
                if (i % 7 == 0)
                {
                    output += "fuzz";
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

