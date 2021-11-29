using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("原数组：51,25,63,33,25,98,74,25,69,65");
            int[] a = new int[] { 51, 25, 63, 33, 25, 98, 74, 25, 69, 65 };
            int temp;
            for (int i = 1; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length-1; j++)
                {
                    if (a[j + 1] < a[j])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            Console.Write("冒泡排序：");
            foreach (int n in a)
            {
                Console.Write(n + " ");
            }
            Console.ReadLine();
        }
    }
}
