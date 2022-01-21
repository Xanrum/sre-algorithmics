using System;
using System.Linq;
using Xunit;

public class Lesson6Task4
{
    [Theory]
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
    private int CountShips(int[][] input) => throw new NotImplementedException();
}