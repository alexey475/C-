// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1
int n = 5;
int m = 1;

void Number(int n, int m){
    if (n + 1 == m) return;
    Number(n, m + 1);
    Console.Write(m + " ");
}

Number(n, m);