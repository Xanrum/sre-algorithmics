using System;
using Xunit;

public class Lesson3Task2
{
    [Theory]
    [InlineData("1+2", 3)]
    [InlineData("0+0", 0)]
    [InlineData("1+2+3", 6)]
    private void CheckSumator(string input, int expected) =>
        Assert.Equal(expected, Sumator(input));

    // Дано корректное арифметическое выражение, состоящее только из цифр и знаков плюс +.
    // Требуется произвести вычисление значения выражения.
    private int Sumator(string input) {
        int sum = 0;

        foreach (char item in input) {
            if (item != '+') {
                int number = (int)Char.GetNumericValue(item);
                sum = sum + number;
            }
        }

        return sum;
    }
}