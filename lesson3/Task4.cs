using System;
using Xunit;

public class Lesson3Task4
{
    [Theory]
    [InlineData(new [] {1, 2, 3}, new [] {1, 2, 4})]
    private void CheckШтс(int[] input, int[] expected) =>
        Assert.Equal(expected, Inc(input));

    // входной массив состоит из ыисле 0-9
    // Массив представляет число в десятичной системе счисления
    // Функция производит инкремент +1
    private int[] Inc(int[] input) => throw new NotImplementedException();
}