int InputNum( string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(System.Console.ReadLine());
}

int m = InputNum("Введите число строк 1-ой матрицы: ");
int n= InputNum("Введите число столбцов 1 матрицы (и строк 2 - ой): ");
int p = InputNum("Введите число столбцов 2-й матрицы: ");

int [,] FirstMatr = new int[m,n];
CreateArray(FirstMatr);
System.Console.WriteLine("Первая матрица");
PrintArray(FirstMatr);


int[,] SecondMatr = new int[n,p];
CreateArray(SecondMatr);
System.Console.WriteLine("Вторая матрица");
PrintArray(SecondMatr);

int[,] resultMatr = new int[m,p];
MyltiplyMatr(FirstMatr, SecondMatr, resultMatr);
System.Console.WriteLine("Произведение первой и второй матрицы");
PrintArray(resultMatr);

void MyltiplyMatr(int[,]FirstMatr,int[,] SecondMatr,int[,] resultMatr )
{
    for (int i = 0; i <resultMatr.GetLength(0); i++)
    {
        for (int j = 0; j <resultMatr.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < FirstMatr.GetLength(1); k++)
            {
                sum += FirstMatr[i,k] * SecondMatr[k,j];
            }
            resultMatr[i,j] = sum;
        }
    }
}


void CreateArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] + " ");
        }
        System.Console.WriteLine();
    }
}