using System;
using Xunit;

public class Lesson1Task5
{
    // O(n)
    [Theory]
    [InlineData(new[] { -1, 0, 1, 1, 1, 3, 5, 5, 6, 7 }, 1)]
    [InlineData(new[] { 0, 1, 1 }, 1)]
    [InlineData(new[] { 1 }, 1)]
    [InlineData(new[] {1, 2, 2}, 2)]
    private void CheckSearchMostFValue(int[] list, int expected) => Assert.Equal(expected, SearchMostFValue(list));

    // Дан отсортириованный массив. Найти наиболее встречающееся значение
    // Если таких значений несколько - найти первое такое значение
    private int SearchMostFValue(int[] list)
    {
        var result = 0;
        var resultFrequency = 0;
        var counter = 0;
        for (var i = 1; i < list.Length; i++)
        {
            if (list[i] == list[i - 1])
            {
                counter++;
                if (counter <= resultFrequency) 
                    continue;
                resultFrequency = counter;
                result = list[i];
            }
            else
                counter = 0;
        }

        Console.WriteLine(result);
        return result;
    }
}