using System;
using Xunit;

public class Lesson3Task2
{
    // только из цифр? Не из чисел?
    // O(n) - по времени, O(1) - по памяти
    [Theory]
    [InlineData("1+2", 3)]
    [InlineData("1+2+1+3+9+5+4", 25)]
    private void CheckSumator(string input, int expected) =>
        Assert.Equal(expected, Sumator(input));

    // Дано корректное арифметическое выражение состоящее только из цифр и знаков плюс +
    // Требуется произвести вычисление значения выражения
    private int Sumator(string input)
    {
        var result = 0;
        foreach (var symbol in input)
        {
            if (symbol != '+')
                result += Convert.ToInt32(char.GetNumericValue(symbol));
        }

        return result;
    }
}