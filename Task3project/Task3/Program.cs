int[,] Array = new int[,] {{19, 3, 5}, {5, 6, -1}, {10, 5, 2}};

int minSum = 0;
for (int i = 0; i < Array.GetLength(1); i++)
{
    minSum += Array[0, i];
}

int sum = 0;
for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        sum += Array[i, j];
    }
    if (sum < minSum)
    {
        minSum = sum;
    }

    sum = 0;
}

Console.WriteLine(minSum);