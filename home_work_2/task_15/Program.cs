// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным
Console.WriteLine("Введите цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number > 7)
{
    Console.WriteLine("Такого дня недели не существует");
}
else if (number == 6 || number == 7)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
