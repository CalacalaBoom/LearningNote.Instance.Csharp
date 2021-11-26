using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//队列的链式实现
namespace QueueLinkedList
{
    class Node<T>
    {
        public T Item { get; set; }
        public Node<T> next { get; set; }
        //构造函数
        public Node()
        { }
        public Node(T item)
        {
            Item = item;
        }
    }
    class queueLinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int size;
        //初始化队列
        public queueLinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }
        //判队空
        public bool isEmpty()
        {
            if (size == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //入队
        public void EnQueue(T item)
        {
            Node<T> oldNode = tail;
            Node<T> newNode = new Node<T>(item);
            if (size == 0)
            {
                tail = newNode;
                head = tail;
            }
            else
            {
                oldNode.next = newNode;
                tail = newNode;
            }
            size++;
        }
        //出队
        public T DeQueue()
        {
            Node<T> DeNode = head;
            T item = head.Item;
            DeNode = null;
            head = head.next;
            size--;
            if (isEmpty())
            {
                tail = head = null;
            }
            return item;
        }
        //获取队列长度
        public int Size()
        {
            return size;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            queueLinkedList<int> queue = new queueLinkedList<int>();
            Console.WriteLine("0，1，2，3，4，5，6，7，8，9入队");
            for (int i = 0; i < 10; i++)
            {
                queue.EnQueue(i);
            }
            Console.WriteLine("出队：");
            while (!queue.isEmpty())
            {
                Console.Write(queue.DeQueue()+" ");
            }
            Console.ReadLine();
        }
    }
}
