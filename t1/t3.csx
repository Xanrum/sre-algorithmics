//Написать функцию которая бинарным поиском ищет индекс элемента.
// На входе отсортированная коллеция с уникальными значениями
#load "../tools.csx" 
 
Assert(2, BinarySearch(new () {0, 1, 2, 3, 4, 5, 6}, 2));
Assert(3, BinarySearch(new () {0, 2, 3, 5, 6, 100}, 5));
Assert(9, BinarySearch(new () {3, 4, 5, 6, 8, 100, 200, 1000, 3000, 5000, 1000000}, 5000));
Assert(-1, BinarySearch(new () {3, 4, 5, 6, 8, 100, 200, 1000, 3000, 5000, 1000000}, 2000));

int BinarySearch(List<int> list, int value)
{
    if(list.Count == 0) return -1;
    if(value < 0) return -1;
    var startIndex = 0;
    var endIndex = list.Count - 1;
    if (value < list[0] || value > list[list.Count - 1]) return -1;
    while (startIndex <= endIndex)
    {
        var middle = startIndex + (endIndex - startIndex) / 2;
        if (value == list[middle]) return middle;
        else if (value < list[middle]) endIndex = middle - 1;
        else startIndex = middle + 1;
    }
    return -1;
}
int BinarySearchExtended(List<int> list, int value) => list.BinarySearch(value);
