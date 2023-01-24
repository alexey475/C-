// Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
int[] GetRandomArray(int size, int leftRange, int rightRange){
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return array;
}

void CountNumber(int[] number){
        int maxPosition = number[0];
        int minPosition = number[0];
        for(int i = 0; i < number.Length; i++){
            if(number[i] < minPosition){
                minPosition = number[i];
            }
            if(number[i] > maxPosition){
                maxPosition = number[i];
            }
        }
        Console.WriteLine($"Максимальный элемент = {maxPosition}, минимальный элемент = {minPosition}");
        Console.WriteLine($"Разница = {maxPosition - minPosition}");    
}

int[] massive = GetRandomArray(4, 0, 150);
Console.WriteLine(string.Join(", ", massive));
CountNumber(massive);