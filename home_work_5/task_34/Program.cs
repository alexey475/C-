// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
int[] GetRandomArray(int size, int leftRange, int rightRange){
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return array;
}

void CountNumber(int[] number){
    int sum = 0;
    for(int i = 0; i < number.Length; i++){
        if(number[i] % 2 == 0){
            sum ++;
        }
    }
    Console.WriteLine($"Количество четных чисел = {sum}");
}

int[] massive = GetRandomArray(5, 100, 999);
Console.WriteLine(string.Join(", ", massive));
CountNumber(massive);
