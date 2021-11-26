using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//链式栈的实现
namespace Stack
{
    class Program
    {
        static void printEmpty(StackSingleLinkedList<int> stack)
        {
            string s = "空";
            if (!stack.isEmpty())
            {
                s = "非空";
            }
            Console.WriteLine("判栈空：" + s);
        }
        static void Main(string[] args)
        {
            StackSingleLinkedList<int> stack = new StackSingleLinkedList<int>();
            printEmpty(stack);
            Console.WriteLine("0,1,2,3,4,5,6,7,8,9依次压栈");
            for (int i = 0; i < 10; i++)
            {
                stack.Push(i);
            }
            printEmpty(stack);
            Console.Write("出栈：");
            while (!stack.isEmpty())
            {
                Console.Write(stack.Pop()+" ");
            }
            GC.Collect();
            Console.ReadLine();
        }
    }
    public class Node<T>
    {
        public T Item { get; set; }
        public Node<T> next;
        //构造函数
        public Node() { }
        public Node(T item)
        {
            this.Item = item;
        }
    }
    public class StackSingleLinkedList<T>
    {
        private int index;
        private Node<T> head;

        //构造函数
        public StackSingleLinkedList()
        {
            this.head = null;
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
        //获取栈中节点个数
        public int Size
        {
            get
            {
                return this.index;
            }
        }
        //入栈
        public void Push(T item)
        {
            Node<T> oldNode = this.head;
            Node<T> newNode = new Node<T>(item);
            newNode.next = oldNode;
            this.head = newNode;
            this.index++;
        }
        //出栈
        public T Pop()
        {
            T item = this.head.Item;
            this.head = this.head.next;
            this.index--;
            return item;
        }
    }
}
