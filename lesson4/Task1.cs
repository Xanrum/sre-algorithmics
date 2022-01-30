using System;
using Xunit;

public class Lesson4Task1
{
    [Theory]
    [InlineData(new [] {1, 2, 3, 4}, new[] {4, 3, 2, 1})]
    [InlineData(new [] {0}, new[] {0})]  // массив из одного элемента
    private void CheckEvaluator(int[] input, int[] expected)
    {
        ReverseArray(input);
        Assert.Equal(expected, input);
    }

    // Требуется сделать реверс входного массива.
    private void ReverseArray(int[] input) {
        for (int i = 0; i < input.Length/2; i++) {
            (input[input.Length - 1 - i], input[i]) = (input[i], input[input.Length - 1 - i]);
        }
    }
}