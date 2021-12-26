using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

public class Lesson4Task2
{
    [Theory]
    [InlineData(2, new [] {"()"})]
    [InlineData(3, new string[] {})]
    [InlineData(6, new[] {"((()))", "(()())", "(())()", "()(())", "()()()"})]
    [InlineData(4, new[] {"(())", "()()"})]
    private void CheckBracersGenerator(int input, string[] expected) =>
        Assert.Equal(expected, BracersGenerator(input).OrderBy(p => p));

    // Дано число N
    // надо сгенериировать все возможные правильные скобочные выражения длиной N символов
    // скобочные выражения состоят только из круглых скобок
    private string[] BracersGenerator(int input)
    {
        if (input % 2 == 1) return Array.Empty<string>();
        List<string> result = new List<string>();
        Gen(new(), input, 0, result);
        return result.ToArray();
    }

    private void Gen(List<char> prev, int max, int balance, List<string> toAdd)
    {
        if (prev.Count == max)
        {
            toAdd.Add(new (prev.ToArray()));
            return;
        }

        if (balance > 0)
        {
            prev.Add(')');
            Gen(prev, max, balance - 1, toAdd);
            prev.RemoveAt(prev.Count-1);
        }
        if (max - prev.Count > balance)
        {
            prev.Add('(');
            Gen(prev, max, balance + 1, toAdd);
            prev.RemoveAt(prev.Count-1);
        }
    }
}