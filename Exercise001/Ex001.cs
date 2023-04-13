/*
 * Exercise 001:
 * 
 * Write a program which will find all such numbers which are divisible by 7 but 
 * are not a multiple of 5, between 2000 and 3200 (both included).
 * The numbers obtained should be printed in a comma-separated 
 * sequence on a single line.
*/

using System;
using System.Text;

namespace Exercise001
{
    public class Ex001
    {
        private static void Main() { }

        public static string Solve(int low, int high)
        {
            StringBuilder result = new StringBuilder();

            for(; low <= high; low++)
            {
                if(low % 7 == 0 && low % 5 != 0)
                {
                    result.Append($"{low},");
                }
            }
            // return the result without last comma
            return result.ToString().TrimEnd(',');
        }
    }
}
