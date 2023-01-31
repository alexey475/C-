// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int ROWS = 2;
int COLUMNS = 2;
int LEFT_RANGE = 1;
int RIGHT_RANGE = 10;

int[,] matrix1 = new int[ROWS, COLUMNS];
int[,] matrix2 = new int[ROWS, COLUMNS];
int[,] matrix = new int[ROWS, COLUMNS];

void CreateMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(LEFT_RANGE, RIGHT_RANGE);
    }
  }
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

void GenerationMatrix(int[,] matrix1, int[,] matrix2){
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            matrix[i, j] = matrix1[i, j] * matrix2[i, j];
        }
    }
}

CreateMatrix(matrix1);
Console.WriteLine("Первая матрица:");
PrintMatrix(matrix1);
CreateMatrix(matrix2);
Console.WriteLine("Вторая матрица:");
PrintMatrix(matrix2);
GenerationMatrix(matrix1, matrix2);
Console.WriteLine("Произведение двух матриц:");
PrintMatrix(matrix);