using System;
using Xunit;

public class Lesson1Task4
{
    [Theory]
    [InlineData(new[] { 0, 1, 1, 5, 6 }, new[] { -1, 1, 3, 5, 7 }, new[] { -1, 0, 1, 1, 1, 3, 5, 5, 6, 7 })]
    [InlineData(new[] { 0 }, new[] { 0 }, new[] { 0, 0 })]
    private void CheckSearchMin(int[] listA, int[] listB, int[] expected) =>
        Assert.Equal(expected, Merge(listA, listB));

    //Асимптотика
    //Вычислительная О(N+M)
    //Память О(N+M)
    // Есть два отсортированных листа. Надо их смержить в новый отсортированный лист
    private int[] Merge(int[] listA, int[] listB)
    {
        var result = new int[listA.Length + listB.Length];
        var i1 = 0;
        var i2 = 0;
        var c = 0;
        while (i1 != listA.Length || i2 != listB.Length)
        {
            if (i2 == listB.Length || i1 != listA.Length && listA[i1] < listB[i2])
            {
                result[c] = listA[i1];
                i1++;
            }
            else
            {
                result[c] = listB[i2];
                i2++;
            }

            c++;
        }

        return result;
    }
}