using System;
using Xunit;

public class Lesson1Task1
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(1, -2, -1)]
    private void CheckSum(int a, int b, int expected) => Assert.Equal(expected, Sum(a, b));

    // Функция складывает два целых числа.
    // O(1)
    private int Sum(int a, int b) {
        return a + b;
    }
}