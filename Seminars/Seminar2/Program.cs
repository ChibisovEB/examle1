// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Enter the number of numbers: ");
int col = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < col; i++)
{
    Console.Write($"Enter {i+1} number:");
    if (Convert.ToInt32(Console.ReadLine()) > 0)
        count++;
}
Console.WriteLine($"Count = {count}");

/////////////////////////////////////////////////////////////
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

const int COEFF = 0;
const int CONSTANT= 1;
const int LINE1 = 1;
const int LINE2 = 2;
const int X = 0;
const int Y = 1;

double[] EnterLine(int numberOFLine)
{
    double[] lineData = new double[2];
    Console.Write($"Enter the coefficient for the {numberOFLine} straight: ");
    lineData[COEFF] = Convert.ToDouble(Console.ReadLine());
    Console.Write($"Enter the constant for the {numberOFLine} straight: ");
    lineData[CONSTANT] = Convert.ToDouble(Console.ReadLine());
    return lineData;
}
double[] FindCoordinates(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[X] = (lineData1[CONSTANT] - lineData2[CONSTANT]) 
        / (lineData2[COEFF] - lineData1[COEFF]);
    coord[Y] = lineData1[CONSTANT] * coord[X] + lineData1[CONSTANT];
    return coord;
}
bool CheckLine(double[] lineData1, double[] lineData2)
{
    if (lineData1[COEFF] == lineData2[COEFF])
    {
        if (lineData1[CONSTANT] == lineData2[CONSTANT])
        {
            Console.WriteLine("The lines coincide!");
            return false;
        }
        else
        {
            Console.WriteLine("The lines are parallel!");
            return false;
        }
    }
    return true;
}

double[] lineData1 = EnterLine(LINE1);
double[] lineData2 = EnterLine(LINE2);

if (CheckLine(lineData1, lineData2))
{
    double[] coord = FindCoordinates(lineData1, lineData2);
    Console.Write($"Point of intersection of lines y={lineData1[COEFF]}*x+{lineData1[CONSTANT]} и y={lineData2[COEFF]}*x+{lineData2[CONSTANT]}");
    Console.WriteLine($" has coordinates ({coord[X]}, {coord[Y]})");
}

