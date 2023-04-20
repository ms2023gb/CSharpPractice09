/*
	Задача 64: Задайте значение N. 
	Напишите программу, которая выведет все 
	натуральные числа в промежутке от N до 1. 
	Выполнить с помощью рекурсии.

	N = 5 -> "5, 4, 3, 2, 1"
	N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.Clear();

int number = ReadIntNumber("Введите натуральное число: ");
if (ValidationNatureNumbers(number) == false) Console.WriteLine("Ошибка ввода");
else NatureNumbersRec(number);

void NatureNumbersRec(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NatureNumbersRec(num - 1);
}

int ReadIntNumber(string msg)
{
    if (msg != "") Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}

bool ValidationNatureNumbers(int num)
{
    if (num < 1) return false;
    return true;
}