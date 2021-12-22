using System;
using Xunit;

public class Lesson3Task2
{
    [Theory]
    [InlineData("1+2", 3)]
    [InlineData("1+20", 21)]
    private void CheckSumator(string input, int expected) =>
        Assert.Equal(expected, Sumator(input));

    // Дано корректное арифметическое выражение состоящее только из цифр и знаков плюс +
    // Требуется произвести вычисление значения выражения
    private int Sumator(string input) => throw new NotImplementedException();
}