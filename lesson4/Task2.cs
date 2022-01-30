using System;
using System.Linq;
using System.Collections.Generic;
using Xunit;

public class Lesson4Task2
{
    [Theory]
    [InlineData(4, new[] {"(())", "()()"})]
    [InlineData(2, new[] {"()"})]
    [InlineData(6, new[] {"((()))", "()()()", "(()())", "(())()", "()(())"})]
    private void CheckBracesGenerator(int input, string[] expected) =>
        Assert.Equal(expected.OrderBy(p => p), BracesGenerator(input).OrderBy(p => p));

    // Дано число N.
    // Надо сгенерировать все возможные правильные скобочные выражения длиной N символов.
    // Скобочные выражения состоят только из круглых скобок.
    private string[] BracesGenerator(int input) {
        List<string> result = new List<string>();

        if (input % 2 == 0) {
            Generator(new(), input, 0, result);
        }

        return result.ToArray();
    }

    private void Generator(List<char> braces, int limit, int balance, List<string> result) {
        if (braces.Count == limit) {
            result.Add(new (braces.ToArray()));
            return;
        }

        if (balance > 0) {
            braces.Add(')');
            Generator(braces, limit, balance - 1, result);
            braces.RemoveAt(braces.Count - 1);
        }

        if (limit - braces.Count > balance) {
            braces.Add('(');
            Generator(braces, limit, balance + 1, result);
            braces.RemoveAt(braces.Count - 1);
        }
    }
}