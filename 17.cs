using System;
using System.Linq;

namespace _17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] array = new int[500];
            int max = -1000001;
            int count = 0;
            int minsum = 3000001;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-1000000, 1000000);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max && array[i] % 100 == 15)
                {
                    max = array[i];
                }
            }
            for (int i = 2; i < array.Length; i++)
            {
                int[] set = new int[3];
                int check = 0;
                set[0] = array[i];
                set[1] = array[i - 1];
                set[2] = array[i - 2];
                for (int j = 1; j < set.Length; j++)
                {
                    if (set[j] > 999 && set[j] < 10000)
                    {
                        check++;
                    }
                }
                if (check == 1)
                {
                    if (set.Sum() < max)
                    {
                        count++;
                        if (set.Sum() < minsum)
                        {
                            minsum = set.Sum();
                        }
                    }
                }
            }
            Console.WriteLine(count + ", " + minsum);
        }
    }
}
