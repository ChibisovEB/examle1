// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
//   int GetTwoDigit(int number)
//   {
//       return (number / 10) % 10;
//   }
//        
//   string message = "Enter a three digit number: ";
//   int number = 0;
//   while (number<100 || number>999)
//        {
//            Console.Write(message);    
//            number = Convert.ToInt32(Console.ReadLine());
//            message = "I insist, enter a three-digit number:";
//        }
//   Console.WriteLine($"The second digit of the number {number} is {GetTwoDigit(number)}");

//////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
//        int GetThirdDigit(int num)
//        {
//            // Метод возвращает третью цифру из числа  num
//            // Если число состоит из 2 и менее цифр возвращается -1
//            // Сдесь никак не обрабатываются отрицательные числа и строки по скольку в условии задачи не было об этом сказано,
//            // Вообще о таких вещах надо задавать вопросы заказчику до начала всех работ.
//            if (num<100) return -1;
//            while (num>999) num = num / 10;
//            return (num % 10);
//        }
//        
//        Console.Write("Enter a number:");    
//        int number = Convert.ToInt32(Console.ReadLine());
//        int thirdNumber = GetThirdDigit(number);
//
//        if (thirdNumber == -1)
//            Console.WriteLine("There is no third digit in your number");
//        else
//            Console.WriteLine($"The third digit of the number {number} is {thirdNumber}");
