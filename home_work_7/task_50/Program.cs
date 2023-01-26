// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
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

void Coordinates(int[,] matrix){
    string? Answer = string.Empty;
    int Rows;
    int Columns;
    while (true){
        Console.WriteLine("Проверить позиции элемента в массиве (да/нет)?");
        Answer =  Console.ReadLine();
        if (Answer != "да" && Answer != "нет"){
            continue;
        }
        if (Answer == "нет"){
            break;
        }
        Console.Write("Введите номер строки: ");
        Rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите номер столбца: ");
        Columns = Convert.ToInt32(Console.ReadLine());

        if (Rows > matrix.GetLength(0) || Rows < 1 || Columns > matrix.GetLength(1) || Columns < 1){
            Console.WriteLine("Такой позиции в массиве нет");
            Console.WriteLine();
        }
        else {
            Console.WriteLine(matrix[Rows -1, Columns - 1]);
            Console.WriteLine();
        }
    }
}

int[,] array = GetRandomMatrix(3, 4, 0, 100);
PrintMatrix(array);
Coordinates(array);