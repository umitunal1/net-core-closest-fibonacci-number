using System;

namespace ClosestFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number: ");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("The closest Fibonacci is: {0}", ClosestFibonacci(i));
            Console.ReadLine();
        }

        static int ClosestFibonacci(int num)
        {
            if (num < 1)
            {
                return 0;
            }
            else if (num == 1)
            {
                return 1;
            }
            else
            {
                System.Collections.Generic.List<int> ListFibo = new System.Collections.Generic.List<int>();
                ListFibo.Add(1);
                ListFibo.Add(1);
                while (true)
                {
                    int index = ListFibo.Count;
                    ListFibo.Add(ListFibo[index - 1] + ListFibo[index - 2]);
                    if (ListFibo[ListFibo.Count - 1] > num)
                    {
                        break;
                    }
                }
                return ListFibo[ListFibo.Count - 1];
            }
        }
    }
}
