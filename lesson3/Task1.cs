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
    [InlineData("({)}", false)]
    [InlineData("[{]}", false)]
    [InlineData("[(])", false)]
    [InlineData("{(})", false)]
    [InlineData("{[}]", false)]
    [InlineData("([]){", false)]
    [InlineData("([])}{", false)]
    [InlineData("([{}]())", true)]
    [InlineData("([{()}](){[()]})", true)]
    private void CheckSearchMostFValue(string input, bool expected) =>
        Assert.Equal(expected, CheckBraces(input));

    // Дана строка со скобочным выражением, состоящая из круглых () квадратных [] и фигурных {} скобок.
    // Требуется определить корректность этой строки.
    private bool CheckBraces(string input) {

        // слишком короткое выражение, либо нечетное кол-во символов в выражении
        if (input.Length < 2 || input.Length%2 != 0) {
            return false;
        }

        do {
            int length = input.Length;

            input = input.Replace("()", "");
            input = input.Replace("[]", "");
            input = input.Replace("{}", "");

            if (length == input.Length) {
                break;
            }
        } while (true);

        return (input.Length == 0) ? true : false;
    }
}