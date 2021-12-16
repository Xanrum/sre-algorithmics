using System;
using System.Collections.Generic;
using Xunit;

public class Lesson2Task3
{
    [Theory]
    [InlineData(new[] { -1, 1, 1, 3, 5 }, new[] { 0, 1, 5, 6, 6, 6, 7 }, new[] { 1, 6 })]
    private void CheckSearchMostFValue2(int[] listA, int[] listB, int[] expected) =>
        Assert.Equal(expected, SearchMostFValue2(listA, listB));

    //Асимптотика
    //Вычислительная О(N)
    //Память в худшем случае О(N)
    // Даны два отсортириованный массива. Найти наиболее встречающееся значения в объединении двух массивов
    // Результат - отсортированный массив значений
    private int[] SearchMostFValue2(int[] listA, int[] listB)
    {
        var i1 = 0;
        var i2 = 0;

        var recordCount = -1;
        List<int> recordValue = new();
        var currentCount = 0;
        var currentValue = listA[0] < listB[0] ? listA[0] : listB[0];

        void AddToRecord()
        {
            if (currentCount > recordCount)
            {
                recordValue.Clear();
                recordCount = currentCount;
            }

            if (currentCount == recordCount) recordValue.Add(currentValue);
        }

        while (i1 != listA.Length || i2 != listB.Length)
        {
            int value;
            if (i2 == listB.Length || i1 != listA.Length && listA[i1] < listB[i2])
            {
                value = listA[i1];
                i1++;
            }
            else
            {
                value = listB[i2];
                i2++;
            }

            if (currentValue != value)
            {
                AddToRecord();
                currentValue = value;
                currentCount = 0;
            }

            currentCount++;
        }

        AddToRecord();

        return recordValue.ToArray();
    }
}