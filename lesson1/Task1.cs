using System;
using Xunit;

public class Lesson1Task1
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(1, -2, -1)]
    private void CheckSum(int a, int b, int expected) => Assert.Equal(expected, Sum(a, b));

    //функция складывает два целых числа
    private int Sum(int a, int b) => throw new NotImplementedException();
}