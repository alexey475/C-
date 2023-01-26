//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
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
}

void Average(int[,] matrix){
    double[] PrintAvrg = new double[matrix.GetLength(1)];
    for(int i = 0; i < matrix.GetLength(1); i++){
        int sum = 0;
        double avrg = 0;
        int count = 0;
        for(int j = 0; j < matrix.GetLength(0); j++){
            sum += matrix[j, i];
            count ++;
        }
        avrg = Math.Round((double) sum / count, 1);
        PrintAvrg[i] = avrg;
    }
    Console.WriteLine();
    Console.WriteLine(string.Join("; ", PrintAvrg));
}

int[,] array = GetRandomMatrix(3, 4, 0, 10);
PrintMatrix(array);
Average(array);