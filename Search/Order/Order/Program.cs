using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.Write("顺序表为：");
            foreach (int i in list)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("\n---------顺序查找----------");
            Console.Write("查找6：");
            OrderSearch(list, 6);
            Console.Write("查找1：");
            OrderSearch(list, 1);
            Console.Write("查找10：");
            OrderSearch(list, 10);
            Console.WriteLine("\n---------二分查找----------");
            Console.Write("查找6：");
            SeqSearch(list, 6);
            Console.Write("查找1：");
            SeqSearch(list, 1);
            Console.Write("查找10：");
            SeqSearch(list, 10);
            Console.ReadLine();
        }
        //顺序查找
        static void OrderSearch(int[] list, int key)
        {
            bool flag = false;
            int index = 0;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == key)
                {
                    index = i;
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("找不到");
            }
        }
        //二分查找
        static void SeqSearch(int[] list,int key)
        {
            bool flag = false;
            int low = 0;
            int high = list.Length - 1;
            int mid = (low + high) / 2;
            while ( low <= high )
            {
                mid = (low + high) / 2;
                if (list[mid] == key)
                {
                    flag = true;
                    break;
                }
                else if (list[mid] < key)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            if (flag)
            {
                Console.WriteLine(mid);
            }
            else
            {
                Console.WriteLine("找不到");
            }
        }
    }
}
