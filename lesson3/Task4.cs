using System;
using System.Collections.Generic;
using Xunit;

public class Lesson3Task4
{
    [Theory]
    [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 4 })]
    [InlineData(new[] { 1, 9, 9 }, new[] { 2, 0, 0 })]
    [InlineData(new[] { 1, 8, 9 }, new[] { 1, 9, 0 })]
    [InlineData(new[] { 9, 9, 9 }, new[] { 1, 0, 0, 0 })]
    private void CheckInc(int[] input, int[] expected) =>
        Assert.Equal(expected, Inc(input));

    // входной массив состоит из чисел 0-9
    // Массив представляет число в десятичной системе счисления
    // Функция производит инкремент +1
    // Длина массива до 1000
    //O(N)
    private int[] Inc(int[] input)
    {
        if (input[^1] != 9)
        {
            input[^1]++;
            return input;
        }

        var finish = true;
        foreach (var digit in input)
        {
            if (digit != 9)
            {
                finish = false;
                break;
            }
        }

        if (finish)
        {
            var r = new int[input.Length + 1];
            r[0] = 1;
            return r;
        }

        var result = new int[input.Length];
        var end = false;
        for (var i = input.Length - 2; i >= 0; i--)
        {
            if (input[i] != 9 && !end)
            {
                result[i] = input[i] + 1;
                end = true;
            }
            else
            {
                if (input[i] == 9) continue;
                result[i] = input[i];
            }
        }

        return result;
    }
}