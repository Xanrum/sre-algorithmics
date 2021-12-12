// Дан отсортириованный массив. Найти наиболее встречающееся значение
// Если таких значений несколько - найти первое такое значение
#load "../tools.csx"

Assert(1, SearchMostFValue(new () {-1, 0, 1, 1, 1, 3, 5, 5, 6, 7}));
Assert(3, SearchMostFValue(new () {1, 1, 3, 3, 3, 5, 5, 5, 6})); // 3 и 5 встречаются по три раза — берем первое
Assert(10, SearchMostFValue(new () {10})); // и такое бывает

int SearchMostFValue(List<int> listA)
{
    int count = 0;
    int value = 0;
    int fCount = 0;
    int fValue = 0;

    foreach (int item in listA) {
        if (count == 0) {
            value = item;
        }
        else {
            if (value != item) {
                if (fCount < count) {
                    fCount = count;
                    fValue = value;
                }

                value = item;
                count = 0;
            }
        }
        count++;

    }

    return listA.Count == 1 ? listA[0] : fValue;
}