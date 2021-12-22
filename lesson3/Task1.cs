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
    private bool CheckBracers(string input)
    {
        var (cR, cF, cP) = (0, 0, 0);
        foreach (var item in input)
        {
            if (item == '(') cR++;
            if (item == ')') cR--;
            if (item == '{') cF++;
            if (item == '}') cF--;
            if (item == '[') cP++;
            if (item == ']') cP--;
            if (cR < 0 || cF < 0 || cP < 0) return false;
        }

        return cR == 0 && cF == 0 && cP == 0;
    }
}