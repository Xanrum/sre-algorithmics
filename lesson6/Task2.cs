using System;
using Xunit;

public class Lesson6Task2
{
    // Это было задание на перевод из указанной системы считсления в двоичную?  
    // Или input всегда в десятичной? А dbase - это количество разрядов в результате?
    // Я сделала первый вариант, но если это был второй, то просто надо выкинуть первый цикл))
    // O(dbase) - по времени, O(dbase) - по памяти
    [Theory]
    [InlineData(34, 8, new []{0, 0, 0, 1, 1, 1, 0, 0})]
    [InlineData(5, 8, new []{0, 0, 0, 0, 0, 1, 0, 1})]
    
    private void CheckDecoder(int input, int dbase , int[] expected) =>
        Assert.Equal(expected, Decoder(input, dbase));

    // дано число и основание декодера
    // требуется преобразочать число в массив состоящий из 0 и 1 представляющее число в двоичной системе
    private int[] Decoder(int input, int dbase)
    {
        var result = new int[dbase];
        double dec = 0;
        var inputStr = input.ToString().AsSpan();
        int pow = 0;
        for (int i = inputStr.Length - 1; i >= 0; i--)
        {
            dec += int.Parse(inputStr.Slice(i, 1)) * Math.Pow(dbase, pow);
            pow++;
        }
        
        for (int i = result.Length - 1; i >= 0 && dec >= 0; i--)
        {
            result[i] = (int)dec % 2;
            dec -= dec / 2;
        }

        return result;
    }
}