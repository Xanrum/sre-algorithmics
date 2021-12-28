using System;
using Xunit;

public class Lesson3Task3
{
    [Theory]
    [InlineData("ABBC", "AB2C")]
    [InlineData("AAAABBBC", "A4B3C")]
    [InlineData("AAAABBBCAAA", "A4B3CA3")]
    private void CheckRLE(string input, string expected) =>
        Assert.Equal(expected, RLE(input));

    // Дана строка из латинских заглавных букв.
    // Необходимо заменить все повторы одинаковых подряд идущих букв на букву + цифру 
    //O(N)
    private string RLE(string input)
    {
        var tempMaxV = 0;
        var tempMaxN = input[0];
        var res= "";
        for (var i = 0; i < input.Length; i++)
        {
            if (tempMaxN != input[i])
            {
                if (tempMaxV == 1)
                {
                    res += $"{input[i-1]}";
                    tempMaxV = 1;
                    tempMaxN = input[i];
                    continue;
                }
                res += $"{input[i-1]}{tempMaxV}";
                tempMaxV = 1;
                tempMaxN = input[i];
            }
            else
            {
                tempMaxV++;
            }
        }
        if (tempMaxV == 1) res += $"{input[^1]}";
        else res += $"{input[^1]}{tempMaxV}";
        return res;
    }
}