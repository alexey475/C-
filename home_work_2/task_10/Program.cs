// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа
Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number *= -1;
}
if (number / 1000 != 0)  
{
    Console.WriteLine($"Число {number} больше трехзначного");
}
else if (number / 100 == 0)
{
    Console.WriteLine($"Число {number} меньше трехзначного");
}
else 
    Console.WriteLine($"Вторая цифра = {(number % 100) / 10}");
