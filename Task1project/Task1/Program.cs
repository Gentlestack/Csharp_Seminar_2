int stringIndex = 1;
int columnIndex = 2;

int[,] myArr = new int[2,2] {
      {1,10},
      {2,20}
};

if ((myArr.GetLength(0) > stringIndex) && (myArr.GetLength(1) > columnIndex))
{
    Console.WriteLine(myArr[stringIndex, columnIndex]);
}

else
{
    Console.WriteLine("Такого элемента нет");
}
