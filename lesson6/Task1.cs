using System;
using Xunit;

public class Lesson6Task1
{
    [Theory]
    [InlineData(new []{0, 0, 0, 0, 0, 1, 1, 0}, 5)]
    
    private void CheckCoder(int[] input, int expected) =>
        Assert.Equal(expected, Coder(input));

    // Дан массив чисел 0, 1 представляющее число в двоичной ситеме счисления
    // требуется массив преобразовать в число
    private int Coder(int[] input) => throw new NotImplementedException();
}