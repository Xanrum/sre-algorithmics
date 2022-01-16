using System;
using System.Linq;
using Xunit;

public class Lesson5Task3
{
    [Theory]
    [InlineData(new[] { "1,2", "3,4" }, 4, 2)]
    private void CheckFindSkip(string[] rawInput, int x, int expected)
    {
        var input = rawInput.Select(p => p.Split(',').Select(int.Parse).ToArray()).ToArray();
        Assert.Equal(expected, FindSkip(input, x));
    }

    // Дан массив массивов чисел
    // каждый вложенный максив отсортирован и содержит уникальные значения
    // все вложенные массивы одинаковой длины
    // первое число каждого массива - больше последнего числа предыдущего массива
    // дано число, надо найти сумму индексов местоположения этого числа
    private int FindSkip(int[][] input, int x)
    {
        var leftBound = 0;
        var w = input.Length;
        var h = input[0].Length;
        var rightBound = w * h - 1;
        while (true)
        {
            var center = leftBound + (rightBound - leftBound) / 2;
            var centerValue = input[center/h][center%w];
            if (centerValue == x) return center/h + center%w;
            if (leftBound == rightBound) return -1;
            if (centerValue < x) leftBound = center + 1;
            if (centerValue > x) rightBound = center;
        }
    }
}