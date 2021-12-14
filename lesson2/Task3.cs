using System;
using System.Collections.Generic;
using Xunit;

public class Lesson2Task3
{
    [Theory]
    [InlineData(new[] { -1, 1, 1, 3, 5 }, new[] { 0, 1, 5, 6, 6, 6, 7 }, new[] { 1, 6 })]
    private void CheckSearchMostFValue2(int[] listA, int[] listB, int[] expected) =>
        Assert.Equal(expected, SearchMostFValue2(listA, listB));

    // Даны два отсортириованных массива. Найти наиболее встречающиеся значения в объединении двух массивов.
    // Результат - отсортированный массив значений.
    private int[] SearchMostFValue2(int[] listA, int[] listB) {
        List<int> list = new List<int>();
        Dictionary<int, int> dict = new Dictionary<int, int>();

        int count = 0;
        int maxCount = 0;
        int value = 0;

        // -1, 0, 1, 1, 1, 3, 5, 5, 6, 6, 6, 7
        foreach (int item in Merge(listA, listB)) {
            if (count == 0) {
                value = item;
            }

            if (value != item) {
                if (count > maxCount) {
                    maxCount = count;
                }
                dict.Add(value, count);
                value = item;
                count = 0;
            }

            count++;
        }

        foreach (var item in dict) {
            if (item.Value == maxCount) {
                list.Add(item.Key);
            }
        }

        return list.ToArray();
    }

    private int[] Merge(int[] listA, int[] listB) {
        int[] listC = new int[listA.Length + listB.Length];
        int indexA = 0;
        int indexB = 0;
        int indexC = 0;

        do {
            if (indexA >= listA.Length) {
                listC[indexC] = listB[indexB];
                indexC++;
                indexB++;
                continue;
            }

            if (indexB >= listB.Length) {
                listC[indexC] = listA[indexA];
                indexC++;
                indexA++;
                continue;
            }

            if (listA[indexA] <= listB[indexB]) {
                listC[indexC] = listA[indexA];
                indexC++;
                indexA++;
            }
            else {
                listC[indexC] = listB[indexB];
                indexC++;
                indexB++;
            }
        } while (indexA < listA.Length || indexB < listB.Length);

        return listC;
    }
}