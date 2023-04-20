/*
	Задача 66: Задайте значения M и N. Напишите программу, 
	которая найдёт сумму натуральных элементов в промежутке от M до N. 
	Выполнить с помощью рекурсии.

	M = 1; N = 15 -> 120
	M = 4; N = 8. -> 30
*/


Console.Clear();


int numberOne = ReadIntNumber("Введите 1-e натуральное число: ");
if (ValidationNatureNumbers(numberOne) == false) Console.WriteLine("Ошибка ввода");
else
{
    int numberTwo = ReadIntNumber("Введите 2-e натуральное число: ");
    if (ValidationNatureNumbers(numberTwo) == false) Console.WriteLine("Ошибка ввода");

    NatureNumbersRangeRec(numberOne, numberTwo);
    Console.WriteLine();

    if (numberOne > numberTwo)
    {
        int temp = numberOne;
        numberOne = numberTwo;
        numberTwo = temp;
    }
    Console.WriteLine($"Сумма чисел равна: {SumOfNumberInRangeRec(numberOne, numberTwo)}");
}

int SumOfNumberInRangeRec(int numOne, int numTwo)
{
    if (numOne == numTwo + 1) return 0;
    else return numOne + SumOfNumberInRangeRec(numOne + 1, numTwo);
}

void NatureNumbersRangeRec(int numOne, int numTwo)
{
    if (numOne < numTwo)
    {
        NatureNumbersRangeRec(numOne, numTwo - 1);
        Console.Write($"{numTwo} ");
    }
    else if (numOne > numTwo)
    {
        Console.Write($"{numOne} ");
        NatureNumbersRangeRec(numOne - 1, numTwo);
    }
    else
    {
        Console.Write($"{numOne} ");
    }
}

bool ValidationNatureNumbers(int num)
{
    if (num < 1) return false;
    return true;
}

int ReadIntNumber(string msg)
{
    if (msg != "") Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}