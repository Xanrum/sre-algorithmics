using System;
using System.Collections.Generic;
using Xunit;

public class Lesson3Task1
{
    [Theory]
    [InlineData("(", false)]
    [InlineData("()", true)]
    [InlineData("()))", false)]
    [InlineData("(]", false)]
    [InlineData("({)", false)]
    [InlineData("([)]", false)]
    [InlineData("))", false)]
    [InlineData(")(", false)]
    [InlineData("())(", false)]
    private void CheckSearchMostFValue(string input, bool expected) =>
        Assert.Equal(expected, CheckBracers(input));

    // Дана строка со скобочным выражением состоящая из круглых () квадратных [] и фигурных {} скобок
    // требуется определить корректность этой строки
    private bool CheckBracers(string input)
    {
        var st = new List<char>();
        foreach (var item in input)
        {
            if (item == '(') st.Add(item);
            if (item == '{') st.Add(item);
            if (item == '[') st.Add(item);
            if (item == ')')
            {
                if (st.Count == 0) return false;
                if (st[^1] == '(') st.RemoveAt(st.Count - 1);
                else return false;
            }

            if (item == '}')
            {
                if (st.Count == 0) return false;
                if (st[^1] == '{') st.RemoveAt(st.Count - 1);
                else return false;
            }

            if (item == ']')
            {
                if (st.Count == 0) return false;
                if (st[^1] == '[') st.RemoveAt(st.Count - 1);
                else return false;
            }
        }

        return st.Count == 0;
    }
}