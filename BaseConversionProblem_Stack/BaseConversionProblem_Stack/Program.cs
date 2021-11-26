using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConversionProblem_Stack
{
    class Node<T>
    {
        public T Item { get; set; }
        public Node<T> next { get; set; }
        public Node()
        {
        }
        //构造函数
        public Node(T item)
        {
            this.Item = item;
        }
    }
    class StackofBaseConversion<T>
    {
        private Node<T> first;
        private int index;
        //构造函数
        public StackofBaseConversion()
        {
            this.first = null;
            this.index = 0;
        }
        //判栈空
        public bool isEmpty()
        {
            if (this.index == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //入栈
        public void Push(T item)
        {
            Node<T> oldNode = this.first;
            this.first = new Node<T>(item);
            this.first.next = oldNode;
            this.index++;
        }
        //出栈
        public T Pop()
        {
            Node<T> popnode = this.first;
            T popitem = popnode.Item;
            this.first = popnode.next;
            popnode = null;
            this.index--;
            return popitem;
        }
        //获取栈的长度
        public int Size()
        {
            return this.index;
        }
    }
    class Program
    {
        static void trunPush(int De,int Ci,StackofBaseConversion<int> stack)
        {
            int flag=-1;
            while (flag != 0)
            {
                stack.Push(De % Ci);
                flag = De / Ci;
                De = flag;
            }
        }
        static void trunPop(StackofBaseConversion<int> stack)
        {
            while (true)
            {
                if (stack.isEmpty())
                {
                    break;
                }
                else
                {
                    Console.Write(stack.Pop());
                }
            }
            Console.WriteLine();
            
        }
        static void Main(string[] args)
        {
            StackofBaseConversion<int> stack = new StackofBaseConversion<int>();
            while (true)
            {
                Console.WriteLine("输入十进制数：");
                string sDe = Console.ReadLine();
                Console.WriteLine("要转换的进制（2进制、8进制）：");
                string sCi = Console.ReadLine();
                int De, Ci;
                if (!int.TryParse(sDe, out De))
                {
                    Console.WriteLine("十进制数输入不合法");
                }
                if (!int.TryParse(sCi, out Ci))
                {
                    Console.WriteLine("要转换的进制输入不合法");
                }
                else
                {
                    if (Ci != 8 && Ci != 2)
                    {
                        Console.WriteLine("只能转换成2进制、8进制");
                    }
                }
                trunPush(De,Ci,stack);
                Console.Write(Ci+"进制数为:");
                trunPop(stack);
            }
        }
    }
}
