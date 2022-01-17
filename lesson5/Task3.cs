using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Xunit;

public class Lesson5Task3
{
    [Theory]
    [InlineData(new[]
    {
        "1,2",
        "3,4",
        "8,9"
    }, 8, 2)]
    [InlineData(new[]
    {
        "1,2,5",
        "8,10,12",
        "15,18,21"
    }, 12, 3)]
    [InlineData(new[] {"1,2", "3,4"}, 4, 2)]
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
        var height = input.Length;
        var width = input[0].Length;
        var leftIndex = 0;
        var rightIndex = width * height - 1;
        while (leftIndex <= rightIndex)
        {
            var middleIndex = (leftIndex + rightIndex) / 2;
            var firstIndex = middleIndex / width;
            var secondIndex = middleIndex % width;
            var middleValue = input[firstIndex][secondIndex];
            if (middleValue == x)
                return firstIndex + secondIndex;
            if (x < middleValue)
                rightIndex = middleIndex - 1;
            if (x > middleValue)
                leftIndex = middleIndex + 1;
        }

        return -1;
    }
}