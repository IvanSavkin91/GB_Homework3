/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

Console.WriteLine("Введите 5-ти значное число ");
string number = Console.ReadLine()!;
void Task19(string number )
{
    
    if (number [0] == number [4] && number [1] == number [3])
    {
    Console.WriteLine("Число является полиндромом");
    }
    else
Console.WriteLine("Число не является полиндромом");
 
}
Task19(number);
