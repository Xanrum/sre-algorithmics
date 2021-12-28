using System;
using Xunit;

public class Lesson3Task4
{
    [Theory]
    [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 4 })]
    private void CheckInc(int[] input, int[] expected) =>
        Assert.Equal(expected, Inc(input));

    // входной массив состоит из чисел 0-9
    // Массив представляет число в десятичной системе счисления
    // Функция производит инкремент +1
    // Длина массива до 1000
    private int[] Inc(int[] input)
    {
        var all9 = true;
        foreach (var i in input)
            if (i != 9)
                all9 = false;

        if (all9)
        {
            var result = new int[input.Length + 1];
            result[0] = 1;
            return result;
        }
        else
        {
            var result = new int[input.Length];
            var inced = false;
            for (var i = input.Length - 1; i >= 0; i--)
            {
                var v = input[i];
                if (!inced && v == 9) v = 0;
                else if (!inced)
                {
                    v++;
                    inced = true;
                }

                result[i] = v;
            }

            return result;
        }
    }
}