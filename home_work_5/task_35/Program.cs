// Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
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
        if(number[i] >= 10 & number[i] <= 99){
            sum ++;
        }
    }
    Console.WriteLine($"Количество элементов = {sum}");
}

int[] massive = GetRandomArray(123, 0, 150);
// Console.WriteLine(string.Join(", ", massive));
CountNumber(massive);
