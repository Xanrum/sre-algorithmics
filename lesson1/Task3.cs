using System;
using Xunit;

public class Lesson1Task3
{
    [Theory]
    [InlineData(new[] { 0, 1, 2, 3, 4, 5, 6 }, 2, 2)]
    [InlineData(new[] { 0, 2, 3, 5, 6, 100 }, 5, 3)]
    [InlineData(new[] { 3, 4, 5, 6, 8, 100, 200, 1000, 3000, 5000, 1000000 }, 5000, 9)]
    private void CheckBinarySearch(int[] list, int value, int expected) =>
        Assert.Equal(expected, BinarySearch(list, value));

    // функция которая бинарным поиском ищет индекс элемента.
    // На входе отсортированная коллеция с уникальными значениями
    private int BinarySearch(int[] list, int value)
    {
        var lastIndex = list.Length - 1;
        var firstIndex = 0;

        while(firstIndex <= lastIndex)
        {
            var middleIndex = (lastIndex + firstIndex) / 2;
            var middleValue = list[middleIndex];
            if (middleValue == value)
                return middleIndex;
            if (value < middleValue)
                lastIndex = middleIndex;
            if (value > middleValue)
                firstIndex = middleIndex;
        }
        return 0;
    }
}