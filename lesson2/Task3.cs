using System;
using System.Collections.Generic;
using Xunit;

public class Lesson2Task3
{
    [Theory]
    [InlineData(new[] { -1, 1, 1, 3, 5 }, new[] { 0, 1, 5, 6, 6, 6, 7 }, new[] { 1, 6 })]
    [InlineData(new[] { 0 }, new[] { 0 }, new[] { 0 })]
    [InlineData(new[] { 0 }, new[] { 1 }, new[] { 0, 1 })]
    private void CheckSearchMostFValue2(int[] listA, int[] listB, int[] expected) =>
        Assert.Equal(expected, SearchMostFValue2(listA, listB));

    // Даны два отсортириованных массива. Найти наиболее встречающиеся значения в объединении двух массивов.
    // Результат - отсортированный массив значений.
    // O( (a+b)^c )
    private int[] SearchMostFValue2(int[] listA, int[] listB) {
        int fCount = -1;
        List<int> fValues = new() {};
        int currentCount = 0;
        int currentValue = listA[0] < listB[0] ? listA[0] : listB[0];

        int value;

        void AddFValue() {
            if (currentCount > fCount) {
                fCount = currentCount;
                fValues.Clear();
            }

            if (currentCount == fCount) {
                fValues.Add(currentValue);
            }
        }

        for (int a = 0, b = 0; a != listA.Length || b != listB.Length; currentCount++) {
            if (b == listB.Length || a != listA.Length && listA[a] < listB[b]) {
                value = listA[a];
                a++;
            }
            else {
                value = listB[b];
                b++;
            }

            if (currentValue != value) {
                AddFValue();
                currentValue = value;
                currentCount = 0;
            }
        }

        AddFValue();

        return fValues.ToArray();
    }
}