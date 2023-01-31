// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

void Sort(int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            int maxPosition = j;
            for(int k = j + 1; k < matrix.GetLength(1); k++){
                if(matrix[i, k] > matrix[i, maxPosition]){
                    maxPosition = k;
                }
            }
            int temporary = matrix[i, j];
            matrix[i, j] = matrix[i, maxPosition];
            matrix[i, maxPosition] = temporary;
        }
    }
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int ROWS = 3;
int COLUMNS = 4;
int LEFT_RANGE = 0;
int RIGHT_RANGE = 10;

int[,] array = GetRandomMatrix(ROWS, COLUMNS, LEFT_RANGE, RIGHT_RANGE);
PrintMatrix(array);
Sort(array);