using System;
using Xunit;

public class Lesson4Task3
{
    [Theory]
    [InlineData("A4B3C", "AAAABBBC")]
    [InlineData("A4B3CA3", "AAAABBBCAAA")]
    [InlineData("(A2B)3Z", "AABAABAABZ")]
    private void CheckReverseRLE(string input, string expected) =>
        Assert.Equal(expected, ReverseRLE(input));

    // Распаковка RLE со скобками,
    // повторяющиеся блоки могут быть объеденены в скобки.
    private string ReverseRLE(string input) {

        string ExtractRLE(string str) {
            string rle = "";

            for (int i = 0; i < str.Length; i++) {
                int n = str[i] - '0';

                if (n >= 1 && n <= 9) {
                    while (n > 1) {
                        rle = rle + str[i-1];
                        n--;
                    }
                }
                else {
                    rle = rle + str[i];
                }
            }

            return rle;
        }


        string output = "";

        for (int i = 0; i < input.Length; i++) {
            if (input[i] == '(') {
                i++;
                while (input[i] != ')') {
                    output = output + input[i];
                    i++;
                }
                i++;

                int number = input[i] - '0';
                string extractedRLE = ExtractRLE(output);

                while (number > 1) {
                    output = output + extractedRLE;
                    number--;
                }
            }
            else {
                output = output + input[i];
            }
        }

        return ExtractRLE(output);
    }
}