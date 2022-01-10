using System;
using System.Collections.Generic;
using Xunit;

public class Lesson4Task4
{
    [Theory]
    [InlineData("2+2*2", 6)]
    [InlineData("2+2*2*2", 10)]
    [InlineData("2+2*2+2", 8)]
    [InlineData("2+20*2+2", 44)]
    [InlineData("2*20*2+200", 280)]
    private void CheckEvaluator(string input, int expected) =>
        Assert.Equal(expected, Evaluator(input));

    // Дана строка состоящая из
    // * знаков умножения
    // + знаков плюс
    // цифр 0..9
    // строка представляет арифметическое выражение
    // требуется вычислить его значение, с учетом приоритета операций
    private int Evaluator(string input)
    {
        var stack = new Stack<int>();
        var start = 0;
        var count = 0;
        var sign = '-';
        for (var i = 0; i < input.Length; i++)
        {
            if (input[i] == '+')
            {
                stack.Push(int.Parse(input.AsSpan(start, count)));
                count = 0;
                start = i + 1;
                
                if (sign == '*')
                {
                    var last = stack.Pop();
                    var previous = stack.Pop();
                    stack.Push(last * previous);
                }
                sign = '+';
            }
            else if (input[i] == '*')
            {
                stack.Push(int.Parse(input.AsSpan(start, count)));
                count = 0;
                start = i + 1;
                
                if (sign == '*')
                {
                    var last = stack.Pop();
                    var previous = stack.Pop();
                    stack.Push(last * previous);
                }
                sign = '*';
            }
            else
                count++;
        }
        
        stack.Push(int.Parse(input.AsSpan(start, count)));
        if (sign == '*')
        {
            var last = stack.Pop();
            var previous = stack.Pop();
            stack.Push(last * previous);
        }

        var result = 0;
        while (stack.Count > 0)
        {
            result += stack.Pop();
        }

        return result;
    }
}