using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("原数组：51,25,63,33,25,98,74,25,69,65");
            int[] a = new int[] { 51, 25, 63, 33, 25, 98, 74, 25, 69, 65 };
            int j, temp;
            for (int d = a.Length / 2; d >= 1;d = d / 2)
            {
                for (int i = d; i < a.Length; i++)
                {
                    j = i - d;
                    temp = a[i];
                    while (j >= 0 && temp <= a[j])
                    {
                        a[j + d] = a[j];
                        j = j - d;
                    }
                    a[j + d] = temp;
                }

            }
            Console.Write("希尔排序：");
            foreach (int n in a)
            {
                Console.Write(n + " ");
            }
            Console.ReadLine();
        }
    }
}
