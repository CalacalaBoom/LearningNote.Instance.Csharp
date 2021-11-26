using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleList
{
    class Program
    {
        //初始化双链表
        static void CreateDoubleLinkedList(DoubleLinkedList<int> list)
        {
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
        }
        //打印链表
        static void PrintDoubleLinkedList(DoubleLinkedList<int> list)
        {
            Console.WriteLine("链表为：");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + "<--->");
            }
            Console.Write("null\n");
        }
        //向链表结尾添加节点
        static void AddToLast(DoubleLinkedList<int> list)
        {
            Console.Write("请输入添加的节点：");
            string Sitem = Console.ReadLine();
            int item;
            if (int.TryParse(Sitem, out item))
            {
                list.Add(item);
            }
            else
            {
                Console.WriteLine("请输入数字");
            }
        }
        //向链表指定位置插入节点
        static void InsertToList(DoubleLinkedList<int> list)
        {
            Console.Write("请输入索引：");
            string Sindex = Console.ReadLine();
            int index;
            if (!int.TryParse(Sindex, out index))
            {
                Console.WriteLine("输入的索引不是数字");
                return;
            }
            Console.Write("请输入添加的节点:");
            string Sitem = Console.ReadLine();
            int item;
            if (!int.TryParse(Sitem, out item))
            {
                Console.WriteLine("请输入数字");
                return;
            }
            else
            {
                list.Insert(index,item);
            }
        }
        static void DeleteToList(DoubleLinkedList<int> list)
        {
            Console.Write("请输入索引：");
            string Sindex = Console.ReadLine();
            int index;
            if (!int.TryParse(Sindex, out index))
            {
                Console.WriteLine("输入的索引不是数字");
                return;
            }
            else
            {
                list.RemoveAt(index);
            }
        }
        static void Main(string[] args)
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            CreateDoubleLinkedList(list);
            PrintDoubleLinkedList(list);
            Console.WriteLine("1.向链表结尾添加节点  2.向链表指定位置插入节点  3.删除链表指定位置节点  0.Exit");
            bool isExit = true;
            do
            {
                Console.Write("请选择：");
                string i = Console.ReadLine();
                switch (i)
                {
                    case "1":
                        AddToLast(list);
                        PrintDoubleLinkedList(list);
                        break;
                    case "2":
                        InsertToList(list);
                        PrintDoubleLinkedList(list);
                        break;
                    case "3":
                        DeleteToList(list);
                        PrintDoubleLinkedList(list);
                        break;
                    case "0":
                        isExit = false;
                        break;
                }
            } while (isExit);
        }
    }

    //节点的定义
    public class Node<T>
    {
        public T Item { get; set; }
        public Node<T> pre { get; set; }
        public Node<T> next { get; set; }
        //构造函数
        public Node(){ }
        public Node(T item)
        {
            this.Item = item;
        }
    }

    public class DoubleLinkedList<T>
    {
        private int count; //统计节点个数
        private Node<T> head; //链表头节点
        public int Count
        {
            get
            {
                return this.count;
            }
        }
        //构造函数
        public DoubleLinkedList()
        {
            this.count = 0;
            this.head = null;
        }
        //根据索引获取节点
        public Node<T> GetNode(int index)
        {
            Node<T> tempNode = new Node<T>();
            if (index < 0 || index > this.count)
            {
                Console.WriteLine("索引超出范围");
            }
            else if (index == 0)
            {
                tempNode = this.head;
            }
            else
            {
                tempNode = this.head;
                for (int i = 0; i < index; i++)
                {
                    tempNode = tempNode.next;
                }
            }
            return tempNode;
        }
        //索引器
        public T this[int index]
        {
            get
            {
                return this.GetNode(index).Item;
            }
            set
            {
                this.GetNode(index).Item = value;
            }
        }
        //在尾节点后添加新节点
        public void Add(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node<T> preNode = GetNode(this.count - 1);
                preNode.next = newNode;
                newNode.pre = preNode;
            }
            this.count++;
        }
        //在指定位置后插入新节点
        public void Insert(int index, T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (index < 0 || index > this.count)
            {
                Console.WriteLine("索引超出范围");
            }
            else if (index == 0)
            {
                if (head == null)
                {
                    this.head = newNode;
                }
                else
                {
                    this.head.pre = newNode;
                    newNode.next = this.head;
                    this.head = newNode;
                }
            }
            else
            {
                Node<T> preNode = GetNode(index);
                Node<T> nextNode = preNode.next;
                preNode.next = newNode;
                newNode.pre = preNode;
                if (nextNode != null)
                {
                    newNode.next = nextNode;
                    nextNode.pre = nextNode;
                }
            }
            this.count++;
        }
        //删除指定位置处的节点
        public void RemoveAt(int index)
        {
            Node<T> preNode = GetNode(index - 1);
            if (index == 0)
            {
                this.head = this.head.next;
            }
            else if (index < 0 || index > this.count)
            {
                Console.WriteLine("索引超出范围");
            }
            else
            {
                Node<T> deleteNode = preNode.next;
                if (deleteNode.next != null)
                {
                    preNode.next = deleteNode.next;
                    deleteNode.next.pre = preNode;
                    deleteNode = null;
                }
            }
            this.count--;
        }
    }
}
