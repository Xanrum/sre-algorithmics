// Написать функцию, находящую минимальное значение в отсортированном листе
#load "../tools.csx"

Assert(2, SearchMin(new () {2, 3, 4, 5, 6}));
Assert(0, SearchMin(new () {0, 2, 3, 5, 6, 100}));
Assert(1000, SearchMin(new () {1000, 3000, 5000, 1000000}));

int SearchMin(List<int> list)
{
    return list[0];
}