using System;

namespace Elevator
{
    internal class Program
    {

        public static int CountWaysToClimb(int A) // Fibonacci
        {
            if (A <= 2)
            {
                return A;
            }

            int[] ways = new int[A + 1];

            ways[0] = 1;
            ways[1] = 1;

            for (int i = 2; i <= A; i++)
            {
                ways[i] = ways[i - 1] + ways[i - 2];
            }

            return ways[A];
        }

        public static void Main(string[] args)
        {
            int A;
            do
            {
                Console.WriteLine("Enter the number of floors: ");
            } while (!int.TryParse(Console.ReadLine(), out A) || A < 0);

            Console.WriteLine("Number of distinct ways to reach the top: " + CountWaysToClimb(A));
        }
    }
}
