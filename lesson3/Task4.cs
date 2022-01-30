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
        int[] output = new int[input.Length];
        input.CopyTo(output, 0);

        for (int i = output.Length-1; i >=0; i--) {
            if (output[i] < 9) {
                output[i]++;
                break;
            }
            else {
                output[i] = 0;
                shift = true;
            }

            if (i == 0 && shift) {
                int[] extendedOutput = new int[output.Length + 1];
                extendedOutput[0] = 1;
                return extendedOutput;
            }
        }

        return output;
    }
}