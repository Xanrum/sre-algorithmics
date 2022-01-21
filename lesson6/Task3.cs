using System;
using Xunit;

public class Lesson6Task3
{
    [Theory]
    [InlineData(5, 8, new []{0, 0, 0, 0, 0, 1, 0, 0})]
    [InlineData(2, 8, new []{0, 0, 1, 0, 0, 0, 0, 0})]
    
    private void CheckBinaryDecoder(int input, int dbase , int[] expected) =>
        Assert.Equal(expected, BinaryDecoder(input, dbase));

    // дано число и основание бинарного декодера https://en.wikipedia.org/wiki/Binary_decoder
    // требуется преобразочать число в массив состоящий из 0 и 1 после бинарного декодирования
    private int[] BinaryDecoder(int input, int dbase) => throw new NotImplementedException();
}