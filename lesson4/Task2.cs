using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

public class Lesson4Task2
{
    [Theory]
    [InlineData(4, new[] {"(())", "()()"})]
    [InlineData(2, new[] {"()"})]
    [InlineData(6, new[] {"((()))", "(()())", "(())()", "()(())", "()()()"})]
    [InlineData(8, new[] {"(((())))", "((()()))", "((())())", "((()))()", "(()(()))", "(()()())", "(()())()", 
        "(())(())", "(())()()", "()((()))", "()(()())", "()(())()", "()()(())", "()()()()"})]
    
    
    private void CheckBracersGenerator(int input, string[] expected) =>
        Assert.Equal(expected, BracersGenerator(input).OrderBy(p => p));
    
    // Дано число N
    // надо сгенериировать все возможные правильные скобочные выражения длиной N символов
    // скобочные выражения состоят только из круглых скобок
    private string[] BracersGenerator(int input)
    {
        if (input % 2 == 1) return Array.Empty<string>();
        var results = new List<string>();
        var queue = new Queue<Element>();
        queue.Enqueue( new Element
        {
            Str = "(",
            openCount = 1,
            closeCount = 0
        });
        queue.Enqueue(new Element
        {
            Str = ")",
            openCount = 0,
            closeCount = 1
        });
        while (queue.Count > 0)
        {
            var result = queue.Dequeue();
            if (!IsValid(result, input))
                continue;
            
            if (result.Str.Length == input)
            {
                results.Add(string.Join("", result.Str));
                continue;
            }
            queue.Enqueue(new Element
            {
                Str = result.Str + '(',
                openCount = result.openCount + 1,
                closeCount = result.closeCount
            });
            queue.Enqueue(new Element
            {
                Str = result.Str + ')',
                openCount = result.openCount,
                closeCount = result.closeCount + 1
            });
        }

        Console.WriteLine(string.Join(" ", results));
        return results.ToArray();
    }

    class Element
    {
        public string Str { get; set; }
        public int openCount { get; set; } = 0;
        public int closeCount { get; set; } = 0;
    }

    private bool IsValid(Element toCheck, int input)
    {
        if (toCheck.closeCount > toCheck.openCount)
            return false;
        if (toCheck.closeCount > input / 2 || toCheck.openCount > input / 2)
            return false;
        return true;
    }
    
    
}