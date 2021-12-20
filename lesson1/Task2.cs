using System;
using Xunit;

public class Lesson1Task2
{
    // O(1)
    [Theory]
    [InlineData(new[] { 2, 3, 4, 5, 6 }, 2)]
    [InlineData(new[] { 0, 2, 3, 5, 6, 100 }, 0)]
    [InlineData(new[] { 1000, 3000, 5000, 1000000 }, 1000)]
    private void CheckSearchMin(int[] list, int expected) => Assert.Equal(expected, SearchMin(list));

    // функция находящая минимальное значение в отсортированном листе
    private int SearchMin(int[] list) => list[0];
}