using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortierAlgorithmen
{
    public class QuickSorter
    {
        public static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(array, low, high);

                // Rekursiv QuickSort auf den linken und rechten Teil anwenden
                QuickSort(array, low, pi - 1);
                QuickSort(array, pi + 1, high);
            }
        }

        private static int Partition(int[] array, int low, int high)
        {
            // Pivot-Element (wir wählen das letzte Element als Pivot)
            int pivot = array[high];
            int i = (low - 1);  // Index des kleineren Elements

            for (int j = low; j < high; j++)
            {
                // Wenn das aktuelle Element kleiner oder gleich dem Pivot ist
                if (array[j] <= pivot)
                {
                    i++;
                    // Elemente tauschen
                    Swap(ref array[i], ref array[j]);
                }
            }

            // Das Pivot-Element an seine endgültige Position bringen
            Swap(ref array[i + 1], ref array[high]);
            return i + 1; // Index des Pivot-Elements
        }

        private static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
