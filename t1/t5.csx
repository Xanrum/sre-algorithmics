// Дан отсортириованный массив. Найти наиболее встречающееся значение
// Если таких значений несколько - найти первое такое значение
#load "../tools.csx" 
 
Assert(1, SearchMostFValue(new () {-1, 0, 1, 1, 1, 3, 5, 5, 6, 7}));

int SearchMostFValue(List<int> listA)
{
    var globMaxV = 0;
    var tempMaxV = 1;
    var globMaxN = 0;
    var tempMaxN = listA[0];
    foreach(var item in listA)
    {
        if(item == tempMaxN) tempMaxV++;
        else {
            if(tempMaxV>globMaxV)
            {
                globMaxV=tempMaxV;
                globMaxN = tempMaxN;

            }
            tempMaxN = item;
            tempMaxV = 1;
        }
    }
    return globMaxN;
}