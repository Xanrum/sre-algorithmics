using System;
using Xunit;

public class Lesson3Task2
{
    // O(n) - по времени, O(1) - по памяти
    // .AsSpan() не требует выделения памяти? Вот тут довольно странный пример https://docs.microsoft.com/en-us/archive/msdn-magazine/2018/january/csharp-all-about-span-exploring-a-new-net-mainstay#what-is-spant
    [Theory]
    [InlineData("1+2", 3)]
    [InlineData("1+21+3+94", 119)]
    [InlineData("1111+21+3+4+", 1139)] // все как на маковском калькуляторе, да
    [InlineData("1+20", 21)]
    private void CheckSumator(string input, int expected) =>
        Assert.Equal(expected, Sumator(input));

    // Дано корректное арифметическое выражение состоящее только из цифр и знаков плюс +
    // Требуется произвести вычисление значения выражения
    private int Sumator(string input)
    {
        var result = 0;
        var startIndex = 0;
        var count = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] != '+')
                count++;
            else
            {
                result += int.Parse(input.AsSpan(startIndex, count));
                startIndex = i + 1;
                count = 0;
            }
        }

        if (count != 0)
            result += int.Parse(input.AsSpan(startIndex, count));

        return result;
    }
}