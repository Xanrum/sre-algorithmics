using System;
using System.Collections.Generic;
using Xunit;

public class Lesson3Task3
{
    // O(n) - по времени, O(n) - по памяти
    [Theory]
    [InlineData("AAAABBBC", "A4B3C")]
    [InlineData("AAAABBBCAAA", "A4B3CA3")]
    [InlineData("ABBBCAAA", "AB3CA3")]
    private void CheckRLE(string input, string expected) =>
        Assert.Equal(expected, RLE(input));

    // Дана строка из латинских заглавных букв.
    // Необходимо заменить все повторы одинаковых подряд идущих букв на букву + цифру 
    private string RLE(string input)
    {
        var result = new List<string>();
        var count = 1;
        var i = 1;
        while (i < input.Length)
        {
            if (input[i] == input[i - 1])
                count++;
            else
            {
                result.Add($"{input[i - 1]}{(count > 1 ? count : "")}");
                count = 1;
            }

            i++;
        }

        result.Add($"{input[i - 1]}{(count > 1 ? count : "")}");
        return string.Join("",result);
    }
}