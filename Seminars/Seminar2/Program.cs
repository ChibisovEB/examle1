//Задача 64: Задайте значение N. Напишите программу, которая выведет все 
//натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// // Пример применения рекусивного метода
// // Метод выводит все целые числа от m до n
void ShowNums(int m, int n)
{
    if (m > n) ShowNums(m, n+1);
    if (m < n) ShowNums(m, n-1);
    Console.Write(n + " ");
}
 Console.Write("Enter namber: ");
 int N = Convert.ToInt32(Console.ReadLine());
 ShowNums(N,1);

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
//сумму натуральных элементов в промежутке от M до N.
int SumNums(int m, int n)
{
    if (m > n) return n + SumNums(m, n+1);
    if (m < n) return n + SumNums(m, n-1);
    return n;
}
Console.WriteLine();
Console.WriteLine($"The sum of natural elements in between {N} and 1 is equal to {SumNums(N,1)}");

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
int FAckerman(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return FAckerman(m - 1, 1);
    else
      return FAckerman(m - 1, FAckerman(m, n - 1));   
}
Console.WriteLine();
Console.WriteLine($"The Ackerman function for the numbers {N} and {1} is equal to {FAckerman(N,1)}");
