using System;
using Xunit;

public class Lesson2Task1
{
    [Theory]
    [InlineData("(", false)]
    [InlineData("()", true)]
    [InlineData("())", false)]
    private void CheckSearchMostFValue(string input, bool expected) =>
        Assert.Equal(expected, CheckBracers(input));

    //Асимптотика
    //Вычислительная О(N)
    //Память О(1)
    // Дана строка со скобочным выражением состоящая из круглых скобок
    // требуется определить корректность этой строки
    private bool CheckBracers(string input)
    {
        var counter = 0;
        foreach (var item in input)
        {
            if (item == '(') counter++;
            if (item == ')') counter--;
            if (counter < 0) return false;
        }

        return counter == 0;
    }
}