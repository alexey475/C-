// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange){
    double[,] matrix = new double[rows, columns];
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            matrix[i, j] = Convert.ToDouble(new Random().Next(leftRange, rightRange + 1)) / 10;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int ROWS = 3;
int COLUMNS = 4;
int LEFT_RANGE = -10;
int RIGHT_RANGE = 10;

double[,] array = GetRandomMatrix(ROWS, COLUMNS, LEFT_RANGE, RIGHT_RANGE);
PrintMatrix(array);