using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using Xunit;

public class Lesson4Task3
{
    // Ну, это говнокод.
    [Theory]
    [InlineData("A4B3C", "AAAABBBC")]
    [InlineData("A4BC2", "AAAABCC")]
    [InlineData("A4B3CA3", "AAAABBBCAAA")]
    [InlineData("A4B10CA3", "AAAABBBBBBBBBBCAAA")]
    [InlineData("(A2B)3Z", "AABAABAABZ")]
    [InlineData("(A2B)10Z", "AABAABAABAABAABAABAABAABAABAABZ")]
    private void CheckEvaluator(string input, string expected) =>
        Assert.Equal(expected, ReversRLE(input));

    // распаковка RLE со скобками
    // поdторяющиеся блоки могут быть объеденены в скобки
    private string ReversRLE(string input)
    {
        char letter = default;
        List<char> result = new List<char>();
        int i = 0;
        while (i < input.Length)
        {
            if (char.IsLetter(input[i]))
            {
                if (letter != default)
                {
                    result.Add(letter);
                }

                letter = input[i];
                i++;
            }
            else if (char.IsDigit(input[i]))
            {
                var start = i;
                var count = 0;
                while (i < input.Length && char.IsDigit(input[i]))
                {
                    count++;
                    i++;
                }
                var number = int.Parse(input.AsSpan(start, count));
                AddLetters(result, letter, number);
                letter = default;
            }
            else if (input[i] == '(')
            {
                var count = 0;
                i++;
                var start = i;
                while (input[i] != ')')
                {
                    count++;
                    i++;
                }

                var res = ReversRLE(input.AsSpan(start, count).ToString());
                var iterations = 1;
                i++;
                if (char.IsDigit(input[i]))
                {
                    start = i;
                    count = 0;
                    while (i < input.Length && char.IsDigit(input[i]))
                    {
                        count++;
                        i++;
                    }
                }
                iterations = int.Parse(input.AsSpan(start, count));
                for (int j = 0; j < iterations; j++)
                {
                    foreach (var letterOfRes in res)
                    {
                        AddLetters(result, letterOfRes, 1);
                    }
                }

                i++;
            }
        }

        if (char.IsLetter(input[^1]))
            result.Add(input[^1]);

        return string.Join("", result);
    }

    private void AddLetters(List<char> result, char letter, int number)
    {
        for (int i = 0; i < number; i++)
        {
            result.Add(letter);
        }
    }
}