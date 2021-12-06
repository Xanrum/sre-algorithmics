// Написать функцию, которая бинарным поиском ищет индекс элемента.
// На входе отсортированная коллеция с уникальными значениями.
#load "../tools.csx"

Assert(2, BinarySearch(new () {0, 1, 2, 3, 4, 5, 6}, 2));
Assert(3, BinarySearch(new () {0, 2, 3, 5, 6, 100}, 5));
Assert(9, BinarySearch(new () {3, 4, 5, 6, 8, 100, 200, 1000, 3000, 5000, 1000000}, 5000));
Assert(-1, BinarySearch(new () {0, 1, 2, 3, 4, 5, 6}, 10)); // поиск, который ничего не найдет

int BinarySearch(List<int> list, int value)
{
    int index = list.Count() / 2;

    while (true) {
        if (list[index] == value) {
            return index;
        }
        else {
            if (list[index] < value) {
                index++;
            }
            else {
                index--;
            }
        }

        // дошли до начала или конца — и ничего не нашли :(
        if (index == 0 || index == list.Count()) {
            return -1;
        }
    }
}