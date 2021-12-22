using System;
using Xunit;

public class Lesson2Task2
{
    [Theory]
    [InlineData(new[] { 0, 1, 0, 1 }, new[] { 0, 0, 1, 1 })]
    [InlineData(new[] { 0 }, new[] { 0 })]
    [InlineData(new[] { 1 }, new[] { 1 })]
    [InlineData(new[] { 1, 1, 1, 0, 0, 0 }, new[] { 0, 0, 0, 1, 1, 1 })]
    [InlineData(new[] { 1 }, new[] { 1 })] // внезапно массив из одного элемента
    [InlineData(new[] { 0 }, new[] { 0 })] // внезапно массив из одного элемента
    [InlineData(new[] { 1, 1, 1, 1, 0, 0, 0 }, new[] { 0, 0, 0, 1, 1, 1, 1 })] // массив нечетной длины
    private void CheckBinarySort(int[] list, int[] expected) =>
        Assert.Equal(expected, BinarySort(list));

    // Дан массив состоящий только из 0 и 1.
    // Требуется отсортировать его.
    // O(n)
    private int[] BinarySort(int[] list) {
        int[] sortedList = new int[list.Length];
        int index = sortedList.Length-1;

        foreach (int item in list) {
            if (item != 0) {
                sortedList[index] = 1;
                index--;
            }
        }

        return sortedList;
    }
}