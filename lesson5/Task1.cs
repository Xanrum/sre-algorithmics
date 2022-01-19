using System;
using Xunit;

public class Lesson5Task1
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 6)]
    [InlineData(new[] { 50, -10, 2, 3 }, 40)]
    private void CheckFindSumMinMax(int[] input, int expected) =>
        Assert.Equal(expected, FindSumMinMax(input));

    // Дан массив чисел
    // надо найти сумму минимального и максимального числа
    private int FindSumMinMax(int[] input)
    {
        var (maxPos, minPos) = (0, 0);
        for (var i = 0; i < input.Length; i++)
        {
            if (input[i] < input[minPos]) minPos = i;
            if (input[i] > input[maxPos]) maxPos = i;
        }

        return input[minPos] + input[maxPos];
    }
}