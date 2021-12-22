using System;
using System.Collections.Generic;
using Xunit;

public class Lesson2Task3
{
    // O(n) по времени, O(n) - по памяти.
    // Еще одно тупое решение, не верю, что нельзя проще, но не придумала
    [Theory]
    [InlineData(new[] {-1, 1, 1, 3, 5}, new[] {0, 1, 5, 6, 6, 6, 7}, new[] {1, 6})]
    [InlineData(new[] {-1, 1, 1, 3, 5}, new[] {0, 1, 5, 6, 6, 6, 7, 7, 7, 7, 8}, new[] {7})]
    [InlineData(new[] {0}, new[] {0}, new[] {0})]
    [InlineData(new[] {0}, new[] {1}, new[] {0, 1})]
    [InlineData(new[] {0}, new[] {1, 2, 3}, new[] {0, 1, 2, 3})]
    private void CheckSearchMostFValue(int[] listA, int[] listB, int[] expected) =>
        Assert.Equal(expected, SearchMostFValue(listA, listB));

    // Даны два отсортириованный массива. Найти наиболее встречающееся значения в объединении двух массивов
    // Результат - отсортированный массив значений

    private int[] SearchMostFValue(int[] listA, int[] listB)
    {
        var resultValues = new List<int>();
        var i = 0;
        var j = 0;
        var resultFrequency = 1;
        var counter = 1;
        int current;
        int previous;

        if (listA[i] <= listB[j])
        {
            current = listA[i];
            resultValues.Add(current);
            i++;
        }
        else
        {
            current = listB[j];
            resultValues.Add(current);
            j++;
        }
        
        while (i < listA.Length && j < listB.Length)
        {
            previous = current;
            if (listA[i] <= listB[j])
            {
                current = listA[i];
                i++;
            }
            else
            {
                current = listB[j];
                j++;
            }

            if (current == previous)
                counter++;
            else
            {
                if (counter == resultFrequency) resultValues.Add(counter > 1 ? previous : current);
                if (counter > resultFrequency)
                {
                    resultFrequency = counter;
                    resultValues.Clear(); // Наверно тут можно использовать магию ArrayPool
                    resultValues.Add(previous);
                }
                counter = 1;
            }
        }
        
        

        while (j < listB.Length)
        {
            previous = current;
            current = listB[j];
            if (current == previous)
                counter++;
            else
            {
                if (counter == resultFrequency) resultValues.Add(counter > 1 ? previous : current);
                if (counter > resultFrequency)
                {
                    resultFrequency = counter;
                    resultValues.Clear();
                    resultValues.Add(previous);
                }
                counter = 1;
            }
            j++;
        }

        while (i < listA.Length)
        {
            previous = current;
            current = listA[i];
            if (current == previous)
                counter++;
            else
            {
                if (counter == resultFrequency) resultValues.Add(counter > 1 ? previous : current);
                if (counter > resultFrequency)
                {
                    resultFrequency = counter;
                    resultValues.Clear();
                    resultValues.Add(previous);
                }
                counter = 1;
            }
            i++;
        }

        return resultValues.ToArray();
    }

    
    // старое неоптимальное решение
    private int[] SearchMostFValue2(int[] listA, int[] listB)
    {
        var resultDict = new Dictionary<int, int>();
        var resultList = new List<int>();  
        var list = Merge(listA, listB);
        Console.WriteLine(String.Join(", ", list));

        var counter = 0;
        for (var i = 1; i < list.Length; i++)
        {
            if (list[i] == list[i - 1])
                counter++;
            else
            {
                resultDict.Add(list[i - 1], counter);
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