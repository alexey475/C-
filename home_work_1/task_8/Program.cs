// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int first_number = 2;
while (first_number != number + 1)
    if (first_number % 2 == 0)
        {
            Console.WriteLine(first_number);
            first_number ++;
        }
    else first_number ++;