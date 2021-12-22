using System;
using Xunit;

public class Lesson3Task4
{
    [Theory]
    [InlineData(new [] {1, 2, 3}, new [] {1, 2, 4})]
    [InlineData(new [] {1, 9, 9}, new [] {2, 0, 0})]
    [InlineData(new [] {9, 9, 9}, new [] {1, 0, 0, 0})] // увеличение на разряд
    private void CheckInc(int[] input, int[] expected) =>
        Assert.Equal(expected, Inc(input));

    // Входной массив состоит из чисел 0-9.
    // Массив представляет число в десятичной системе счисления.
    // Функция производит инкремент +1.
    // Длина массива до 1000.
    private int[] Inc(int[] input) {
        bool shift = false;

        for (int i = input.Length-1; i >=0; i--) {
            if (input[i] < 9) {
                input[i]++;
                break;
            }
            else {
                input[i] = 0;
                shift = true;
            }

            if (i == 0 && shift) {
                int[] extendedInput = new int[input.Length + 1];
                extendedInput[0] = 1;
                return extendedInput;
            }
        }

        return input;
    }
}