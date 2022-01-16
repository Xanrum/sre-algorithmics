using System;
using System.Collections.Generic;
using Xunit;

public class Lesson5Task2
{
    [Theory]
    [InlineData(new []{1, 2, 4}, 3)]
    [InlineData(new []{4, 2, 1}, 3)]
    [InlineData(new []{6, 7, 2, 4, 3, 1}, 5)]
    [InlineData(new []{5, 7, 2, 4, 3, 1}, 6)]
    
    private void CheckFindSkip(int[] input, int expected) =>
        Assert.Equal(expected, FindSkip(input));

    // Дан массив чисел длины N-1
    // в массиве находятся числа от 1 до N, но одно число исключили
    // надо найти исключенное число
    // на всякий случай - еще раз, массив НЕ отсортирован
    private int FindSkip(int[] input)
    {
        var sum = 0;
        var expected = (input.Length + 1) * (input.Length + 2) / 2;

        foreach (var elem in input)
            sum += elem;

        return expected - sum;
    }
}