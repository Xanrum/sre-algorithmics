using System;
using Xunit;

public class Lesson5Task1
{
    [Theory]
    [InlineData(new []{1, 2, 3, 4, 5}, 6)]
    [InlineData(new []{0}, 0)]
    [InlineData(new []{0, 0}, 0)]
    [InlineData(new []{2, 1, 100, 50}, 101)]

    private void CheckFindSumMinMax(int[] input, int expected) =>
        Assert.Equal(expected, FindSumMinMax(input));

    // Дан массив чисел.
    // Надо найти сумму минимального и максимального числа.
    private int FindSumMinMax(int[] input) {
        int min = input[0];
        int max = input[0];

        foreach(int item in input) {
            if (item < min) {
                min = item;
            }

            if (item > max) {
                max = item;
            }
        }

        return min + max;
    }
}