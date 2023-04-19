// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Clear();

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("Введенное число является палиндромом");
    }
    else
    {
        Console.WriteLine("Введенное число не является палиндромом");
    }
}
else
{
    Console.WriteLine("Введенное число не является пятизначным");
}


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Clear();

int x1 = ReadInt("Введите координату X для первой точки: ");
int y1 = ReadInt("Введите координату Y для первой точки: ");
int z1 = ReadInt("Введите координату Z для первой точки: ");
int x2 = ReadInt("Введите координату X для второй точки: ");
int y2 = ReadInt("Введите координату Y для второй точки: ");
int z2 = ReadInt("Введите координату Z для второй точки: ");

int diffX = x2 - x1;
int diffY = y2 - y1;
int diffZ = z1 - z2;

double length = Math.Sqrt(diffX * diffX + diffY * diffY + diffZ * diffZ);
Console.WriteLine($"Расстояние между точками = {length}");


// Функция ввода сообщения
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}