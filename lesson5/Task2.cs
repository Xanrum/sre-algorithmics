using System;
using Xunit;

public class Lesson5Task2
{
    [Theory]
    [InlineData(new []{1, 2, 4}, 3)]
    
    private void CheckFindSkip(int[] input, int expected) =>
        Assert.Equal(expected, FindSkip(input));

    // Дан массив чисел длины N-1
    // в массиве находятся числа от 1 до N, но одно число исключили
    // надо найти исключенное число
    // на всякий случай - еще раз, массив НЕ отсортирован
    private int FindSkip(int[] input) => throw new NotImplementedException();
}