using System;
using Xunit;

public class Lesson1Task4
{
    [Theory]
    [InlineData(new[] { 0 }, new[] { 0 }, new[] { 0, 0 })]
    [InlineData(new[] { 0, 1, 1, 5, 6 }, new[] { -1, 1, 3, 5, 7 }, new[] { -1, 0, 1, 1, 1, 3, 5, 5, 6, 7 })]
    [InlineData(new[] { -10, -3, -2, 0, 1, 1, 5, 6 }, new[] { -1, 1, 3, 5, 7 }, new[] { -10, -3, -2, -1, 0, 1, 1, 1, 3, 5, 5, 6, 7 })] // вариант с листами разной длины
    private void CheckSearchMin(int[] listA, int[] listB, int[] expected) =>
        Assert.Equal(expected, Merge(listA, listB));

    // Есть два отсортированных массива. Надо их смержить в новый отсортированный массив.
    // O(n^2)
    private int[] Merge(int[] listA, int[] listB) {
        int[] listC = new int[listA.Length + listB.Length];
        int indexA = 0;
        int indexB = 0;
        int indexC = -1;

        do {
            indexC++;

            if (indexA >= listA.Length) {
                listC[indexC] = listB[indexB];
                indexB++;
                continue;
            }

            if (indexB >= listB.Length) {
                listC[indexC] = listA[indexA];
                indexA++;
                continue;
            }

            if (listA[indexA] <= listB[indexB]) {
                listC[indexC] = listA[indexA];
                indexA++;
            }
            else {
                listC[indexC] = listB[indexB];
                indexB++;
            }
        } while (indexA < listA.Length || indexB < listB.Length);

        return listC;
    }
}