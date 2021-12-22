using System;
using Xunit;

public class Lesson1Task5
{
    [Theory]
    [InlineData(new[] { -1, 0, 1, 1, 1, 3, 5, 5, 6, 7 }, 1)]
    [InlineData(new[] { 1 }, 1)]
    [InlineData(new[] { 1, 1, 3, 3, 3, 5, 5, 5, 6 }, 3)] // 3 и 5 встречаются по три раза — берем первое
    [InlineData(new[] { 10 }, 10)] // и такое бывает
    [InlineData(new[] { 0, 1, 1 }, 1)]
    [InlineData(new[] { 1, 1 }, 1)]
    [InlineData(new[] { 0, 1 }, 0)]
    private void CheckSearchMostFValue(int[] list, int expected) => Assert.Equal(expected, SearchMostFValue(list));

    // Дан отсортированный массив. Найти наиболее встречающееся значение.
    // Если таких значений несколько — найти первое такое значение.
    // O(n)
    private int SearchMostFValue(int[] list) {
        int count = 0;
        int value = list[0];
        int fCount = 0;
        int fValue = 0;

        if (list.Length <= 2) return list[0];

        for (int i = 1; i < list.Length; i++) {
            if (list[i] != value) {
                if (count > fCount) {
                    fCount = count;
                    fValue = value;
                }
                value = list[i];
                count = 0;
            }

            count++;
        }

        return (count > fValue) ? value : fValue;
    }
}