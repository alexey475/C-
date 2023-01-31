// Задайте двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange){
    int[,] matrix = new int[rows, columns];
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            matrix[i, j] = new Random().Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MinSumLine(int[,] matrix){
    int[] SumLine = new int[matrix.GetLength(0)];
    int minPosition = 0;
    for(int i = 0; i < matrix.GetLength(0); i++){
        int sum = 0;
        for(int j = 0; j < matrix.GetLength(1); j++){
            sum += matrix[i, j];
        }
        SumLine[i] = sum;
    }
    for(int i = 0; i < SumLine.Length; i++){
        if(SumLine[i] < SumLine[minPosition]){
            minPosition = i;
        }
        int temporary = SumLine[i];
        SumLine[i] = SumLine[minPosition];
        SumLine[minPosition] = temporary;
    }
    Console.WriteLine($"{minPosition + 1} строка");
}

int ROWS = 3;
int COLUMNS = 4;
int LEFT_RANGE = 0;
int RIGHT_RANGE = 10;

int[,] array = GetRandomMatrix(ROWS, COLUMNS, LEFT_RANGE, RIGHT_RANGE);
PrintMatrix(array);
MinSumLine(array);
