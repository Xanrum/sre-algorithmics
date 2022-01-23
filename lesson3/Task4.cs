using System;
using System.Collections.Generic;
using Xunit;

public class Lesson3Task4
{
    // O(n) - по времени, O(n) - по памяти (в хужшем случае?)
    [Theory]
    [InlineData(new[] {1, 2, 3}, new[] {1, 2, 4})]
    [InlineData(new[] {1, 2, 9}, new[] {1, 3, 0})]
    [InlineData(new[] {9, 9, 9}, new[] {1, 0, 0, 0})]
    [InlineData(new[] {9, 8, 9}, new[] {9, 9, 0})]
    private void CheckInc(int[] input, int[] expected) =>
        Assert.Equal(expected, Inc(input));

    // входной массив состоит из чисел 0-9
    // Массив представляет число в десятичной системе счисления
    // Функция производит инкремент +1
    // Длина массива до 1000
    private int[] Inc(int[] input)
    {
        var f = 1;
        var result = new int[input.Length];
        for (var i = input.Length - 1; i >= 0; i--)
        {
            if (input[i] == 9)
                result[i] = 0;

            else
            {
                result[i] = input[i] + 1;
                f = 0;
                for (var j = i - 1; j >= 0; j--)
                    result[j] = input[j];
                break;
            }
        }
        
        if (f == 1)
        {
            result = new int [input.Length + 1];
            result[0] = 1;
            return result;
        }
        return result;
    }
}