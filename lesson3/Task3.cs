using System;
using Xunit;

public class Lesson3Task3
{
    [Theory]
    [InlineData("AAAABBBC", "A4B3C")]
    [InlineData("AAAABBBCAAA", "A4B3CA3")]
    private void CheckRLE(string input, string expected) =>
        Assert.Equal(expected, RLE(input));

    // Дана строка из латинских заглавных букв.
    // Необходимо заменить все повторы одинаковых подряд идущих букв на букву + цифру 
    private string RLE(string input) => throw new NotImplementedException();
}