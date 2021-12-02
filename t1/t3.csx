//Написать функцию которая бинарным поиском ищет индекс элемента.
// На входе отсортированная коллеция с уникальными значениями
#load "../tools.csx" 
 
Assert(2, BinarySearch(new () {0, 1, 2, 3, 4, 5, 6}, 2));
Assert(3, BinarySearch(new () {0, 2, 3, 5, 6, 100}, 5));
Assert(9, BinarySearch(new () {3, 4, 5, 6, 8, 100, 200, 1000, 3000, 5000, 1000000}, 5000));

int BinarySearch(List<int> list, int value)
{
    throw new NotImplementedException();
}