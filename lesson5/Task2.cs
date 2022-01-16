using System;
using System.Collections.Generic;
using Xunit;

public class Lesson5Task2
{
    [Theory]
    [InlineData(new []{1, 2, 4}, 3)]
    [InlineData(new []{4, 2, 1}, 3)]
    [InlineData(new []{6, 7, 2, 4, 3, 1}, 5)]
    
    private void CheckFindSkip(int[] input, int expected) =>
        Assert.Equal(expected, FindSkip(input));

    // Дан массив чисел длины N-1
    // в массиве находятся числа от 1 до N, но одно число исключили
    // надо найти исключенное число
    // на всякий случай - еще раз, массив НЕ отсортирован
    private int FindSkip(int[] input)
    {
        var result = new List<int>();
        for (int i = 1; i < input.Length + 1; i++)
            result.Add(i);

        foreach (var elem in input)
            result.Remove(elem);

        return result[0];
    }
}