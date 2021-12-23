using System;
using Xunit;

public class Lesson4Task1
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
    private int Evaluator(string input) => throw new NotImplementedException();
}