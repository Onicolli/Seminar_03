// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);
int first_number = 0;
int num_reverse = num;
int temp = 0;
int temp_1 = 0;
int similarities = 0;

if (num < 99999 && num > 10000) {
    first_number = num / 1000;
    //// Console.WriteLine(first_number);
 
    num_reverse = num_reverse % 100;
    //// Console.WriteLine(num_reverse);

    temp = num_reverse % 10;
    temp_1 = num_reverse / 10;
    similarities = temp * 10 + temp_1;
    //// Console.WriteLine(similarities);

    if (first_number == similarities) {
        Console.WriteLine("Число является палиндромом! ");
    }
    else {
        Console.WriteLine("Число не является палиндромом! ");
    }
} 
else {
    Console.WriteLine("В числе не 5 чисел!");
}






