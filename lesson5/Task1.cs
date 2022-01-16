using System;
using Xunit;

public class Lesson5Task1
{
    [Theory]
    [InlineData(new []{1, 2, 3, 4, 5}, 6)]
    
    private void CheckFindSumMinMax(int[] input, int expected) =>
        Assert.Equal(expected, FindSumMinMax(input));

    // Дан массив чисел
    // надо найти сумму минимального и максимального числа
    private int FindSumMinMax(int[] input)
    {
        var min = input[0];
        var max = input[0];
        foreach (var i in input)
        {
            if (i < min) min = i;
            if (i > max) max = i;
        }

        return min + max;
    }
}