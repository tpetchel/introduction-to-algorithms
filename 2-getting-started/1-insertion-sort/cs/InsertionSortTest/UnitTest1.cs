using System.Collections.Generic;
using Xunit;
using InsertionSort;

namespace InsertionSortTest
{
    public class UnitTest1
    {
        public static IEnumerable<object[]> TestDataAscending =>
        new List<int[][]>
        {
            new int[][] {
                new int[] {5, 2, 4, 6, 1, 3},
                new int[] {1, 2, 3, 4, 5, 6}
            },
            new int[][] {
                new int[] {31, 41, 59, 26, 41, 48},
                new int[] {26, 31, 41, 41, 48, 59}
            }
        };

        public static IEnumerable<object[]> TestDataDescending =>
        new List<int[][]>
        {
            new int[][] {
                new int[] {5, 2, 4, 6, 1, 3},
                new int[] {6, 5, 4, 3, 2, 1}
            },
            new int[][] {
                new int[] {31, 41, 59, 26, 41, 48},
                new int[] {59, 48, 41, 41, 31, 26}
            }
        };

        [Theory]
        [MemberData(nameof(TestDataAscending))]
        public void CanInsertionSort_Ascending(int[] a, int[] expected)
        {
            Class1<int>.InsertionSort(a, true);
            Assert.Equal(expected, a);
        }

        [Theory]
        [MemberData(nameof(TestDataDescending))]
        public void CanInsertionSort_Descending(int[] a, int[] expected)
        {
            Class1<int>.InsertionSort(a, false);
            Assert.Equal(expected, a);
        }
    }
}
