using System;
using Xunit;

public class Lesson1Task5
{
    [Theory]
    [InlineData(new[] { -1, 0, 1, 1, 1, 3, 5, 5, 6, 7 }, 1)]
    [InlineData(new[] { 1, 1, 3, 3, 3, 5, 5, 5, 6 }, 3)] // 3 и 5 встречаются по три раза — берем первое
    [InlineData(new[] { 10 }, 10)] // и такое бывает
    private void CheckSearchMostFValue(int[] list, int expected) => Assert.Equal(expected, SearchMostFValue(list));

    // Дан отсортированный массив. Найти наиболее встречающееся значение.
    // Если таких значений несколько — найти первое такое значение.
    private int SearchMostFValue(int[] list) {
        int count = 0;
        int value = 0;
        int fCount = 0;
        int fValue = 0;

        foreach (int item in list) {
            if (count == 0) {
                value = item;
            }

            if (value != item) {
                if (fCount < count) {
                    fCount = count;
                    fValue = value;
                }

                value = item;
                count = 0;
            }

            count++;
        }

        return list.Length == 1 ? list[0] : fValue;
    }
}