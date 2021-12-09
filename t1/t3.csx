// Написать функцию, которая бинарным поиском ищет индекс элемента.
// На входе отсортированная коллеция с уникальными значениями.
#load "../tools.csx"

Assert(2, BinarySearch(new () {0, 1, 2, 3, 4, 5, 6}, 2));
Assert(3, BinarySearch(new () {0, 2, 3, 5, 6, 100}, 5));
Assert(9, BinarySearch(new () {3, 4, 5, 6, 8, 100, 200, 1000, 3000, 5000, 1000000}, 5000));
Assert(-1, BinarySearch(new () {0, 1, 2, 3, 4, 5, 6}, 10)); // поиск, который ничего не найдет

int BinarySearch(List<int> list, int value)
{
    int start = 0;
    int end = list.Count - 1;
    int position;

    do {
        position = start + (end - start) / 2;

        if (list[position] == value) {
            return position;
        }
        else {
            if (list[position] < value) {
                start = position;
            }
            else {
                end = position;
            }
        }
    } while (end - start > 1);

    // Максимально упоротый вариант цикла for вместо do while
    //for (int start = 0, end = list.Count - 1, position = start + (end - start) / 2; end - start > 1; position = start + (end - start) / 2) {
    //    if (list[position] == value) {
    //        return position;
    //    }
    //    else {
    //        if (list[position] < value) {
    //            start = position;
    //        }
    //        else {
    //            end = position;
    //        }
    //    }
    //}

    return -1; // везде поискали и ничего не нашли :(
}