/*
Задача 19
Напишите программу, которая принимает на вход пятизначное 
число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.WriteLine("enter a 5-digit number");
int number = Convert.ToInt32(Console.ReadLine());

int GetNumberBackwards(int number)
{
    int rev = 0;
    while (number != 0)
    {
        int lastDigit = number % 10;
        rev = rev * 10 + lastDigit;
        number = number / 10;
    }
    return (rev); 
}


if (number == GetNumberBackwards(number)) Console.WriteLine("yes");
else Console.WriteLine("no");