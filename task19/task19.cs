//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
string num = Console.ReadLine();

if (num.Length >5 || num.Length <5 )
{
    Console.WriteLine("Вы ввели не пятизначное число ");
}
else if (num[0] == num[4] && num[1] == num[3])
{
    Console.WriteLine($"{num} - Полиндром");
}
else 
{
    Console.WriteLine($"{num} - Не полиндром");
}
