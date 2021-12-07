// Есть два отсортированных листа. Надо их смержить в новый отсортированный лист
#load "../tools.csx" 
 
Assert("-1, 0, 1, 1, 1, 3, 5, 5, 6, 7", Merge(new () {0, 1, 1, 5, 6}, new () {-1, 1, 3, 5, 7}));
Assert("-1, 0, 1, 1, 1, 3, 5, 5, 6, 7, 8, 10", Merge(new () {0, 1, 1, 5, 6}, new () {-1, 1, 3, 5, 7, 8, 10}));
Assert("-1, 0, 1, 1, 1, 3, 5, 5, 6, 7, 8, 10", Merge(new () {0, 1, 1, 5, 6, 8, 10}, new () {-1, 1, 3, 5, 7}));

string Merge(List<int> listA, List<int> listB)
{
    List<int> result = new List<int>();
    int i = 0;
    int j = 0;
    while (true)
    {
        // хвосты
        if (i == listA.Count())
        {
            while (j < listB.Count)
                {
                    result.Add(listB[j]);
                    j++;
                }
            break;
        }
            
        if (j == listB.Count())
        {
            while (i < listA.Count)
            {
                result.Add(listA[i]);
                i++;
            } 
            break;
        }
              
            
        if (listA[i] <= listB[j])
        {
            result.Add(listA[i]);
            i++;
            continue;
        }
        if (listA[i] > listB[j])
        {
            result.Add(listB[j]);
            j++;
            continue;
        }
    }
    
    Console.WriteLine($"result {string.Join(", ", result)}");
    return string.Join(", ", result);
}