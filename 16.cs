using System;

namespace _16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int F(int n)
            {
                if (n == 1)
                {
                    return 1;
                }
                else if (n == 2)
                {
                    return 3;
                }
                else
                {
                    return F(n - 1) * n + F(n - 2) * (n - 1);
                }
            }
            int result = F(5);
            Console.WriteLine("Результат - " + result);
        }
    }
}
