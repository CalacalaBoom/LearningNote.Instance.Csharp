using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("原数组：51,25,63,33,25,98,74,25,69,65");
            int[] a = new int[] { 51, 25, 63, 33, 25, 98, 74, 25, 69, 65 };
            int k=0;
            int temp;
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < a[k])
                    {
                        k = j;
                    }

                }
                temp = a[k];
                a[k] = a[i];
                a[i] = temp;
            }
            Console.Write("选择排序：");
            foreach (int n in a)
            {
                Console.Write(n + " ");
            }
            Console.ReadLine();
        }
    }
}
