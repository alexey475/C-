// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Sum(int number){
    int count = Convert.ToString(number).Length;
    int result = 0;
    for(int i = 0; i < count; i++){
        result = result + (number % 10);
        number = number / 10;
    }
    return result;
}

int s = Sum(number);
Console.WriteLine(s);
