using System;
using Xunit;

public class Lesson2Task3
{
    [Theory]
    [InlineData(new[] { -1, 1, 1, 3, 5 }, new[] { 0, 1, 5, 6, 6, 6, 7 }, new[] { 1, 6 })]
    [InlineData(new[] { 0 }, new[] { 0 }, new[] { 0 })]
    [InlineData(new[] { 0 }, new[] { 1 }, new[] { 0, 1 })]
    private void CheckSearchMostFValue2(int[] listA, int[] listB, int[] expected) =>
        Assert.Equal(expected, SearchMostFValue2(listA, listB));

    // Даны два отсортириованный массива. Найти наиболее встречающееся значения в объединении двух массивов
    // Результат - отсортированный массив значений
    //o(N)
    private int[] SearchMostFValue2(int[] listA, int[] listB) => throw new NotImplementedException();
    // Мучаюсь над однопроходнм решением
}