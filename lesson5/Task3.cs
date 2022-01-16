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
    private int FindSkip(int[][] input, int x) => throw new NotImplementedException();
}