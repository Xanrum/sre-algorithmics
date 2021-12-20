using System;
using System.Collections.Generic;
using Xunit;

public class Lesson3Task1
{
    [Theory]
    [InlineData("(", false)]
    [InlineData("()", true)]
    [InlineData("(]", false)]
    [InlineData("({)", false)]
    private void CheckSearchMostFValue(string input, bool expected) =>
        Assert.Equal(expected, CheckBracers2(input));

    // Дана строка со скобочным выражением состоящая из круглых () квадратных [] и фигурных {} скобок
    // требуется определить корректность этой строки
    private bool CheckBracers(string input)
    {

        char GetOpenBracer(char bracer) => bracer switch
        {
            ')' => '(',
            ']' => '[',
            '}' => '{'
        };

        List<char> stack = new();
        foreach (var bracer in input)
        {
            if (bracer is '(' or '[' or '{') stack.Add(bracer);
            else if (stack.Count > 0 && stack[^1] == GetOpenBracer(bracer)) stack.RemoveAt(stack.Count - 1);
            else return false;
        }

        return stack.Count == 0;
    }
    
    private bool CheckBracers2(string input)
    {
        while (true)
        {
            var prevSize = input.Length;
            input = input.Replace("()", "").Replace("[]", "").Replace("{}", "");
            if (prevSize == input.Length) break;
        }

        return input.Length == 0;
    }
}