using System;
using System.Collections.Generic;
using Xunit;

public class Lesson4Task3
{
    // Чуть меньше говнокода. Но не придумала, как сделать без кортежа. В смысле без возврата указателя 
    // По времени - O(n)? вроде по каждому элементу один раз проходим, несмотря на рекурсию
    // по памяти - тоже теряюсь. 
    [Theory]
    [InlineData("A4B3C", "AAAABBBC")]
    [InlineData("A4BC2", "AAAABCC")]
    [InlineData("A4B3CA3", "AAAABBBCAAA")]
    [InlineData("A4B10CA3", "AAAABBBBBBBBBBCAAA")]
    [InlineData("(A2B)3Z", "AABAABAABZ")]
    [InlineData("((A2)2)2", "AAAAAAAA")]
    [InlineData("((A2B)2)2", "AABAABAABAAB")]
    [InlineData("(A2B)10Z", "AABAABAABAABAABAABAABAABAABAABZ")]
    [InlineData("((A2B)10Z)2", "AABAABAABAABAABAABAABAABAABAABZAABAABAABAABAABAABAABAABAABAABZ")]
    private void CheckEvaluator(string input, string expected) =>
        Assert.Equal(expected, ReversRLE(input));

    // распаковка RLE со скобками
    // поdторяющиеся блоки могут быть объеденены в скобки
    
    private string ReversRLE(string input)
    {
        return string.Join("", Work(input).Item2);
    }

    private (int, List<char>) Work(string input)
    {
        List<char> letters = new();
        List<char> result = new();
        var i = 0;
        while (i < input.Length)
        {
            if (char.IsLetter(input[i]))
            {
                if (letters.Count != 0)
                {
                    result.AddRange(letters);
                    letters.Clear();
                }

                letters.Add(input[i]);
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
                AddLetters(result, letters, number);
                letters.Clear();
            }
            else if (input[i] == '(')
            {
                i++;
                var (position, res) = Work(input.AsSpan(i, input.Length - i).ToString());
                i += position;
                i++;
                Console.WriteLine(res);
                letters = res;
            }
            else if (input[i] == ')')
            {
                if (letters.Count != 0)
                    result.AddRange(letters);
                return (i, result);
            }
        }

        if (char.IsLetter(input[^1]))
            result.Add(input[^1]);

        return (i, result);
    }


    private void AddLetters(List<char> result, List<char> letters, int number)
    {
        for (int i = 0; i < number; i++)
        {
            result.AddRange(letters);
        }
    }
}