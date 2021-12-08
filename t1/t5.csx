// Дан отсортириованный массив. Найти наиболее встречающееся значение
// Если таких значений несколько - найти первое такое значение
#load "../tools.csx"

Assert(1, SearchMostFValue(new () {-1, 0, 1, 1, 1, 3, 5, 5, 6, 7}));
Assert(3, SearchMostFValue(new () {1, 1, 3, 3, 3, 5, 5, 5, 6})); // 3 и 5 встречаются по три раза — берем первое

int SearchMostFValue(List<int> listA)
{
    Dictionary<int, int> repeat = new Dictionary<int, int>();

    for (int i = 0; i < listA.Count(); i++) {
        if (repeat.ContainsKey(listA[i])) {
            if (listA[i] == listA[i-1]) {
                repeat[listA[i]] += 1;
            }
        }
        else {
            repeat[listA[i]] = 1;
        }
    }

    foreach(KeyValuePair<int, int> item in repeat) {
        if (item.Value == repeat.Values.Max()) {
            return item.Key;
        }
    }

    return -1;
}