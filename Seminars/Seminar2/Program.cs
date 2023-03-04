// Метод генерирует двумерный массив
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array; 
}

// Метод выводит на экран 2 мерный массив
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

//////////////////////////////////////////////////////////////
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double[,] CreateRandom2dArrayDouble(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().NextDouble() * 10 - 5;
            array[i,j] = Math.Round(array[i,j],1);
        }
    return array; 
}
void Show2dArrayDouble(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("==================================================");
Console.WriteLine("Task 47");
double[,] dArray = CreateRandom2dArrayDouble(3,4);
Show2dArrayDouble(dArray); 

///////////////////////////////////////////////////////////////////////////////////////////////////
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
string GetElement(int x, int y)
{
    if (x >= dArray.GetLength(0) || y >= dArray.GetLength(1))
        return "The specified element is outside the bounds of the array";
    else
        return Convert.ToString(dArray[x,y]);
}

Console.WriteLine("==================================================");
Console.WriteLine("Task 50");
Console.WriteLine("Enter position element in array");
Console.Write("X = ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y = ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetElement(x,y));

////////////////////////////////////////////////////////////////////////////////
//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine("==================================================");
Console.WriteLine("Task 52");
void ShowArithmeticMean(int[,] ar)
{
    int summ;
    Console.Write("Arithmetic mean by columns: ");
    for(int j = 0; j < ar.GetLength(1); j++)
    {
        summ = 0;
        for(int i = 0; i < ar.GetLength(0); i++)
            summ += ar[i,j];
        Console.Write(Math.Round(Convert.ToDouble(summ) / ar.GetLength(0),1) + " ");
    }
    Console.WriteLine();
}

int[,] array = CreateRandom2dArray();
Show2dArray(array);
ShowArithmeticMean(array);
