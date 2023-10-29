int[,] multiDimensionalArray1 = new int[2, 4] { { 1, 2, 5, 0 }, { 3, 4, 6, 0 } };

for (int l = 0; l < 2; l++)
{
    int total = 0;
    for (int c = 0; c < 3; c++)
    {
        total += multiDimensionalArray1[l, c];
        multiDimensionalArray1[l, 3] = total;
        Console.Write(multiDimensionalArray1[l, c] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("------");

for (int l = 0; l < 2; l++)
{
    for (int c = 0; c < 4; c++)
    {
        Console.Write(multiDimensionalArray1[l, c] + " ");
    }
    Console.WriteLine();
}
