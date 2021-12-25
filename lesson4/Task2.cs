using System;
using System.Linq;
using Xunit;

public class Lesson4Task2
{
    [Theory]
    [InlineData(2, new[] {"(())", "()()"})]
    private void CheckBracersGenerator(int input, string[] expected) =>
        Assert.Equal(expected, BracersGenerator(input).OrderBy(p => p));

    // Дано число N
    // надо сгенериировать все возможные правильные скобочные выражения длиной N символов
    // скобочные выражения состоят только из круглых скобок
    private string[] BracersGenerator(int input) => throw new NotImplementedException();
}