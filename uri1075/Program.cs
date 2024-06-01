using System;
using System.Globalization;

namespace testes_ec
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            if (n < 10000)
            {
                for (int x = 1; x <= 10000; x++)
                {
                    if (x % n == 2)
                    {
                        Console.WriteLine(x);
                    }
                }
            }

        }

    }

}