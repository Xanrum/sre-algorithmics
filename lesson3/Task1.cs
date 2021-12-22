using System;
using Xunit;

public class Lesson3Task1
{
    [Theory]
    [InlineData("(", false)]
    [InlineData("()", true)]
    [InlineData("()))", false)]
    [InlineData("(]", false)]
    [InlineData("({)", false)]
    private void CheckSearchMostFValue(string input, bool expected) =>
        Assert.Equal(expected, CheckBracers(input));

    // Дана строка со скобочным выражением состоящая из круглых () квадратных [] и фигурных {} скобок
    // требуется определить корректность этой строки
    private bool CheckBracers(string input) => throw new NotImplementedException();
}