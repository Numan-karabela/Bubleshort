
int[] Numbers = [1, 0, 5, 8, 2, 9, 3, 6, 4, 7];

Bubleshort(Numbers);
void Bubleshort<T>(T[] Array)
{

    for (int i = 0; i < Array.Length; i++)
    {
        for (int j = 0; j < Array.Length - 1 - 1; j++)
        {
            if (Comparer<T>.Default.Compare(Array[j], Array[j + 1]) > 0)
            {
                var temp = Array[j];
                Array[j] = Array[j + 1];
                Array[j + 1] = temp;
            }
        }
    }
}




