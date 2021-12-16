using System;
using Xunit;

public class Lesson2Task1
{
    [Theory]
    [InlineData("(", false)]
    [InlineData("()", true)]
    [InlineData("())", false)]
    [InlineData("((", false)]
    [InlineData("()()", true)]
    [InlineData("((()))", true)]
    [InlineData(")(", false)]
    [InlineData("(()((())))", true)]
    private void CheckCheckBraces(string input, bool expected) =>
        Assert.Equal(expected, CheckBraces(input));

    // Дана строка со скобочным выражением состоящая из круглых скобок.
    // Требуется определить корректность этой строки.
    // O(n)
    private bool CheckBraces(string input) {
        int count = 0;
        int countBraceLeft = 0;
        int countBraceRight = 0;

        foreach(char brace in input) {
            if (count == 0 && brace == ')') {
                return false;
            }

            if (brace == '(') {
                countBraceLeft++;
            }
            else {
                countBraceRight++;
            }

            count++;
        }

        return (countBraceLeft == countBraceRight) ? true : false;
    }
}