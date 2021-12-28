using System;
using Xunit;

public class Lesson4Task1
{
    // O(n) - по времени, O(1) - по памяти
    [Theory]
    [InlineData(new [] {1, 2, 3, 4}, new[] {4, 3, 2, 1})]
    [InlineData(new [] {1, 2, 3, 4, 5}, new[] {5, 4, 3, 2, 1})]
    private void CheckEvaluator(int[] input, int[] expected)
    {
        ReverseArray(input);
        Assert.Equal(expected, input);
    }

    // требуется сделать реверс входного массива
    private void ReverseArray(int[] input)
    {
        for (var i = 0; i < input.Length / 2; i++)
        {
            var tmp = input[input.Length - 1 - i];
            input[input.Length - 1 - i] = input[i];
            input[i] = tmp;
        }
    }
}