using System;
using Xunit;

public class Lesson1Task1
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(1, -2, -1)]
    private void CheckSum(int a, int b, int expected) => Assert.Equal(expected, Sum(a, b));

    
    //Асимптотика
    //Вычислительная О(1)
    //Память О(1)
    //функция складывает два целых числа
    private int Sum(int a, int b) => a + b;
}