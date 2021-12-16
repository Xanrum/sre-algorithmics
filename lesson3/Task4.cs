using System;
using Xunit;

public class Lesson3Task4
{
    [Theory]
    [InlineData(new [] {1, 2, 3}, new [] {1, 2, 4})]
    private void CheckInc(int[] input, int[] expected) =>
        Assert.Equal(expected, Inc(input));

    // входной массив состоит из чисел 0-9
    // Массив представляет число в десятичной системе счисления
    // Функция производит инкремент +1
    // Длина массива до 1000
    private int[] Inc(int[] input) => throw new NotImplementedException();
}