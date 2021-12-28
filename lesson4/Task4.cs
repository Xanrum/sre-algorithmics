using System;
using Xunit;

public class Lesson4Task4
{
    [Theory]
    [InlineData("1+2", 3)]
    [InlineData("123+257", 380)]
    [InlineData("123+257+23", 403)]
    [InlineData("+123+257+23", 403)]
    [InlineData("257", 257)]
    [InlineData("+257", 257)]
    [InlineData("1+20", 21)]
    [InlineData("1*20", 20)]
    [InlineData("2+2*2", 6)]
    private void CheckEvaluator(string input, int expected) =>
        Assert.Equal(expected, Evaluator(input));

    // Дана строка состоящая из
    // * знаков умножения
    // + знаков плюс
    // цифр 0..9
    // строка представляет арифметическое выражение
    // требуется вычислить его значение, с учетом приоритета операций
    private int Evaluator(string input) => throw new NotImplementedException();
    // {
    //     var plusPos = 0;
    //     var mulPos = 0;
    //     var sum = 0;
    //     for (var i = 0; i < input.Length; i++)
    //     {
    //         if (i == 0 && input[i] == '+')
    //         {
    //             plusPos = 1;
    //             continue;
    //         }
    //         if (i == 0 && input[i] == '*')
    //         {
    //             plusPos = 1;
    //             continue;
    //         }
    //
    //         if (input[i] != '+') continue;
    //         sum += int.Parse(input[plusPos..i]);
    //         plusPos = i;
    //     }
    //
    //     sum += int.Parse(input[plusPos..]);
    //     return sum;
    // }
}