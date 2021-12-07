// Дан отсортириованный массив. Найти наиболее встречающееся значение
// Если таких значений несколько - найти первое такое значение
#load "../tools.csx" 
 
Assert(1, SearchMostFValue(new () {-1, 0, 1, 1, 1, 3, 5, 5, 6, 7}));
Assert(5, SearchMostFValue(new () {-1, 0, 1, 1, 1, 3, 5, 5, 5, 5, 6, 7}));
Assert(1, SearchMostFValue(new () {-1, 0, 1, 1, 1, 1, 3, 5, 5, 5, 5, 6, 7}));

int SearchMostFValue(List<int> list)
{
    int result = 0;
    int resultFrequrncy = 0;
    int counter = 0;
    for (int i=0; i<list.Count - 1 ; i++)
    {
        while (list[i] == list[i+1])
        {
            counter++;
            i++;
        }
        if (counter > resultFrequrncy)
        {
            resultFrequrncy = counter;
            result = list[i];
        }
        counter = 0;
        i++;
    }
    Console.WriteLine(result);
    return result;
}