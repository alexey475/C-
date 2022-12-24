// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string str_number = Convert.ToString(number);
if (str_number.Length < 5 || str_number.Length > 5)
{
    Console.WriteLine("Введено неправильное число");
    return;
}
if ((int)(number * 0.0001) != (int)(number % 10))
{
    Console.WriteLine("Нет");
}
else if ((int)(number * 0.001) % 10 != (int)(number % 100) / 10)
{
    Console.WriteLine("Нет");
}
else
{
    Console.WriteLine("Да");
}
