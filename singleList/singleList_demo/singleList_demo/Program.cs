using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleList_demo
{
    //单链表节点的定义
    public class Node<T>
    {
        //数据域
        public T Item { get; set; }
        //指针域
        public Node<T> Next { get; set; }
        public Node() { }
        public Node(T item)
        {
            this.Item = item;
        }
    }
    //单链表的实现
    public class SingleLinkedList<T>
    {
        private int count; //当前链表节点个数
        private Node<T> head; //当前链表的头节点
        public int Count
        {
            get
            {
                return this.count;
            }
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
        //构造函数：构造空链表
        public SingleLinkedList()
        {
            this.count = 0;
            this.head = null;
        }
        //根据索引获取节点
        public Node<T> GetNode(int index)
        {
            if (index < 0 || index >= this.count)
            {
                Console.WriteLine("索引超出范围");
            }

            Node<T> node = this.head;
            for (int i = 0; i < index; i++)
            {
                node = node.Next;
            }
            return node;
        }
        //在链表尾插入新节点
        public void Add(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (this.head == null)
            {
                //如果当前链表为空则置为新节点
                this.head = newNode;
            }
            else
            {
                Node<T> preNode = this.GetNode(this.count - 1);
                preNode.Next = newNode;
            }
            this.count++;
        }
        //在指定位置插入新节点
        public void Insert(int index, T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (index < 0 || index > this.count)
            {
                Console.WriteLine("索引超出范围");
            }
            else if (index == 0)
            {
                if (this.head == null)
                {
                    this.head = newNode;
                }
                else
                {
                    newNode.Next = this.head;
                    this.head = newNode;
                }
            }
            else
            {
                Node<T> preNode = GetNode(index - 1);
                newNode.Next = preNode.Next;
                preNode.Next = newNode;
            }
            this.count++;
        }
        //移除指定位置的节点
        public void RemoveAt(int index)
        {
            if (index < 0 || index > this.count)
            {
                Console.WriteLine("索引超出范围");
            }
            else if (index == 0)
            {
                this.head = this.head.Next;
            }
            else
            {
                Node<T> preNode = GetNode(index - 1);
                if (preNode.Next == null)
                {
                    Console.WriteLine("索引超出范围");
                }
                else
                {
                    Node<T> deleteNode = preNode.Next;
                    preNode.Next = deleteNode.Next;
                    deleteNode = null;
                }
            }
            this.count--;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList<int> singleLinkedList = new SingleLinkedList<int>();
            for (int i = 0; i < 10; i++)
            {
                singleLinkedList.Add(i);
            }
            Console.Write("单链表为：");
            for (int i = 0; i < singleLinkedList.Count; i++)
            {
                Console.Write(singleLinkedList[i] + "--->");
            }
            Console.Write("null\n");
            //通过输入来完成操作
            Console.WriteLine("1.获取节点  2.在尾节点后插入新节点  3.在指定位置插入新节点  4.移除指定位置的节点  0.退出");
            bool isExit = true;
            do
            {
                Console.Write("\n请选择：");
                string i = Console.ReadLine();
                switch (i)
                {
                    case "1":
                        Console.Write("索引为：");
                        string index = Console.ReadLine();
                        int result;
                        if (int.TryParse(index, out result))  //int.TryParse(string s,out int result)返回布尔值，并将转换结果存放在result中
                        {
                            int itemOfnode = singleLinkedList.GetNode(result).Item;
                            Console.WriteLine("该节点为：" + itemOfnode);
                        }
                        else
                        {
                            Console.WriteLine("输入的不是数字");
                        }
                        break;
                    case "2":
                        Console.Write("插入新节点：");
                        string newNodeitem = Console.ReadLine();
                        int temp;
                        if (int.TryParse(newNodeitem, out temp))
                        {
                            singleLinkedList.Add(temp);
                        }
                        else
                        {
                            Console.WriteLine("输入的不是数字");
                        }
                        Console.Write("单链表为：");
                        for (int j = 0; j < singleLinkedList.Count; j++)
                        {
                            Console.Write(singleLinkedList[j] + "--->");
                        }
                        Console.Write("null\n");
                        break;
                    case "3":
                        Console.Write("索引为：");
                        string SIndex = Console.ReadLine();
                        int insertIndex;
                        if (!int.TryParse(SIndex, out insertIndex))
                        {
                            Console.WriteLine("输入的索引不是数字");
                        }
                        Console.Write("节点为：");
                        string SValue = Console.ReadLine();
                        int insertValue;
                        if (!int.TryParse(SValue, out insertValue))
                        {
                            Console.WriteLine("输入的节点不是数字");
                        }
                        singleLinkedList.Insert(insertIndex, insertValue);
                        Console.Write("单链表为：");
                        for (int k = 0; k < singleLinkedList.Count; k++)
                        {
                            Console.Write(singleLinkedList[k] + "--->");
                        }
                        Console.Write("null\n");
                        break;
                    case "4":
                        Console.Write("索引为：");
                        string Sdelete = Console.ReadLine();
                        int deleteIndex;
                        if (!int.TryParse(Sdelete, out deleteIndex))
                        {
                            Console.WriteLine("输入的索引不是数字");
                        }
                        singleLinkedList.RemoveAt(deleteIndex);
                        Console.Write("单链表为：");
                        for (int k = 0; k < singleLinkedList.Count; k++)
                        {
                            Console.Write(singleLinkedList[k] + "--->");
                        }
                        Console.Write("null\n");
                        break;
                    case "0":
                        isExit = false;
                        break;
                }
            } while (isExit);
        }
    }
}
