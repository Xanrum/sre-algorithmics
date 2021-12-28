using System;
using Xunit;

public class Lesson1Task5
{
    [Theory]
    [InlineData(new[] { -1, 0, 1, 1, 1, 3, 5, 5, 6, 7 }, 1)]
    [InlineData(new[] { 0, 1, 1 }, 1)]
    [InlineData(new[] { 1 }, 1)]
    private void CheckSearchMostFValue(int[] list, int expected) => Assert.Equal(expected, SearchMostFValue(list));

    //Асимптотика
    //Вычислительная О(N)
    //Память О(1)
    // Дан отсортириованный массив. Найти наиболее встречающееся значение
    // Если таких значений несколько - найти первое такое значение
    private int SearchMostFValue(int[] list)
    {
        var recordCount = 0;
        var recordValue = 0;
        var currentCount = 1;
        var currentValue = list[0];
        for (var i = 1; i < list.Length; i++)
        {
            var value = list[i];
            if (value != currentValue)
            {
                if (currentCount > recordCount) {
                    recordCount = currentCount;
                    recordValue = currentValue;
                }
                currentValue = value;
                currentCount = 0;
            }
            currentCount++;
        }
        if (currentCount > recordValue) recordValue = currentValue;
        return recordValue;
    }
}