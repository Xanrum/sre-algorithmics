using System;
using Xunit;

public class Lesson1Task1
{
    // O(1) - по вермени, доп. память не требуется? Это значит, что асимптотика лиенйная - с ростом длины входного массива память не увеличивается. Это значит O(1)?
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(1, -2, -1)]
    private void CheckSum(int a, int b, int expected) => Assert.Equal(expected, Sum(a, b));

    //функция складывает два целых числа
    private int Sum(int a, int b) => a + b;
}