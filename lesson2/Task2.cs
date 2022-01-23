using System;
using Xunit;

public class Lesson2Task2
{
    // O(n) по времени, O(n) - по памяти
    [Theory]
    [InlineData(new[] { 0, 1, 0, 1 }, new[] { 0, 0, 1, 1 })]
    [InlineData(new[] { 1, 1, 1, 0, 0, 0 }, new[] { 0, 0, 0, 1, 1, 1 })]
    [InlineData(new[] { 0 }, new[] { 0 })]
    [InlineData(new[] { 1 }, new[] { 1 })]
    private void CheckBinarySort(int[] list, int[] expected) =>
        Assert.Equal(expected, BinarySort(list));

    // Дан массив состоящий только из 0 и 1
    // Требуется отсортировать его
    private int[] BinarySort(int[] list)
    {
        var result = new int[list.Length];
        var zeroCounter = 0;
        foreach (var element in list)
        {
            if (element == 0)
                zeroCounter++;
        }

        for (int i = zeroCounter; i < result.Length; i++)
        {
            result[i] = 1;
        }

        return result;
    }
}