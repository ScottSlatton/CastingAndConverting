using System;

namespace Casting_and_Converting
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 789702395;
            long bigNum = num;

            // Works fine, no danger of data loss

            int i = 5;
            double d = 10.5;

            i = (int)d;  // Must explicitly cast

            Console.WriteLine("The Double variable d converted to int: " + i);
        }
    }
}
