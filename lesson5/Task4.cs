using System;
using Xunit;

public class Lesson5Task4
{
    [Theory]
    [InlineData(new []{0, 1, 2, 3, 4}, 4, "0,4;1,3")]
    
    private void CheckSFindSum(int[] input, int k, string expected) =>
        Assert.Equal(expected, FindSum(input, k));

    // Дан отсортированный массив и число K
    // требуется найти два индекса по которым сумма значений равна К
    // вывести в виде массива массивов из двух значений - в значениях два индкеса, сначала идет меньший индексы
    private string FindSum(int[] input, int k)
    {
        var result = "";
        var start = 0;
        var end = input[^1];
        return result;
    }
}