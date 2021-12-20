using System;
using Xunit;

public class Lesson2Task1
{
    // O(n)
    [Theory]
    [InlineData("(", false)]
    [InlineData("((", false)]
    [InlineData("))", false)]
    [InlineData("()", true)]
    [InlineData(")(", false)]
    [InlineData("())(", false)]
    [InlineData("())", false)]
    [InlineData(")())", false)]
    [InlineData("())(", false)]
    [InlineData("(())))", false)]
    [InlineData("(())()", true)]
    [InlineData("()))((()", false)]
    private void CheckSearchMostFValue(string input, bool expected) =>
        Assert.Equal(expected, CheckBracers(input));

    // Дана строка со скобочным выражением состоящая из круглых скобок
    // требуется определить корректность этой строки
    private bool CheckBracers(string input)
    {
        if (input.Length % 2 == 1) return false;
        var countOpen = 0;
        foreach (var t in input)
        {
            if (t == '(')
                countOpen++;
            else
            {
                if (countOpen > 0)
                    countOpen--;
                else
                    return false;
            }
        }

        return countOpen == 0;
    }
}