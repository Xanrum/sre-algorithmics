//Написать функцию Sum что складывает два целых числа
#load "../tools.csx"

Assert(3, Sum(1, 2));
Assert(1, Sum(-1, 2));
Assert(0, Sum(0, 0));

int Sum(int a, int b)
{
    return a + b;
}