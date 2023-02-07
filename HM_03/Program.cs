// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine("Введите пятизначное (N): ");
int N = int.Parse(Console.ReadLine()!);
int cube = 0;
int count = 0;
while (N > count) {
    count++;
    cube++;
    int sum = Convert.ToInt32(Math.Pow(cube, 3));
    Console.Write($"{sum}, ");
}