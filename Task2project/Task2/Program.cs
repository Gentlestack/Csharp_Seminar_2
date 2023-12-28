
int[,] mass = new int[4, 4]
{
    {5,9,3,1 },
    {2,3,0,8 },
    {7,6,9,10 },
    {0,1,2,4 }
};
 
int bufer;
 
            
for (int j = 0; j < 4; j++)
{
    bufer = mass[0, j];
    mass[0, j] = mass[mass.GetLength(1)-1,j] ;
    mass[mass.GetLength(1)-1,j] = bufer;
 
}
            

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(mass[i, j]+ " ");
    }
    Console.WriteLine();
}