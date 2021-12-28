using System;
using Xunit;

public class Lesson4Task4
{
    [Theory]
    [InlineData("2+2*2", 6)]
    private void CheckEvaluator(string input, int expected) =>
        Assert.Equal(expected, Evaluator(input));

    // Дана строка состоящая из
    // * знаков умножения
    // + знаков плюс
    // цифр 0..9
    // строка представляет арифметическое выражение
    // требуется вычислить его значение, с учетом приоритета операций
    private int Evaluator(string input)
    {
        var result = 0;
        var prevValue = 1;
        var currentValue = 0;
        foreach (var ch in input)
        {
            if (ch == '+')
            {
                result += currentValue * prevValue;
                prevValue = 1;
                currentValue = 0;
                continue;
            }

            if (ch == '*')
            {
                prevValue *= currentValue;
                currentValue = 0;
                continue;
            }

            currentValue = currentValue * 10 + ch - '0';
        }

        return result + currentValue * prevValue;
    }
}