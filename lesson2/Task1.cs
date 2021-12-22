using System;
using Xunit;

public class Lesson2Task1
{
    [Theory]
    [InlineData("(", false)]
    [InlineData("((", false)]
    [InlineData("()", true)]
    [InlineData(")(", false)]
    [InlineData("())(", false)]
    [InlineData("())", false)]
    
    private void CheckSearchMostFValue(string input, bool expected) =>
        Assert.Equal(expected, CheckBracers(input));

    // Дана строка со скобочным выражением состоящая из круглых скобок
    // требуется определить корректность этой строки
    //O(N)
    private bool CheckBracers(string input)
    {
        var c = 0;
        foreach (var item in input)
        {
            if (item == '(') c++;
            else c--;
            if (c < 0) return false;
        }
        return c == 0;
    }
}