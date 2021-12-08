using System;
using Xunit;

public class Lesson1Task4
{
    [Theory]
    [InlineData(new[] { 0, 1, 1, 5, 6 }, new[] { -1, 1, 3, 5, 7 }, new[] { -1, 0, 1, 1, 1, 3, 5, 5, 6, 7 })]
    private void CheckSearchMin(int[] listA, int[] listB, int[] expected) =>
        Assert.Equal(expected, Merge(listA, listB));

    // Есть два отсортированных листа. Надо их смержить в новый отсортированный лист
    private int[] Merge(int[] listA, int[] listB) => throw new NotImplementedException();
}