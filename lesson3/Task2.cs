using System;
using Xunit;

public class Lesson3Task2
{
    [Theory]
    [InlineData("1+2", 3)]
    private void CheckSumator(string input, int expected) =>
        Assert.Equal(expected, Sumator(input));

    // Дано корректное арифметическое выражение состоящее только из цифр и знаков плюс +
    // Требуется произвести вычисление значения выражения
    private int Sumator(string input)
    {
        var result = 0;
        var current = 0;
        foreach (var ch in input)
        {
            if (char.IsDigit(ch)) current = current * 10 + ch - '0';
            else
            {
                result += current;
                current = 0;
            }
        }
        return result + current;
    }
}