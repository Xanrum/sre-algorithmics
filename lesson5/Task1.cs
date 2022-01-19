using System;
using Xunit;

public class Lesson5Task1
{
    // O(n) - по времени, O(1) - по памяти
    [Theory]
    [InlineData(new []{1, 2, 3, 4, 5}, 6)]
    [InlineData(new []{2, 1, 5, 4, 3}, 6)]
    [InlineData(new []{-100, 10, 800, 4, -200}, 600)]
    
    private void CheckFindSumMinMax(int[] input, int expected) =>
        Assert.Equal(expected, FindSumMinMax(input));

    // Дан массив чисел
    // надо найти сумму минимального и максимального числа
    private int FindSumMinMax(int[] input)
    {
        var min = int.MaxValue;
        var max = int.MinValue;
        foreach (var elem in input)
        {
            if (elem < min)
                min = elem;
            if (elem > max)
                max = elem;
        }

        return min + max;
    }
}