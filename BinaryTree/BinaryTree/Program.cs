using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Node<T>
    {
        public T Data { get; set; }
        public Node<T> lchild;
        public Node<T> rchild;

        public Node()
        { }
        public Node(T data)
        {
            Data = data;
        }
        public Node(T data, Node<T> lchild, Node<T> rchild)
        {
            Data = data;
            this.lchild = lchild;
            this.rchild = rchild;
        }
    }
    class BinaryTree<T>
    {
        public Node<T> root;
        private int size;

        public BinaryTree(T data)
        {
            root = new Node<T>(data);
            size = 0;
        }

        //判树空
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
        //向p节点插入左孩子
        public void Insertlchild(T data, Node<T> p)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.lchild = p.lchild;
            p.lchild = newNode;
            size++;
        }
        //向p节点插入右节点
        public void Insertrchild(T data, Node<T> p)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.rchild = p.rchild;
            p.rchild = newNode;
            size++;
        }
        //删除节点p的左子树
        public Node<T> RemoveLchild(Node<T> p)
        {
            if (p == null || p.lchild == null)
                return null;
            Node<T> deleteNode = p.lchild;
            p.lchild = null;
            size--;
            return deleteNode;
        }
        //删除节点p的右子树
        public Node<T> RemoveRchild(Node<T> p)
        {
            if (p == null || p.rchild == null)
                return null;
            Node<T> deleteNode = p.rchild;
            p.rchild = null;
            size--;
            return deleteNode;
        }
        //先序遍历
        public void Pre(Node<T> node)
        {
            if (node != null)
            {
                Console.Write(node.Data + " ");
                Pre(node.lchild);
                Pre(node.rchild);
            }
        }
        //中序遍历
        public void Mid(Node<T> node)
        {
            if (node != null)
            {
                Mid(node.lchild);
                Console.Write(node.Data + " ");
                Mid(node.rchild);
            }
        }
        //后序遍历
        public void Pos(Node<T> node)
        {
            if (node != null)
            {
                Pos(node.lchild);
                Pos(node.rchild);
                Console.Write(node.Data + " ");
            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            BinaryTree<string> binaryTree = new BinaryTree<string>("A");
            Node<string> Root = binaryTree.root;
            binaryTree.Insertlchild("B",Root);
            binaryTree.Insertrchild("C", Root);
            binaryTree.Insertlchild("D", Root.lchild);
            binaryTree.Insertrchild("E", Root.lchild);
            binaryTree.Insertrchild("F", Root.rchild);

            Console.WriteLine("先序遍历：");
            binaryTree.Pre(Root);
            Console.WriteLine("\n中序遍历：");
            binaryTree.Mid(Root);
            Console.WriteLine("\n后序遍历：");
            binaryTree.Pos(Root);

            Console.ReadLine();
        }
    }
}
