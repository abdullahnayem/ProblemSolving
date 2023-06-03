using System;

namespace FindHighest_LowestNumberFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); 
            int[] ArrayList = { 2, -4, 5, 2 };
            int HighestVal = FindHighest_LowestNumber(ArrayList);
            Console.WriteLine(HighestVal);

        }

        static int FindHighest_LowestNumber(int[] ArrayList)
        {
            int HighestValue = ArrayList[0];

            for (int i = 0; i < ArrayList.Length; i++)
            {
                if (HighestValue < ArrayList[i])
                {
                    HighestValue = ArrayList[i];
                }
            }
            return HighestValue;
        }


    }
}
