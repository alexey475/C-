// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
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
        if(i % 2 != 0){
            sum += number[i];
        }
    }
    Console.WriteLine($"Сумма на нечётных позициях = {sum}");
}

int[] massive = GetRandomArray(4, 0, 150);
Console.WriteLine(string.Join(", ", massive));
CountNumber(massive);
