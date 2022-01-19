using System;
using System.Linq;
using Xunit;

public class Lesson1Task4
{
    [Theory]
    [InlineData(new[] { 0, 1, 1, 5, 6 }, new[] { -1, 1, 3, 5, 7 }, new[] { -1, 0, 1, 1, 1, 3, 5, 5, 6, 7 })]
    [InlineData(new[] { 0 }, new[] { 1 }, new[] { 0, 1 })]
    private void CheckSearchMin(int[] listA, int[] listB, int[] expected) =>
        Assert.Equal(expected, Merge(listA, listB));

    // Есть два отсортированных листа. Надо их смержить в новый отсортированный лист
    // O(N)
    private int[] Merge(int[] listA, int[] listB)
    {
        var res = new int[listA.Length + listB.Length];
        var (c, i, j) = (0, 0, 0);
        while (i < listA.Length && j < listB.Length)
        {
            if (listA[i] < listB[j])
            {
                res[c] = listA[i];
                ++i;
            }
            else
            {
                res[c] = listB[j];
                ++j;
            }

            ++c;
        }

        while (i < listA.Length)
        {
            res[c] = listA[i];
            ++i;
            ++c;
        }

        while (j < listB.Length)
        {
            res[c] = listB[j];
            ++j;
            ++c;
        }

        return res;
    }

    private int[] MergeExt(int[] listA, int[] listB)
    {
        var a = new int[listA.Length + listB.Length].ToList();
        a.AddRange(listA);
        a.AddRange(listB);
        a.Sort();
        return a.ToArray();
    }
}