int[,] multiDimensionalArray1 = new int[2, 3];
//1,2,- 3
//3,4,- 7

multiDimensionalArray1[0,0] = 1;
multiDimensionalArray1[0,1] = 2;
multiDimensionalArray1[1,0] = 3;
multiDimensionalArray1[1,1] = 4;

for (int l = 0; l < 2; l++)
{
    int total = 0;
    for(int c = 0; c < 3; c++){

        total += multiDimensionalArray1[l,c];

        if(c == 2){
            multiDimensionalArray1[l,c] += total;
        }
        Console.Write(multiDimensionalArray1[l,c]);
    }
    Console.WriteLine();
}
Console.WriteLine("------");

Console.WriteLine(multiDimensionalArray1[0,2]);
Console.WriteLine(multiDimensionalArray1[1,2]);