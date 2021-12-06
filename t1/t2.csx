// Написать функцию, находящую минимальное значение в отсортированном листе
#load "../tools.csx"

Assert(2, SearchMin(new () {2, 3, 4, 5, 6}));
Assert(0, SearchMin(new () {0, 2, 3, 5, 6, 100}));
Assert(1000, SearchMin(new () {1000, 3000, 5000, 1000000}));
Assert(-1, SearchMin(new () {6, 5, 4, 3, 0, -1})); // не ну а че, отсортированный в другую сторону — тоже отсортированный

int SearchMin(List<int> list)
{
    if (list.First() < list.Last()) {
        return list.First();
    }
    else {
        return list.Last();
    }

    // В случае, если отсортированный список считается только отсортированный всегда от меньшего к большему, то тупо:
    // return list.First();
}