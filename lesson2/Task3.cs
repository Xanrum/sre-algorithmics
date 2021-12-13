using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

public class Lesson2Task3
{
    // Вроде и O(n), а вроде и совсем не нравится, как решила 
    [Theory]
    [InlineData(new[] {-1, 1, 1, 3, 5}, new[] {0, 1, 5, 6, 6, 6, 7}, new[] {1, 6})]
    [InlineData(new[] {-1, 1, 1, 3, 5}, new[] {0, 1, 5, 6, 6, 6, 7, 7, 7, 7, 8}, new[] {7})]
    private void CheckSearchMostFValue2(int[] listA, int[] listB, int[] expected) =>
        Assert.Equal(expected, SearchMostFValue2(listA, listB));

    // Даны два отсортириованный массива. Найти наиболее встречающееся значения в объединении двух массивов
    // Результат - отсортированный массив значений
    private int[] SearchMostFValue2(int[] listA, int[] listB)
    {
        var resultDict = new Dictionary<int, int>();
        var resultList = new List<int>(); // листы таки можно или нет? 
        var list = Merge(listA, listB);
        Console.WriteLine(String.Join(", ", list));

        var counter = 0;
        for (var i = 1; i < list.Length; i++)
        {
            if (list[i] == list[i - 1])
                counter++;
            else
            {
                resultDict.Add(list[i -1], counter);
                counter = 0;
            }
        }

        var maxFrequency = 0;
        foreach (var freq in resultDict.Values)
            if (freq > maxFrequency)
                maxFrequency = freq;

        foreach (var element in resultDict)
        {
            if (element.Value == maxFrequency)
                resultList.Add(element.Key);
        }
        
        return resultList.ToArray();
    }

    // это копипаст из прошлого задания
    private int[] Merge(int[] listA, int[] listB)
    {
        var result = new int[listA.Length + listB.Length];

        var i = 0;
        var j = 0;
        var k = 0;
        while (true)
        {
            // хвосты
            if (i == listA.Length)
            {
                while (j < listB.Length)
                {
                    result[k] = listB[j];
                    k++;
                    j++;
                }

                break;
            }

            if (j == listB.Length)
            {
                while (i < listA.Length)
                {
                    result[k] = listA[i];
                    k++;
                    i++;
                }

                break;
            }


            if (listA[i] <= listB[j])
            {
                result[k] = listA[i];
                k++;
                i++;
                continue;
            }

            if (listA[i] > listB[j])
            {
                result[k] = listB[j];
                k++;
                j++;
            }
        }

        return result;
    }
}