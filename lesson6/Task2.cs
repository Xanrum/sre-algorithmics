using System;
using Xunit;

public class Lesson6Task2
{
    [Theory]
    [InlineData(5, 8, new []{0, 0, 0, 0, 0, 1, 1, 0})]
    
    private void CheckDecoder(int input, int dbase , int[] expected) =>
        Assert.Equal(expected, Decoder(input, dbase));

    // дано число и основание декодера
    // требуется преобразочать число в массив состоящий из 0 и 1 представляющее число в двоичной системе
    private int[] Decoder(int input, int dbase) => throw new NotImplementedException();
}