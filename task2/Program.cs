int InputNum( string message)                                      // решил попробовать решать по другому, не так как мы решаем на семинарах
{                                                                  // брат показал как бы сделал он и я решил попробовать сделать так же
    System.Console.Write(message);                                 // вроде получилось, но манера написания, конечно, совершенно другая.
    return Convert.ToInt32(System.Console.ReadLine());
}

int n = InputNum("Введите количество строк ");
int m = InputNum("Введите количество столбцов ");
int range = InputNum("Введите оиапозон от 1 до ... ");

int[,] array = new int[n,m];
CreateArray(array);
PrintArray(array);

int minSum = 0;
int sumLine = SumLineElem(array, 0);
for (int i = 0; i < array.GetLength(0); i++)
{
    int temp = SumLineElem(array, i);
    if(sumLine > temp)
    {
        sumLine = temp;
        minSum = i;
    }
}

System.Console.WriteLine($"\n { minSum +1 } - строка с наименьшей суммой");

int SumLineElem (int [,] array, int i)
{
    int sumLine = array[i,0];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumLine+= array[i,j];
    }
    return sumLine;
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(range);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i <array.GetLength(0); i++)
    {
        //System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] + " ");
        }
        System.Console.WriteLine();
    }
}