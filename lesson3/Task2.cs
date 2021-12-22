using System;
using System.Collections.Generic;
using Xunit;

public class Lesson3Task2
{
    [Theory]
    [InlineData("1+2", 3)]
    [InlineData("123+257", 380)]
    [InlineData("123+257+23", 403)]
    [InlineData("+123+257+23", 403)]
    [InlineData("257", 257)]
    [InlineData("+257", 257)]
    [InlineData("1+20", 21)]
    private void CheckSumator(string input, int expected) =>
        Assert.Equal(expected, Sumator(input));

    // Дано корректное арифметическое выражение состоящее только из цифр и знаков плюс +
    // Требуется произвести вычисление значения выражения
    // O(N)
    private int Sumator(string input)
    {
        var plusIndexes = new List<int> {0};
        var sum = 0;
        for (var i = 0; i < input.Length; i++)
        {
            if (i == 0 && input[i] == '+')
            {
                plusIndexes.Add(1);
                continue;
            }

            if (input[i] != '+') continue;
            plusIndexes.Add(i);
            sum+=int.Parse(input[plusIndexes[^2]..i]);
        }
        sum+=int.Parse(input[plusIndexes[^1]..]);
        return sum;
    }
}