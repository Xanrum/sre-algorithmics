// Есть два отсортированных листа. Надо их смержить в новый отсортированный лист
#load "../tools.csx" 
 
Assert(new () {-1, 0, 1, 1, 1, 3, 5, 5, 6, 7}, Merge(new () {0, 1, 1, 5, 6}, new () {-1, 1, 3, 5, 7}));

List<int> Merge(List<int> listA, List<int> listB)
{
    throw new NotImplementedException();
}