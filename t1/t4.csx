// Есть два отсортированных листа. Надо их смержить в новый отсортированный лист
#load "../tools.csx" 
 
Assert(new () {-1, 0, 1, 1, 1, 3, 5, 5, 6, 7}, Merge(new () {0, 1, 1, 5, 6}, new () {-1, 1, 3, 5, 7}));

List<int> Merge(List<int> listA, List<int> listB)
{
    var res = new List<int>(new int[listA.Count+listB.Count]);
    var (c,i,j) = (0,0,0);
    while (i < listA.Count && j < listB.Count)
    {
        if (listA[i] < listB[j])
        {

            res[c] = listA[i];
            ++i;
        }
        else 
        {
            res[c] = listB[j];
            ++j;
        } 
        ++c;
    }
    while (i < listA.Count)
    {  
        res[c] = listA[i];  
        ++i;  
        ++c;
    }
    while (j < listB.Count)
    {  
        res[c] = listB[j];  
        ++j;  
        ++c;
    }
    return res;
}

List<int> MergeExtended(List<int> listA, List<int> listB)
{
    listA.AddRange(listB);
    listA.Sort();
    return listA;
}