using System;
using Xunit;

public class Lesson5Task2
{
    [Theory]
    [InlineData(new []{1, 2, 4}, 3)]
    [InlineData(new []{5, 1, 3, 2}, 4)]

    private void CheckFindSkip(int[] input, int expected) =>
        Assert.Equal(expected, FindSkip(input));

    // Дан массив чисел длины N-1.
    // В массиве находятся числа от 1 до N, но одно число исключили.
    // Надо найти исключенное число
    // На всякий случай — еще раз, массив НЕ отсортирован!
    private int FindSkip(int[] input) {
        int sumInput = 0;
        foreach (int item in input) {
            sumInput = sumInput + item;
        }

        int sumExpected = 0;
        for (int i = 1; i <= input.Length + 1; i++) {
            sumExpected = sumExpected + i;
        }

        return sumExpected - sumInput;
    }
}