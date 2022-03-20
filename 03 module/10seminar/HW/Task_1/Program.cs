using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class BTnode<T>
        where T: IComparable
    {
        private T Value { get; }
        private int Count { get; set; }
        public BTnode<T> Left { get; private set; }
        public BTnode<T> Right { get; private set; }

        public BTnode(T value, BTnode<T> left = null, BTnode<T> right = null)
        {
            Value = value;
            Left = left;
            Right = right;
            Count = 1; 
        } 
        
        public void InsertValue(T newValue)
        {
            if (newValue.CompareTo(Value) > 0)
            {
                if (Right is null)
                {
                    Right = new BTnode<T>(newValue);
                    return;
                }
                Right.InsertValue(newValue);
            }
            else if (newValue.CompareTo(Value) < 0)
            {
                if (Left is null)
                {
                    Left = new BTnode<T>(newValue);
                    return;
                }
                Left.InsertValue(newValue);
            }
            Count++;
        }

        public override string ToString() => $"{Value} -> {Count}";
    }
    class BinaryTree<T> 
        where T: IComparable
    {
        public BTnode<T> Root { get; private set; }
        private bool IsEmpty => Root is null;
        public void Insert(T value)
        {
            if (IsEmpty)
            {
                Root = new BTnode<T>(value);
                return;
            }
            Root.InsertValue(value);
        }
        
        public void Preorder(BTnode<T> root)
        {
            if (root is null)
                return;
            Console.WriteLine($"{root} ");
            Preorder(root.Left);
            Preorder(root.Right);
        }
        public void Inorder(BTnode<T> root)
        {
            if (root is null)
                return;
            Inorder(root.Left);
            Console.WriteLine($"{root} ");
            Inorder(root.Right);
        }
        public void Postorder(BTnode<T> root)
        {
            if (root is null)
                return;
            Postorder(root.Left);
            Postorder(root.Right);
            Console.WriteLine($"{root} ");
        }
        
        public void Cascade(BTnode<T> root)
        {
            var nodes = new Queue<BTnode<T>>();
            nodes.Enqueue(root);
            while (nodes.Count > 0)
            {
                var node = nodes.Dequeue();
                if (node.Left is not null)
                {
                    nodes.Enqueue(node.Left);
                }
                if (node.Right is not null)
                {
                    nodes.Enqueue(node.Right);
                }
                Console.Write($"{node} ");
            }
            
            Console.WriteLine();
        }
        public void Print()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Не дерево!");
                return;
            }
            
            Inorder(Root);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var binaryTree = new BinaryTree<int>();
            binaryTree.Print();
            
            for (var i = 1; i < 10; i++)
            {
                binaryTree.Insert(i);
            }
            binaryTree.Cascade(binaryTree.Root);
            binaryTree.Preorder(binaryTree.Root);
            binaryTree.Postorder(binaryTree.Root);
            binaryTree.Inorder(binaryTree.Root);
        }
    }
}