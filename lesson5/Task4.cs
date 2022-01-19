using System;
using System.Collections.Generic;
using Xunit;

public class Lesson5Task4
{
    [Theory]
    [InlineData(new[] {-8, -5, 0, 1, 4, 8, 9, 10, 15, 22, 30}, 10, "1,8;2,7;3,6")]
    [InlineData(new[] {-8, -5, 0, 0, 1, 4, 8, 9, 10, 15, 19, 19, 19, 22, 30}, 11, "0,12;0,11;0,10;4,8")]
    [InlineData(new[] {-8, -5, 0, 0, 1, 4, 8, 9, 10, 15, 22, 30}, 10, "1,9;2,8;3,8;4,7")]
    [InlineData(new[] {-13, -9, 5, 16, 22}, 22, "")]
    [InlineData(new[] {-5, 0, 1, 9, 10, 15, 22}, 10, "0,5;1,4;2,3")]
    [InlineData(new[] {0, 1, 9, 10, 15, 16}, 10, "0,3;1,2")]
    [InlineData(new[] {1, 1, 1}, 2, "0,2;0,1;1,2")]
    [InlineData(new[] {0, 1, 1, 2, 3, 4, 4, 5}, 5, "0,7;1,6;1,5;2,6;2,5;3,4")]
    [InlineData(new []{0, 1, 2, 3, 4}, 4, "0,4;1,3")]
    
    private void CheckSFindSum(int[] input, int k, string expected) =>
        Assert.Equal(expected, FindSum(input, k));

    // Дан отсортированный массив и число K
    // требуется найти два индекса по которым сумма значений равна К
    // вывести в виде массива массивов из двух значений - в значениях два индкеса, сначала идет меньший индексы
    private string FindSum(int[] input, int k)
    {
        var result = new List<string>();
        var start = 0;
        var end = input.Length-1;
        var ret = end;
        var pv2 = input[end];
        while (start != end)
        {
            var v1 = input[start];
            var v2 = input[end];
            if (v2 != pv2)
            {
                ret = end;
                pv2 = v2;
            }
            var sum = v1 + v2;
            if (sum == k)
            {
                result.Add(start + "," + end);
                if (end != 0 && input[end] == input[end - 1]) end--;
                else
                {
                    end = ret;
                    start++;
                }
            }
            if (sum > k) end--;
            if (sum < k)
            {
                start++;
                end = ret;
            }

            if (start == end && end != ret)
            {
                end = ret;
                start++;
            }
        }
        return string.Join(";", result);
    }
}