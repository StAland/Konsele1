using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{




    public class AVLTree
    {
        private AVLNode root;

        public void Insert(int value)
        {
            root = Insert(root, value);
        }

        private AVLNode Insert(AVLNode node, int value)
        {
            if (node == null)
                return new AVLNode(value);

            if (value < node.Value)
                node.Left = Insert(node.Left, value);
            else if (value > node.Value)
                node.Right = Insert(node.Right, value);
            else
                return node; // Duplikate ignorieren

            // Höhe aktualisieren
            node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));

            // Balance prüfen
            int balance = GetBalance(node);

            // Balancieren

            // Links-Links
            if (balance > 1 && value < node.Left.Value)
                return RotateRight(node);

            // Rechts-Rechts
            if (balance < -1 && value > node.Right.Value)
                return RotateLeft(node);

            // Links-Rechts
            if (balance > 1 && value > node.Left.Value)
            {
                node.Left = RotateLeft(node.Left);
                return RotateRight(node);
            }

            // Rechts-Links
            if (balance < -1 && value < node.Right.Value)
            {
                node.Right = RotateRight(node.Right);
                return RotateLeft(node);
            }

            return node;
        }

        private int GetHeight(AVLNode node) => node?.Height ?? 0;

        private int GetBalance(AVLNode node) => node == null ? 0 : GetHeight(node.Left) - GetHeight(node.Right);

        private AVLNode RotateRight(AVLNode y)
        {
            AVLNode x = y.Left;
            AVLNode T2 = x.Right;

            x.Right = y;
            y.Left = T2;

            y.Height = 1 + Math.Max(GetHeight(y.Left), GetHeight(y.Right));
            x.Height = 1 + Math.Max(GetHeight(x.Left), GetHeight(x.Right));

            return x;
        }

        private AVLNode RotateLeft(AVLNode x)
        {
            AVLNode y = x.Right;
            AVLNode T2 = y.Left;

            y.Left = x;
            x.Right = T2;

            x.Height = 1 + Math.Max(GetHeight(x.Left), GetHeight(x.Right));
            y.Height = 1 + Math.Max(GetHeight(y.Left), GetHeight(y.Right));

            return y;
        }

        public void PrintInOrder()
        {
            PrintInOrder(root);
            Console.WriteLine();
        }

        private void PrintInOrder(AVLNode node)
        {
            if (node != null)
            {
                PrintInOrder(node.Left);
                Console.Write($"{node.Value} ");
                PrintInOrder(node.Right);
            }
        }
    }

}
