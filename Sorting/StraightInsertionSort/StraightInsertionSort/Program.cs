using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StraightInsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("原序列：48，39，56，33，67，98，102，51，5");
            int[] a = new int[] { 48,39,56,33,67,98,102,51,5 };
            int j,temp;
            for (int i = 1; i <a.Length; i++)
            {
                j = i - 1;
                temp = a[i];
                while (j >= 0 && temp <= a[j])
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = temp;
            }
            Console.Write("直接插入排序：");
            foreach (int n in a)
            {
                Console.Write(n + " ");
            }
            Console.ReadLine();
            
        }
    }
}
