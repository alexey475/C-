// Напишите программу, которая выводит третью цифру заданного числа  
// или сообщает,что третьей цифры нет
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
double n = 0.001;
int flag = 0;
if (number < 0)
{
    number *= -1;
}
if ((int)(number * 0.1) == 0 || (int)(number * 0.01) == 0)
{
    Console.WriteLine("третьей цифры нет");
    flag = 1;
}
while (flag == 0)
    if ((int)(number * n) != 0)
    {
        n *= 0.1;
    }
    else
        {
        Console.WriteLine($"Третья цифра = {(int)(number * n * 1000) % 10}");
        flag = 1;
        }
