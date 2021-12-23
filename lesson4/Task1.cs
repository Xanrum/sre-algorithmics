using System;
using Xunit;

public class Lesson4Task1
{
    [Theory]
    [InlineData(new [] {1, 2, 3, 4}, new[] {4, 3, 2, 1})]
    private void CheckEvaluator(int[] input, int[] expected)
    {
        ReverseArray(input);
        Assert.Equal(expected, input);
    }

    // требуется сделать реверс входного массива
    private void ReverseArray(int[] input) => throw new NotImplementedException();
}