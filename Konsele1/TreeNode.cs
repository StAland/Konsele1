using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsele1
{
    public class TreeNode<T> where T : IVergleichbar<T>
    {
        public T Value { get; set; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }
        public int Height { get; private set; }

        public TreeNode(T value)
        {
            Value = value;
            Height = 1; // Initialhöhe eines neuen Knotens ist 1.
        }

        // Methode zum Hinzufügen mit Balancing.
        public TreeNode<T> Add(T value)
        {
            if (value.Vergleichen(Value) == Vergleich.smaller)
            {
                Left = Left?.Add(value) ?? new TreeNode<T>(value);
            }
            else if (value.Vergleichen(Value) == Vergleich.greater)
            {
                Right = Right?.Add(value) ?? new TreeNode<T>(value);
            }

            return Balance();
        }

        // Methode, um den Baum ausbalancieren.
        public TreeNode<T> Balance()
        {
            UpdateHeight();

            int balanceFactor = GetBalanceFactor();

            // Links schwerer
            if (balanceFactor > 1)
            {
                if (Left != null && Left.GetBalanceFactor() < 0)
                {
                    // Links-Rechts-Fall
                    Left = Left.RotateLeft();
                }
                // Links-Links-Fall
                return RotateRight();
            }

            // Rechts schwerer
            if (balanceFactor < -1)
            {
                if (Right != null && Right.GetBalanceFactor() > 0)
                {
                    // Rechts-Links-Fall
                    Right = Right.RotateRight();
                }
                // Rechts-Rechts-Fall
                return RotateLeft();
            }

            return this;
        }

        // Höhe des Knotens aktualisieren
        private void UpdateHeight()
        {
            int leftHeight = Left?.Height ?? 0;
            int rightHeight = Right?.Height ?? 0;
            Height = 1 + Math.Max(leftHeight, rightHeight);
        }

        // Balancefaktor berechnen
        private int GetBalanceFactor()
        {
            int leftHeight = Left?.Height ?? 0;
            int rightHeight = Right?.Height ?? 0;
            return leftHeight - rightHeight;
        }

        // Rechtsrotation
        private TreeNode<T> RotateRight()
        {
            var newRoot = Left;
            Left = newRoot?.Right;
            newRoot.Right = this;

            UpdateHeight();
            newRoot?.UpdateHeight();

            return newRoot;
        }

        // Linksrotation
        private TreeNode<T> RotateLeft()
        {
            var newRoot = Right;
            Right = newRoot?.Left;
            newRoot.Left = this;

            UpdateHeight();
            newRoot?.UpdateHeight();

            return newRoot;
        }
    }
}
