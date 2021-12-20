using System;
using System.Collections.Generic;
using Xunit;

public class Lesson3Task1
{
    // O(n) - по времени, O(n) - по памяти
    [Theory]
    [InlineData("(", false)]
    [InlineData("()", true)]
    [InlineData("(]", false)]
    [InlineData("({)", false)]
    [InlineData("({)}", false)]
    [InlineData("({}){}", true)]
    [InlineData("(", false)]
    [InlineData("({]", false)]
    [InlineData("))", false)]
    [InlineData("([]{})", true)]
    [InlineData(")(", false)]
    [InlineData("{]", false)]
    [InlineData("{]]]", false)]
    private void CheckSearchMostFValue(string input, bool expected) =>
        Assert.Equal(expected, CheckBracers(input));

    // Дана строка со скобочным выражением состоящая из круглых () квадратных [] и фигурных {} скобок
    // требуется определить корректность этой строки

    private bool CheckBracers(string input)
    {
        var open = new List<char> {'(', '[', '{'};
        var found = new Stack<char>();

        foreach (var symbol in input)
        {
            if (open.Contains(symbol))
                found.Push(symbol);
            else
            {
                if (!found.TryPop(out var previous) || GetOpposite(previous) != symbol)
                    return false;
            }
        }

        return found.Count == 0;
    }

    private char GetOpposite(char brace) =>
        brace switch
        {
            '(' => ')',
            '[' => ']',
            '{' => '}',
            _ => throw new ArgumentOutOfRangeException(nameof(brace), brace, null)
        };
}