// Есть два отсортированных листа. Надо их смержить в новый отсортированный лист.
#load "../tools.csx"

Assert(new () {-1, 0, 1, 1, 1, 3, 5, 5, 6, 7}, Merge(new () {0, 1, 1, 5, 6}, new () {-1, 1, 3, 5, 7}));
Assert(new () {-10, -3, -2, -1, 0, 1, 1, 1, 3, 5, 5, 6, 7}, Merge(new () {-10, -3, -2, 0, 1, 1, 5, 6}, new () {-1, 1, 3, 5, 7})); // вариант с листами разной длины

List<int> Merge(List<int> listA, List<int> listB)
{
    List<int> listC = new List<int>();
    int indexA = 0;
    int indexB = 0;

    do {
        if (indexA >= listA.Count()) {
            listC.Add(listB[indexB]);
            indexB++;
            continue;
        }

        if (indexB >= listB.Count()) {
            listC.Add(listA[indexA]);
            indexA++;
            continue;
        }

        if (listA[indexA] <= listB[indexB]) {
            listC.Add(listA[indexA]);
            indexA++;
        }
        else {
            listC.Add(listB[indexB]);
            indexB++;
        }
    } while (indexA < listA.Count() || indexB < listB.Count());

    return listC;
}