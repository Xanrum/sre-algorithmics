using System;
using Xunit;

public class Lesson4Task4
{
    [Theory]
    [InlineData("2+2*2", 6)]
    [InlineData("1+2", 3)]   // только сложение
    [InlineData("3*4", 12)]  // только умножение
    [InlineData("11*22*33+44*55", 10406)]  // всё вперемешку
    private void CheckEvaluator(string input, int expected) =>
        Assert.Equal(expected, Evaluator(input));

    // Дана строка состоящая из
    // * знаков умножения
    // + знаков плюс
    // цифр 0..9
    // строка представляет арифметическое выражение
    // требуется вычислить его значение, с учетом приоритета операций
    private int Evaluator(string input) {
        int multiplication = 1;
        int result = 0;

        string[] multiplications = input.Split('+');

        foreach (string item in multiplications) {
            foreach (string number in item.Split('*')) {
                multiplication = multiplication * Int32.Parse(number);
            }

            result = result + multiplication;
            multiplication = 1;
        }

        return result;
    }
}