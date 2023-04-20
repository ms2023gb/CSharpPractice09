/*
    Задача 68: Напишите программу вычисления функции Аккермана
     с помощью рекурсии. Даны два неотрицательных числа m и n.

    m = 2, n = 3 -> A(m,n) = 9
    m = 3, n = 2 -> A(m,n) = 29
*/

Console.Clear();
System.Console.WriteLine("Введите параметры функции Аккермана A(m,n)");
int numberM = ReadIntNumber("Введите от 0 до 3, m: ");
int numberN = ReadIntNumber("Введите от 0 до 11, n: ");

if (Validation(numberM, numberN) == true)
{
    Console.WriteLine($"A({numberM},{numberN}) = {Ackermann(numberM, numberN)}");
}
else
{
    Console.WriteLine("Введите другие числа");
}


int Ackermann(int nAck, int mAck)
{
    if (nAck == 0) return mAck + 1;
    else if (mAck == 0) return Ackermann(nAck - 1, 1);
    else return Ackermann(nAck - 1, Ackermann(nAck, mAck - 1));
}

bool Validation(int num1, int num2)
{
    if (num1 >= 0 && num1 < 4 && num2 >= 0 && num2 < 12) return true;
    else return false;
}

int ReadIntNumber(string msg)
{
    if (msg != "") Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}