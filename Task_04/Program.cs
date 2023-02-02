// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Clear();
Console.Write("Введите число: ");
int Num = int.Parse(Console.ReadLine()!);
int counter = 1;
while (counter < Num) {
    Console.Write(counter * counter + ", ");
    counter++;
}
Console.Write(counter * counter + ". ");

