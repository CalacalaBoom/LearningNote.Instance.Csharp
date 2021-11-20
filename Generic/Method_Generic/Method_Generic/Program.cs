using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Generic
{
    //建立一个公共类Finder
    public class Finder
    {
        public static int Find<T>(T[] items, T item)  //创建泛型方法
        {
            for (int i = 0; i < items.Length; i++)  
            {
                if (items[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = Finder.Find<int>(new int[] { 1, 2, 3, 4, 5, 6, 8, 9 }, 6);
            Console.WriteLine("6在数组中的位置："+i.ToString());
            Console.ReadLine();
        }
    }
}
