// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N
int m = 1;
int n = 15;

int SumNumber(int m, int n){
    if (m == n) return n;
    return n + SumNumber(m, n - 1);
}

Console.WriteLine($"Сумма элементов от {m} до {n} = {SumNumber(m, n)}");
