using System;
using Xunit;

public class Lesson2Task2
{
    [Theory]
    [InlineData(new[] { 0, 1, 0, 1 }, new[] { 0, 0, 1, 1 })]
    [InlineData(new[] { 0 }, new[] { 0 })]
    [InlineData(new[] { 1 }, new[] { 1 })]
    [InlineData(new[] { 1, 1, 1, 0, 0, 0 }, new[] { 0, 0, 0, 1, 1, 1 })]
    private void CheckBinarySort(int[] list, int[] expected) =>
        Assert.Equal(expected, BinarySort(list));

    // Дан массив состоящий только из 0 и 1
    // Требуется отсортировать его
    //O(N)
    private int[] BinarySort(int[] list)
    {
        var c = 0;
        foreach (var item in list)
        {
            if (item == 1) c++;
        }
        var res = new int[list.Length];
        for (int i = list.Length - c; i < res.Length; i++)
        {
            res[i] = 1;
        }
        return res;
    }
}