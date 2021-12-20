using System;
using Xunit;

public class Lesson1Task5
{
    // O(n)
    // мне больше нравится вариант SearchMostFValue. Но так и не смогла придумать, можно ли не проверять отдельно последний элемент
    [Theory]
    [InlineData(new[] {-1, 0, 1, 1, 1, 3, 5, 5, 6, 7}, 1)]
    [InlineData(new[] {-1, 0, 1, 1, 1, 3, 5, 5, 5, 5, 6, 7}, 5)]
    [InlineData(new[] {-1, 0, 1, 1, 1, 1, 3, 5, 5, 5, 5, 6, 7}, 1)]
    [InlineData(new[] {0, 1, 1}, 1)]
    [InlineData(new[] {1}, 1)]
    [InlineData(new[] {1, 2, 2}, 2)]
    private void CheckSearchMostFValue(int[] list, int expected) => Assert.Equal(expected, SearchMostFValue(list));

    // Дан отсортириованный массив. Найти наиболее встречающееся значение
    // Если таких значений несколько - найти первое такое значение
    private int SearchMostFValue(int[] list)
    {
        var resultFrequency = 1;
        var counter = 1;
        var result = list[0];
        var i = 1;
        while (i < list.Length)
        {
            if (list[i] == list[i - 1])
                counter++;
            else
            {
                if (counter > resultFrequency)
                {
                    resultFrequency = counter;
                    result = list[i - 1];
                }
                counter = 1;
            }
            i++;
        }
        
        if (counter > resultFrequency)
            result = list[i - 1];

        return result;
    }
    
    private int SearchMostFValue_old(int[] list)
    {
        var resultFrequency = 1;
        var counter = 1;
        var result = list[0];
        for (var i = 1; i < list.Length; i++)
        {
            if (list[i] == list[i - 1])
            {
                counter++;
                if (counter <= resultFrequency) 
                    continue;
                resultFrequency = counter;
                result = list[i - 1];
            }
            else
                counter = 1;
        }

        Console.WriteLine(result);
        return result;
    }
}