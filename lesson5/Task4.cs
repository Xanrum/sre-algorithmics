using System;
using Xunit;

public class Lesson5Task4
{
    [Theory]
    [InlineData(new []{0, 1, 2, 3, 4}, 4, "0,4;1,3")]

    private void CheckSFindSum(int[] input, int k, string expected) =>
        Assert.Equal(expected, FindSum(input, k));

    // Дан отсортированный массив и число K.
    // Требуется найти два индекса, по которым сумма значений равна К.
    // Вывести в виде массива массивов из двух значений - в значениях два индекса, сначала идет меньший индекс.
    private string FindSum(int[] input, int k) {
        //int[][] result = new int[][]{};
        string result = "";

        for (int i = 0; i < input.Length; i++) {
            for (int n = i + 1; n < input.Length && n <= k; n++) {
                if ((input[i] + input[n]) == k) {
                    if (result.Length > 0) {
                        result = result + ";";
                    }
                    result = result + input[i] + "," + input[n];
                }
            }
        }

        return result;
    }
}