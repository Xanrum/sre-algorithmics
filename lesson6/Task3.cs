using System;
using Xunit;

public class Lesson6Task3
{
    // O(1) - по времени, O(dbase) - по памяти
    [Theory]
    [InlineData(5, 8, new []{0, 0, 0, 0, 0, 1, 0, 0})]
    [InlineData(2, 8, new []{0, 0, 1, 0, 0, 0, 0, 0})]
    
    private void CheckBinaryDecoder(int input, int dbase , int[] expected) =>
        Assert.Equal(expected, BinaryDecoder(input, dbase));

    // дано число и основание бинарного декодера https://en.wikipedia.org/wiki/Binary_decoder
    // требуется преобразочать число в массив состоящий из 0 и 1 после бинарного декодирования
    private int[] BinaryDecoder(int input, int dbase)
    {
        var result = new int[dbase];
        result[input] = 1;
        return result;
    }
}