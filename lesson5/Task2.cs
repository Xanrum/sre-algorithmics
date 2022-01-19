using System;
using System.Linq;
using Xunit;

public class Lesson5Task2
{
    [Theory]
    [InlineData(new[] { 1, 2, 4 }, 3)]
    [InlineData(new[] { 1, 2, 3 }, 4)]
    [InlineData(new[] { 5, 2, 1, 3 }, 4)]
    private void CheckFindSkip(int[] input, int expected) =>
        Assert.Equal(expected, FindSkip(input));

    // Дан массив чисел длины N-1
    // в массиве находятся числа от 1 до N, но одно число исключили
    // надо найти исключенное число
    // на всякий случай - еще раз, массив НЕ отсортирован
    private int FindSkip(int[] input)
    {
        var sumAll = (input.Length + 1) * (input.Length + 2) / 2;
        var sum = 0;
        foreach (var item in input)
        {
            sum += item;
        }

        return sumAll - sum;
    }

    private int FindSkipExt(int[] input) => Enumerable.Range(1, input.Length + 1).Sum() - input.Sum();
}