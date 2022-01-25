using System;
using System.Linq;
using Xunit;

public class Lesson6Task4
{
    // O(n) - по времени, O(1) - по памяти
    [Theory]
    [InlineData(new [] {"1,0,0,1",
                        "0,0,0,1",
                        "0,0,0,1",
                        "1,1,0,1"}, 3)]
    [InlineData(new [] {"1,0,1,0",
                        "0,0,1,0",
                        "0,0,0,0",
                        "1,1,0,0"}, 3)]
    [InlineData(new [] {"1,0,1,0",
                        "0,0,1,0",
                        "1,0,0,0",
                        "0,0,1,0"}, 4)]
    [InlineData(new []{"1,0","0,0"}, 1)]
    
    private void CheckCountShips(string[] rawInput,int expected)
    {
        var input = rawInput.Select(p => p.Split(',').Select(int.Parse).ToArray()).ToArray();
        Assert.Equal(expected, CountShips(input));
    }

    // дан массив массивов представляющее игровое поле
    // игровое поле любого квадратного размера
    // на поле расставлены корабли как в морском бое с соблюдением всех правил расстановки
    // корабли 1-4 палубные
    // 0 - клетка пуста
    // 1 - на клетке палуба корабля
    // требуется посчитать количество кораблей
    private int CountShips(int[][] input)
    {
        var result = 0;
        var len = input.Length;
        for (int i = 0; i < len - 1; i++)
        {
            for (int j = 0; j < len - 1; j++)
                if (input[i][j] == 1 && input[i][j + 1] == 0 && input[i + 1][j] == 0)
                    result++;

            if (input[i][len - 1] == 1 && input[i + 1][len - 1] == 0)
                result++;
        }

        for (int j = 0; j < len - 1; j++)
            if (input[len - 1][j] == 1 && input[len - 1][j + 1] == 0)
                result++;

        if (input[len - 1][len - 1] == 1)
            result++;

        return result;
    }
}