// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] CreateArray(int Len)
// {
//     int[] myArray = new int[Len];
//     for (int i = 0; i <= myArray.Length - 1; i++)
//     {
//         myArray[i] = new Random().Next(100, 1000);
//     }
//     return myArray;
// }

// int SumEvenElements(int[] myAr)
// {
//     int sum = 0;
//     for (int i = 0; i <= myAr.Length - 1; i++)
//     {
//         if (myAr[i]%2 == 0) sum++;
//     }
//     return sum;
// }

// int[] array = CreateArray(67);
// Console.WriteLine(SumEvenElements(array));

// // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// // Найдите сумму элементов, стоящих на нечётных позициях.
//  int[] CreateArray(int Len)
// {
//     int[] myArray = new int[Len];
//     for (int i = 0; i <= myArray.Length - 1; i++)
//     {
//         myArray[i] = new Random().Next(1, 100);
//     }
//     return myArray;
// }

// int SumEvenElements(int[] myAr)
// {
//     int sum = 0;
//     for (int i = 0; i <= myAr.Length - 1; i++)
//         if (i%2 != 0) sum += myAr[i];
//     return sum;
// }
// int[] array = CreateArray(10);
// Console.WriteLine(SumEvenElements(array));


// // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// // и минимальным элементов массива.
// int[] CreateArray(int Len)
// {
//     int[] myArray = new int[Len];
//     for (int i = 0; i <= myArray.Length - 1; i++)
//     {
//         myArray[i] = new Random().Next(-10, 10);
//     }
//     return myArray;
// }

// void printArray(int[] myAr)
// {
//     for (int i = 0; i <= myAr.Length - 1; i++)
//         Console.Write(myAr[i] + " ");
//     Console.WriteLine();
// }

// int[] array = CreateArray(10);
// int minElement = array.Min();
// int maxElement = array.Max();
// printArray(array);
// Console.WriteLine($"min = {minElement}");
// Console.WriteLine($"max = {maxElement}");
// Console.WriteLine($"difference = {maxElement - minElement}");
