using System;
using Xunit;

public class Lesson2Task1
{
    // O(n) - по времени, О(1) - по памяти
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
        var count = 0;
        foreach (var t in input)
        {
            if (t == '(')
                count++;
            else
            {
                if (count > 0)
                    count--;
                else
                    return false;
            }
        }
        return count == 0;
    }
}