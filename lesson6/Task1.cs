using System;
using Xunit;

public class Lesson6Task1
{
    // тут есть опечатка? 110 в двоичной - это не 5, а 6
    //O(n) - по времени, O(1) - по памяти
    [Theory]
    [InlineData(new []{0, 0, 0, 0, 1, 0, 1, 0}, 10)]
    [InlineData(new []{0, 0, 0, 0, 0, 1, 1, 0}, 6)]
    
    private void CheckCoder(int[] input, int expected) =>
        Assert.Equal(expected, Coder(input));

    // Дан массив чисел 0, 1 представляющее число в двоичной ситеме счисления
    // требуется массив преобразовать в число
    private int Coder(int[] input)
    {
        double sum = 0;
        int pow = 0;
        for (int i = input.Length - 1 ; i >= 0; i--)
        {
            sum += input[i] * Math.Pow(2, pow);
            pow++;
        }

        return (int)sum;
    }
}