using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sequence_arr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 63, 4, 24, 1, 3, 15 };
            Console.WriteLine("数组：63 4 24 1 3 15");
            Console.WriteLine("1.冒泡排序  2.直接插入排序  3.选择排序  0.Exit");
            bool isExit = true;
            do
            {
                string i = Console.ReadLine();
                switch (i)
                {
                    case "1":
                        Bubble(arr);
                        break;
                    case "2":
                        Insertion(arr);
                        break;
                    case "3":
                        Selection(arr);
                        break;
                    case "0":
                        isExit = false;
                        break;
                }
            } while (isExit);
        }
        //冒泡排序
        static void Bubble(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.Write("排序后的数组：");
            foreach (int n in arr)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
        //直接插入排序
        static void Insertion(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j = i;
                while ((j > 0) && (arr[j - 1] > temp))
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = temp;
            }
            Console.Write("排序后的数组：");
            foreach (int n in arr)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
        //选择排序
        static void Selection(int[] arr)
        {
            int min;
            for(int i=0;i<arr.Length;i++)
            {
                min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }
            Console.Write("排序后的数组：");
            foreach (int n in arr)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
    }
}
