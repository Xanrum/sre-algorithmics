using System;
using System.Reflection;
using Newtonsoft.Json.Linq;
using Xunit;

public class Lesson1Task4
{
    // O(n)
    [Theory]
    [InlineData(new[] { 0, 1, 1, 5, 6 }, new[] { -1, 1, 3, 5, 7 }, new[] { -1, 0, 1, 1, 1, 3, 5, 5, 6, 7 })]
    [InlineData(new[] { 0 }, new[] { 1 }, new[] { 0, 1 })]
    [InlineData(new[] { 0, 1, 1, 5, 6, 7, 8, 8, 9 }, new[] { -1, 1, 3, 5, 7 }, new[] { -1, 0, 1, 1, 1, 3, 5, 5, 6, 7, 7, 8, 8, 9 })]
    [InlineData(new[] { 0, 1, 1, 5, 6 }, new[] { -1, 1, 3, 5, 7, 8, 9, 9 }, new[] { -1, 0, 1, 1, 1, 3, 5, 5, 6, 7, 8, 9, 9 })]
    private void CheckSearchMin(int[] listA, int[] listB, int[] expected) =>
        Assert.Equal(expected, Merge(listA, listB));

    // Есть два отсортированных листа. Надо их смержить в новый отсортированный лист
    private int[] Merge(int[] listA, int[] listB)
    {
        var result = new int[listA.Length + listB.Length];
        
        var i = 0;
        var j = 0;
        var k = 0;
        while (true)
        {
            // хвосты
            if (i == listA.Length)
            {
                while (j < listB.Length)
                {
                    result[k] = listB[j];
                    k++;
                    j++;
                }
                break;
            }

            if (j == listB.Length)
            {
                while (i < listA.Length)
                {
                    result[k]=listA[i];
                    k++;
                    i++;
                } 
                break;
            }
            
            if (listA[i] <= listB[j])
            {
                result[k]=listA[i];
                k++;
                i++;
                continue;
            }
            if (listA[i] > listB[j])
            {
                result[k]=listB[j];
                k++;
                j++;
            }
        }

        return result;
    }
}