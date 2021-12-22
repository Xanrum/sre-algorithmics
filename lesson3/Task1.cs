using System;
using Xunit;

public class Lesson3Task1
{
    [Theory]
    [InlineData("(", false)]
    [InlineData("()", true)]
    [InlineData("(]", false)]
    [InlineData("({)", false)]
    [InlineData("({)}", false)]
    [InlineData("[{]}", false)]
    [InlineData("[(])", false)]
    [InlineData("{(})", false)]
    [InlineData("{[}]", false)]
    [InlineData("([]){", false)]
    [InlineData("([])}{", false)]
    [InlineData("([{}]())", true)]
    [InlineData("([{()}](){[()]})", true)]
    private void CheckSearchMostFValue(string input, bool expected) =>
        Assert.Equal(expected, CheckBraces(input));

    // Дана строка со скобочным выражением, состоящая из круглых () квадратных [] и фигурных {} скобок.
    // Требуется определить корректность этой строки.
    private bool CheckBraces(string input) {

        // слишком короткое выражение, либо нечетное кол-во символов в выражении
        if (input.Length < 2 || input.Length%2 != 0) {
            return false;
        }

        // начало и конец выражения
        if (
            input[0] == ')' ||
            input[0] == ']' ||
            input[0] == '}' ||
            input[input.Length-1] == '(' ||
            input[input.Length-1] == '[' ||
            input[input.Length-1] == '{' ) {
                return false;
            }

        // все признаки неверного выражения
        for (int i = 0; i < input.Length-1; i++) {
            string pair = input[i].ToString() + input[i+1].ToString();

            if (
                pair == "(}" ||
                pair == "(]" ||
                pair == "{)" ||
                pair == "{]" ||
                pair == "[)" ||
                pair == "[}" ) {
                    return false;
            }
        }

        return true;
    }
}