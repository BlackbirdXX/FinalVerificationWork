using System;
using static System.Console;
Clear();
WriteLine("Программа, которая из имеющегося массива строк формирует массив из строк,\nдлинна которых меньше или равна 3 символа.\nПервоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.");
WriteLine("Введите элементы массива по очереди");
string[] newString = new string[5];
for (int i = 0; i < 5; i++)
{
    newString[i] = ReadLine();
}
WriteLine("\nВведенный массив");
PrintString(newString);
WriteLine("Новый массив, с отсеяными элементами размером больше 3.");
PrintString(DropoutString(newString));

string[] DropoutString(string[] str)
{
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3) count++;
    }
    string[] resultString = new string[count];
    int ctr = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
        {
            resultString[ctr] = str[i];
            ctr++;
        }
    }
    return resultString;
}

void PrintString(string[] str)
{
    for (int i = 0; i < str.Length - 1; i++)
    {
        Write($"{str[i]}, ");
    }
    WriteLine($"{str[str.Length - 1]}\n");
}