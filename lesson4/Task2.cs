using System;
using Xunit;

public class Lesson4Task4
{
    [Theory]
    [InlineData(new []{1, 2, 3}, 4, new []{new int[]{ 0, 3 }})]
    private void CheckSFindSum(int[] input, int k, int[][] expected) =>
        Assert.Equal(expected, FindSum(input, k));

    // Дан отсортированный массив и число K
    // требуется найти индексы по которым сумма значений равна К
    // вывести в виде массива массивов из двух значений - в значениях два ииндеса, сначала идет меньший индексы
    private int[][] FindSum(int[] input, int k) => throw new NotImplementedException();
}