using System;
using Xunit;

public class Lesson2Task2
{
    [Theory]
    [InlineData(new[] { 0, 1, 0, 1 }, new[] { 0, 0, 1, 1 })]
    [InlineData(new[] { 1, 1, 1, 0, 0, 0 }, new[] { 0, 0, 0, 1, 1, 1 })]
    private void CheckBinarySort(int[] list, int[] expected) =>
        Assert.Equal(expected, BinarySort(list));

    // Дан массив состоящий только из 0 и 1
    // Требуется отсортировать его
    private int[] BinarySort(int[] list) => throw new NotImplementedException();
}