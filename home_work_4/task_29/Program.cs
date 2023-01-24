// Напишите программу, которая задает массив из 8 элементов и выводит
// их на экран. Данные вводятся с консоли пользователем
void FillArray(int[] collection){
    int length = 8;
    int index = 0;
    while(index < length)
    {
        Console.Write("Введите число: ");
        collection[index] = Convert.ToInt32(Console.ReadLine());
        index++;
    }
}

void PrintArray(int[] cl){
    int count = cl.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(cl[position]);
        position++;
    }
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);
