//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.



Console.Clear();


Console.Write("Введите число: ");
string userImput = Console.ReadLine() ??"";
int num = int.Parse(userImput);
int index = 1;
int degree = 3;

while(index <= num)
{
    Console.WriteLine( Math.Pow(index, degree));
    index++;
    
}
