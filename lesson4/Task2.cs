using System;
using System.Linq;
using Xunit;

public class Lesson4Task2
{
    [Theory]
    [InlineData(4, new[] {"(())", "()()"})]
    private void CheckBracesGenerator(int input, string[] expected) =>
        Assert.Equal(expected, BracesGenerator(input).OrderBy(p => p));

    // Дано число N
    // надо сгенериировать все возможные правильные скобочные выражения длиной N символов
    // скобочные выражения состоят только из круглых скобок
    private string[] BracesGenerator(int input) => throw new NotImplementedException();
}