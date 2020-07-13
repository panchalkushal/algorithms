using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Data
{
    public static class UserInput
    {
        public static string GetFibN()
        {
            Console.Write("Enter n:");
            return Console.ReadLine();            
        }

        public static bool ValidateInt(string i)
        {
            //^ = beginning of the string; the $ = the end of the string;  + = match one or more of what precedes it (number in this case)
            Regex regex = new Regex("^[0-9]+$");
            return regex.IsMatch(i);
        }

        public static void PrintWithSpace(int i)
        {
            Console.Write($"{i} ");
        }
    }
}
