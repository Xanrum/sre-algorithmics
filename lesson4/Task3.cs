using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

public class Lesson4Task3
{
    [Theory]
    [InlineData("A4B3C", "AAAABBBC")]
    [InlineData("A4B3CA3", "AAAABBBCAAA")]
    [InlineData("(A2B)3Z", "AABAABAABZ")]
    private void CheckEvaluator(string input, string expected) =>
        Assert.Equal(expected, ReversRLE(input));

    class MyQueue
    {
        private readonly string _list;
        private int _index = 0;

        public MyQueue(string list)
        {
            _list = list;
        }

        public char Peak() => _list[_index];
        public bool Next() => _index++ == _list.Length;

        public int ReadCount()
        {
            if (_index == _list.Length || !char.IsDigit(Peak())) return 1;
            var result = 0;
            while (char.IsDigit(Peak()))
            {
                result = result * 10 + Peak() - '0';
                Next();
            }

            return result;
        }
    }

    // распаковка RLE со скобками
    // поdторяющиеся блоки могут быть объеденены в скобки
    private string ReversRLE(string input)
        => Sub(new MyQueue("("+input+")"));


    private string Sub(MyQueue queue)
    {
        var subResult = "";
        if (queue.Peak() == '(')
        {
            queue.Next();
            while (queue.Peak() != ')')
            {
                subResult += Sub(queue);
            }
            
        }
        else
        {
            subResult = queue.Peak().ToString();
        }
        
        queue.Next();
        var count = queue.ReadCount();
        var result = "";
        for (var i = 0; i < count; i++)
        {
            result += subResult;
        }
        return result;
    }
}