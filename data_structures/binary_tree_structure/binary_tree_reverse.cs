using System;

namespace binary_tree_reverse
{
    class Program
    {
        /// <summary>
        /// test the binarytree class
        /// first create this binary tree and then reverse it
        ///         00
        ///       /    \ 
        ///     01      05
        ///   /    \       \
        /// 02      03      06
        ///        /       /
        ///      04     07
        /// </summary>
        static void Main(string[] args)
        {
            BinaryTree b = new BinaryTree(0);
            b.Left = new BinaryTree(1, new BinaryTree(2), new BinaryTree(3, new BinaryTree(4)));
            b.Right = new BinaryTree(5, null, new BinaryTree(6, new BinaryTree(7)));
            Console.WriteLine(b.ToString());
            b.Reverse();
            Console.WriteLine(b.ToString());
        }
    }

    /// <summary>
    /// the binary tree data structure implemented in c#
    /// </summary>
    public class BinaryTree
    {
        public int Value;
        public BinaryTree Left, Right;
        
        public BinaryTree(int value, BinaryTree left=null, BinaryTree right=null)
        {
            this.Value = value;
            this.Left = left;
            this.Right = right;
        }

        /// <summary>
        /// reverse the binary tree
        /// </summary>
        public void Reverse()
        {
            BinaryTree t = this.Left;
            this.Left = this.Right;
            this.Right = t;
            Left?.Reverse();
            Right?.Reverse();
        }

        public override string ToString()
        {
            return $"{this.Value:00}->[ {this.Left?.ToString()} , {this.Right?.ToString()} ]";
        }  
    }
}