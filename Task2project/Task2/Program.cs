
int[,] mass = new int[3, 4]
{
    {5, 9, 3, 1},
    {2, 3, 0, 8},
    {7, 6, 9, 10}
};
 


for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write(mass[i, j]+ " ");
    }
    Console.WriteLine();
}
