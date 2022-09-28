using System;
using System.Collections.Generic;

namespace question2
{
    internal class Program
    {
        public static int fact(int n)
        {
            int i, fact = 1;
            if (n == 0)
            {
                return 1;
            }
            for (i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }

        public static void init(Dictionary<int, int> dict)
        {
            for (int i = 0; i <= 9; i++)
            {
                dict.Add(i, fact(i));
            }
        }
        static void Main(string[] args)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            init(dict);



            int sum = 0;
            for (int i = 3; i < 100000; i++)
            {
                int temp = i;
                int sum1 = 0;
                while (temp > 0)
                {
                    int rem = temp % 10;
                    sum1 += dict[rem];
                    temp = temp / 10;
                }
                if (sum1 == i)
                {
                    sum += i;
                }


            }
            Console.WriteLine(sum);
            Console.ReadKey();


        }
    }
}
