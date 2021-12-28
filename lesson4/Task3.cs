using System;
using Xunit;

public class Lesson4Task3
{
    [Theory]
    [InlineData("A4B3C", "AAAABBBC")]
    [InlineData("A4B3CA3", "AAAABBBCAAA")]
    [InlineData("(A2B)3Z", "AABAABAABZ")]
    [InlineData("((A2)2)2", "AAAAAAAA")]
    private void CheckEvaluator(string input, string expected) =>
        Assert.Equal(expected, ReversRLE(input));

    // распаковка RLE со скобками
    // поdторяющиеся блоки могут быть объеденены в скобки
    private string ReversRLE(string input) => throw new NotImplementedException();
}