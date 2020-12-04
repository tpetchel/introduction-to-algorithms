using System;

namespace InsertionSort
{
    public static class Class1<T> where T : IComparable<T>
    {
        private static Func<T, T, bool> isGreater = (x, y) => x.CompareTo(y) > 0;
        private static Func<T, T, bool> isLesser = (x, y) => x.CompareTo(y) < 0;

        public static void InsertionSort(T[] a, bool ascending)
        {
            InsertionSort(a, ascending ? isGreater : isLesser);
        }

        public static void InsertionSort(T[] a, Func<T, T, bool> comparer)
        {
            for (int j = 1; j < a.Length; j++)
            {
                var key = a[j];
                // Insert A[j] into the sorted sequence A[1..j-1].
                var i = j - 1;
                while (i >= 0 && comparer(a[i], key))
                {
                    a[i + 1] = a[i];
                    i--;
                }
                a[i + 1] = key;
            }
        }
    }
}
