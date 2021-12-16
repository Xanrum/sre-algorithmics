using System;
using Xunit;

public class Lesson1Task5
{
    [Theory]
    [InlineData(new[] { -1, 0, 1, 1, 1, 3, 5, 5, 6, 7 }, 1)]
    [InlineData(new[] { 0, 1, 1 }, 1)]
    [InlineData(new[] { 1 }, 1)]
    private void CheckSearchMostFValue(int[] list, int expected) => Assert.Equal(expected, SearchMostFValue(list));

    // Дан отсортириованный массив. Найти наиболее встречающееся значение
    // Если таких значений несколько - найти первое такое значение
    private int SearchMostFValue(int[] list) => throw new NotImplementedException();
}