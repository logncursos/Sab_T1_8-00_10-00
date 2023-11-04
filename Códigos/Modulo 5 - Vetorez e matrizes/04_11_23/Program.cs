int[] original = new int[] {6,4};

int[] vendedor1 = new int[2];

int[] vendedor2 = new int[2];

for (int i = 0; i < original.Length; i++)
{
    vendedor1[i] = original[i];
    vendedor2[i] = original[i];
}

Console.WriteLine("vendedor1");
for (int i = 0; i < vendedor1.Length; i++)
{
    Console.Write(vendedor1[i] -1 +",");
}

Console.WriteLine("vendedor2");
for (int i = 0; i < vendedor1.Length; i++)
{
    Console.Write(vendedor2[i]-2+",");
}
