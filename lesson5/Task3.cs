using System;
using System.Linq;
using Xunit;

public class Lesson5Task3
{
    [Theory]
    [InlineData(new[] { "1,2", "3,4" }, 4, 2)]
    [InlineData(new[] { "5,6", "10,11" }, 10, 1)]
    [InlineData(new[] { "100,101", "200,201" }, 1, -1)]
    private void CheckSumCoordinates(string[] rawInput, int x, int expected)
    {
        var input = rawInput.Select(p => p.Split(',').Select(int.Parse).ToArray()).ToArray();
        Assert.Equal(expected, SumCoordinates(input, x));
    }

    // Дан массив массивов чисел.
    // Каждый вложенный массив отсортирован и содержит уникальные значения.
    // Все вложенные массивы одинаковой длины.
    // Первое число каждого массива — больше последнего числа предыдущего массива.
    // Дано число, надо найти сумму индексов местоположения этого числа.
    private int SumCoordinates(int[][] input, int x) {
        int result = -1;

        for (int i = 0; i < input.Length; i++) {
            for (int j = 0; j < input[i].Length; j++) {
                if (input[i][j] == x) {
                    result = i + j;
                    break;
                }
            }
        }

        return result;
    }
}