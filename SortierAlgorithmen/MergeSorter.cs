namespace SortierAlgorithmen
{
    public class MergeSorter
    {
        public static void MergeSort(int[] array)
        {
            if (array.Length <= 1) return;

            int mid = array.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[array.Length - mid];

            Array.Copy(array, 0, left, 0, mid);
            Array.Copy(array, mid, right, 0, array.Length - mid);

            MergeSort(left);
            MergeSort(right);
            Merge(array, left, right);
        }

        private static void Merge(int[] array, int[] left, int[] right)
        {
            int l = 0, r = 0, a = 0;

            while (l < left.Length && r < right.Length)
            {
                if (left[l] <= right[r])
                    array[a++] = left[l++];
                else
                    array[a++] = right[r++];
            }

            while (l < left.Length)
                array[a++] = left[l++];

            while (r < right.Length)
                array[a++] = right[r++];
        }
    }
}
