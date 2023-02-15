// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
   int GetTwoDigit(int number)
   {
       return (number / 10) % 10;
   }
        
   string message = "Enter a three digit number: ";
   int number = 0;
   while (number<100 || number>999)
        {
            Console.Write(message);    
            number = Convert.ToInt32(Console.ReadLine());
            message = "I insist, enter a three-digit number:";
        }

   Console.WriteLine($"The second digit of the number {number} is {GetTwoDigit(number)}");
