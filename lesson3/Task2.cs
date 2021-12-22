using System;
using Xunit;

public class Lesson3Task2
{
    [Theory]
    [InlineData("1+2", 3)]
    [InlineData("1+20", 21)]
    [InlineData("0+0", 0)]
    [InlineData("1+2+3", 6)]
    private void CheckSumator(string input, int expected) =>
        Assert.Equal(expected, Sumator(input));

    // Дано корректное арифметическое выражение, состоящее только из цифр и знаков плюс +.
    // Требуется произвести вычисление значения выражения.
    private int Sumator(string input) {
        int sum = 0;
        string numbers = "";

        foreach (char item in input) {
            if (item != '+') {
                numbers = numbers + item.ToString();
                continue;
            }

            sum = sum + Int32.Parse(numbers);
            numbers = "";
        }

        sum = sum + Int32.Parse(numbers);

        return sum;
    }
}