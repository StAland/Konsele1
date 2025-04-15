using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class BinaryTree
    {
        public TreeNode Root;

        public void Insert(int value)
        {
            Root = InsertRecursive(Root, value);
        }

        private TreeNode InsertRecursive(TreeNode node, int value)
        {
            if (node == null)
                return new TreeNode(value);

            if (value < node.Value)
                node.Left = InsertRecursive(node.Left, value);
            else if (value > node.Value)
                node.Right = InsertRecursive(node.Right, value);

            return node;
        }

        public bool Search(int value)
        {
            return SearchRecursive(Root, value);
        }

        private bool SearchRecursive(TreeNode node, int value)
        {
            if (node == null)
                return false;

            if (value == node.Value)
                return true;
            else if (value < node.Value)
                return SearchRecursive(node.Left, value);
            else
                return SearchRecursive(node.Right, value);
        }

        public void Delete(int value)
        {
            Root = DeleteRecursive(Root, value);
        }

        private TreeNode DeleteRecursive(TreeNode node, int value)
        {
            if (node == null) return null;

            if (value < node.Value)
            {
                node.Left = DeleteRecursive(node.Left, value);
            }
            else if (value > node.Value)
            {
                node.Right = DeleteRecursive(node.Right, value);
            }
            else
            {
                // Fall 1: Kein Kind
                if (node.Left == null && node.Right == null)
                    return null;

                // Fall 2: Ein Kind
                if (node.Left == null)
                    return node.Right;
                else if (node.Right == null)
                    return node.Left;

                // Fall 3: Zwei Kinder
                TreeNode minNode = FindMin(node.Right);
                node.Value = minNode.Value;
                node.Right = DeleteRecursive(node.Right, minNode.Value);
            }

            return node;
        }

        private TreeNode FindMin(TreeNode node)
        {
            while (node.Left != null)
                node = node.Left;
            return node;
        }

        public void PrintInOrder()
        {
            PrintInOrderRecursive(Root);
            Console.WriteLine();
        }

        private void PrintInOrderRecursive(TreeNode node)
        {
            if (node != null)
            {
                PrintInOrderRecursive(node.Left);
                Console.Write($"{node.Value} ");
                PrintInOrderRecursive(node.Right);
            }
        }
    }

}
