// Напишите программу, которая принимает на вход число N
// и выдает таблицу кубов чисел от 1 до N
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    Console.WriteLine("Число должно быть больше нуля");
}
for (int i = 1; i <= number; i ++)
{
    Console.WriteLine(Math.Pow(i, 3));
}