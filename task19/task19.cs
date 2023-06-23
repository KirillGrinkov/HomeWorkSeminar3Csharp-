//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

 Console.Clear();
 
Console.Write("Введите пятизначное число: ");
string userImput = Console.ReadLine() ??"";
int number = int.Parse(userImput);


if ((number % 10 == number / 10000) && ((number / 1000) % 10 == (number / 10) % 10))
    {
        Console.WriteLine($"{number}  полиндром");  
    }
 else
 Console.WriteLine($"{number} не полиндром");