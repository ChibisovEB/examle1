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

//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
void ArraySortInRow (int[,] array, int sortBy = 0)
// sortBy = 0 - сортировка по возрастанию
// sortBy = 1 - сортировка по убывнию
{
    for (var i = 0; i < array.GetLength(0); i++)
        //сортировка пузырьком
        for (var j = 0; j < array.GetLength(1); j++)
            for (var k = 0; k < array.GetLength(1); k++)
            {
                if (sortBy == 0)
                {
                    if (array[i, j] >= array[i, k]) continue;
                }
                else
                { 
                    if (array[i, j] <= array[i, k]) continue;
                }
                var temp = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = temp;
            }
}

int[,] array = CreateRandom2dArray();
Show2dArray(array);
ArraySortInRow(array, 0);
Show2dArray(array);
////////////////////////////////////////////////////////////////////////
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
int[] AmountByLines(int[,] array)
{
    int[] temp = new int[array.GetLength(0)];
    int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            temp[i] += array[i,j];
    return temp;
}
int GetMinElement(int[] array)
{
    int rowMin = 0;
    for(int i = 1; i < array.Length; i++)
        if(array[rowMin] > array[i]) rowMin = i;
    return rowMin + 1;
}
Console.WriteLine("Task 56");
int[] arraySum = AmountByLines(array);
Console.WriteLine($"{GetMinElement(arraySum)} строка");
////////////////////////////////////////////////////////////////////////
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int[,] CreateRandomMatrix(int rows, int columns)
{
    int minValue = 0;
    int maxValue = 9;
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array; 
}
int[,] MultipleMatrix(int[,] m1, int[,] m2)
{
        int rows1 = m1.GetLength(0);
        int cols1 = m1.GetLength(1);
        int rows2 = m2.GetLength(0);
        int cols2 = m2.GetLength(1);

        int[,] result = new int[rows1, cols2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                int sum = 0;
                for (int k = 0; k < cols1; k++)
                    sum += m1[i, k] * m2[k, j];
                result[i, j] = sum;
            }
        }

        return result;
}
Console.WriteLine();
Console.WriteLine("Task 58");
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] mattrix1 = CreateRandomMatrix(rows,columns);
int[,] mattrix2 = CreateRandomMatrix(columns,rows);
Show2dArray(mattrix1);
Show2dArray(mattrix2);
Show2dArray(MultipleMatrix(mattrix1, mattrix2));

//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int[,,] CreateThreeArray(int s1, int s2, int s3)
{
    int[,,] threeArray = new int[s1,s2,s3];
    for(int i = 0; i < s1; i++)
        for(int j = 0; j < s2; j++)
            for(int k = 0; k < s3; k++)
            {
                int temp = 0;
                while(NumberExists(threeArray,temp)) 
                { //поиск следующего уникального числа
                    temp = new Random().Next(10,  100);
                }
                threeArray[i,j,k] = temp;
            }
    return threeArray;
}
void ShowThreeArray(int[,,] array)
{   // обшарил весь инет в поисак лучшего способа вывести трехмерный массив
    // на мой взгляд этот довольно нагляден
    Console.WriteLine($"Размеры массива {array.GetLength(0)} {array.GetLength(1)} {array.GetLength(2)}");
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"Массив №{i} \n");
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]}({i},{j},{k})");
                if(k != array.GetLength(2)-1) Console.Write(",");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }   
}
bool NumberExists(int[,,] array, int number)
{   //Проверка на существование числа в массиве
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            for(int k = 0; k < array.GetLength(2); k++)
                if(array[i,j,k] == number) return true;
    return false;
}
Console.WriteLine();
Console.WriteLine("Task 60");
ShowThreeArray(CreateThreeArray(2,2,2));

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
void SpiralFill(int[,] array)
{

}
Console.WriteLine();
Console.WriteLine("Task 62");
int[,] arrayTask62 = new int[4,4];

Show2dArray(arrayTask62);
Console.WriteLine(arrayTask62.Length);
