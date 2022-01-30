using System;
using System.Collections.Generic;
using Xunit;

public class Lesson3Task3
{
    [Theory]
    [InlineData("A", "A")]
    [InlineData("AAAABBBC", "A4B3C")]
    [InlineData("AAAABBBCAAA", "A4B3CA3")]
    private void CheckRLE(string input, string expected) =>
        Assert.Equal(expected, RLE(input));

    // Дана строка из латинских заглавных букв.
    // Необходимо заменить все повторы одинаковых подряд идущих букв на букву + цифру.
    private string RLE(string input) {
        int counter = 0;
        char letter = input[0];
        string output = "";

        foreach (char item in input) {
            if (letter != item) {
                output = output + letter;
                if (counter > 1) {
                    output = output + counter.ToString();
                }

                letter = item;
                counter = 0;
            }

            counter++;
        }

        if (counter == 1) {
            output = output + letter;
        }
        else {
            output = output + letter + counter.ToString();
        }

        return output;
    }
}