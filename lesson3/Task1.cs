using System;
using System.Collections.Generic;
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

        List<char> braces = new();

        foreach (var brace in input)
        {
            if (brace == '(' || brace == '[' || brace == '{') {
                braces.Add(brace);
                continue;
            }

            if (braces.Count > 0) {
                if (brace == ')' && braces[^1] == '(' ||
                    brace == ']' && braces[^1] == '[' ||
                    brace == '}' && braces[^1] == '{') {
                        braces.RemoveAt(braces.Count - 1);
                        continue;
                    }
            }

            return false;
        }

        return true;
    }
}