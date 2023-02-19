

// //Задача 19
// //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
 
// // На самом деле этот метод проверяет не только число, но ведь число тоже проверяет :-)
// bool isPalindrom (string n)
// {
// int nLen = n.Length;
// int count = 0;
 
// while (count < nLen / 2)
// {
// if (n[count] != n[nLen - count - 1])
// return false;
// count++;
// }
// return true;
// }
 
// Console.Write ("Enter a five-digit number:");
 
// if (isPalindrom (Console.ReadLine ()))
// Console.WriteLine ("Yes");
// else
// Console.WriteLine ("No");
 
// //Задача 21
// //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
 
// double distance3D (double xa, double ya, double za, double xb, double yb, double zb)
// {
// return Math.Sqrt(Math.Pow(xb-xa,2) + Math.Pow(yb-ya,2) + Math.Pow(zb-za,2));
// }
 
// // запрашиваем координаты первой точки
// Console.WriteLine ("Enter the three coordinates of the first point (X,Y,Z):");
// double xa = Convert.ToDouble(Console.ReadLine());
// double ya = Convert.ToDouble(Console.ReadLine());
// double za = Convert.ToDouble(Console.ReadLine());
// // запрашиваем координаты второй точки
// Console.WriteLine ("Enter the three coordinates of the first point (X,Y,Z):");
// double xb = Convert.ToDouble(Console.ReadLine());
// double yb = Convert.ToDouble(Console.ReadLine());
// double zb = Convert.ToDouble(Console.ReadLine()); 
// Console.WriteLine($"Entered coordinates of the first and two points: ({xa}, {ya}, {za}) ({xb}, {yb}, {zb})");
// Console.WriteLine($"The distance between these points: {Math.Round(distance3D(xa,ya,za,xb,yb,zb),2)}");
 
// // Задача 23
// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// Console.WriteLine ("Enter a number: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// string comma = ", ";
// while (count <= x)
// {
// if (count == x) comma = "";
// Console.Write(Math.Pow(count,3) + comma);
// count++;
// }
// Console.WriteLine();
