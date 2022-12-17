// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел
Console.WriteLine("Введите 1 число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
    if (number1 > number3)
    {
        Console.WriteLine($"max = {number1}");
    }
    else 
    {
        Console.WriteLine($"max = {number3}");
    }
else if (number2 > number3)
{
    Console.WriteLine($"max = {number2}");
}   
else 
{
     Console.WriteLine($"max = {number3}");
}