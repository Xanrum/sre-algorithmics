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
    private string RLE(string input)
    {
        var result = "";

        void addToRes(char c, int count)
            => result += c + (count == 1 ? "" : count.ToString());

        var count = 1;
        var prev = input[0];
        for (var i = 1; i < input.Length; i++)
        {
            if (prev != input[i])
            {
                addToRes(prev, count);
                count = 0;
                prev = input[i];
            }
            count++;
        }
        addToRes(prev, count);
        return result;
    }
}