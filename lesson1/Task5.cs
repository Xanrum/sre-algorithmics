using System;
using Xunit;

public class Lesson1Task5
{
    [Theory]
    [InlineData(new[] { -1, 0, 1, 1, 1, 3, 5, 5, 6, 7 }, 1)]
    [InlineData(new[] { 0, 1, 1 }, 1)]
    [InlineData(new[] { 1 }, 1)]
    [InlineData(new[] { 0, 1 }, 0)]
    private void CheckSearchMostFValue(int[] list, int expected) => Assert.Equal(expected, SearchMostFValue(list));

    // Дан отсортириованный массив. Найти наиболее встречающееся значение
    // Если таких значений несколько - найти первое такое значение
    //O(N)
    private int SearchMostFValue(int[] list)
    {
        var globMaxV = 0;
        var tempMaxV = 1;
        var globMaxN = 0;
        var tempMaxN = list[0];
        foreach (var item in list)
        {
            if (item != tempMaxN)
            {
                if (tempMaxV > globMaxV)
                {
                    globMaxV = tempMaxV;
                    globMaxN = tempMaxN;
                }

                tempMaxN = item;
                tempMaxV = 1;
            }

            tempMaxV++;
        }

        if (tempMaxV > globMaxV) globMaxN = tempMaxN;
        return globMaxN;
    }
}