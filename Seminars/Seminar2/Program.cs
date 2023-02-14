// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
int GetTwoDigit(int number)
{
    return (number / 10) % 10;
}

// 
Console.Write("Enter a three digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number<100 || number>999)
{
    Console.WriteLine("Тут бы сделать цикл while заставляющий пользователя вводить число пока он не введет трехзначное");
    Console.WriteLine("но ночь уже, а потом переделывать неохото будет");
    goto Exit;
}
Console.WriteLine($"The second digit of the number {number} is {GetTwoDigit(number)}");

Exit:;