using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("原数组：12,56,98,78,20,1,23,69,85,102");
            int[] a = new int[] { 12, 56, 98, 78, 20, 1, 23, 69, 85, 102 };
            QuickSort(a,0,a.Length-1);
            
            Console.Write("快速排序：");
            foreach (int n in a)
            {
                Console.Write(n + " ");
            }
            Console.ReadLine();
        }
        static void QuickSort(int[] a, int left, int right)
        {
            if (left < right)
            {
                int index = GetIndex(a, left, right);
                QuickSort(a, left, index - 1);
                QuickSort(a, index + 1, right);
            }
        }
        static int GetIndex(int[] a,int left,int right)
        {
            int temp = a[left];
            while (left < right)
            {
                while (left <right && a[right] > temp)
                {
                    right--;
                }
                a[left] = a[right];
                while (left < right && a[left] < temp)
                {
                    left++;
                }
                a[right] = a[left];
            }
            a[left] = temp;
            return left;
        }
    }
}
