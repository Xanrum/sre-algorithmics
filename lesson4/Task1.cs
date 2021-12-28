using System;
using System.Linq;
using Xunit;

public class Lesson4Task1
{
    [Theory]
    [InlineData(new[] { 0 }, new[] { 0 })]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, new[] { 5, 4, 3, 2, 1 })]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 4, 3, 2, 1 })]
    private void CheckEvaluator(int[] input, int[] expected)
    {
        ReverseArray(input);
        Assert.Equal(expected, input);
    }

    // требуется сделать реверс входного массива
    // O(N) память О(1)
    private void ReverseArray(int[] input)
    {
        var (begin, end) = (0, input.Length - 1);
        while (begin < end)
        {
            (input[begin], input[end]) = (input[end], input[begin]);
            begin++;
            end--;
        }
    }

    private void ReverseArrayExtended(int[] input) => Array.Reverse(input);
}