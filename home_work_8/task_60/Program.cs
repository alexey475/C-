// Сформируйте трехмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int x = 2;
int y = 2;
int z = 2;
int LEFT_RANGE = 10;
int RIGHT_RANGE = 100;

int[,,] matrix3D = new int[x, y, z];

void CreateMatrix(int[,,] matrix3D){
    int[] temp = new int[matrix3D.GetLength(0) * matrix3D.GetLength(1) * matrix3D.GetLength(2)];
    for (int i = 0; i < temp.Length; i++){
        temp[i] = new Random().Next(LEFT_RANGE, RIGHT_RANGE);
        for(int j = 0; j < temp.Length; j++){
            if(temp[i] == temp[j]){
                temp[i] = new Random().Next(LEFT_RANGE, RIGHT_RANGE);
            }
        }
    }
    int count = 0;
    for(int x = 0; x < matrix3D.GetLength(0); x++){
        for(int y = 0; y < matrix3D.GetLength(1); y++){
            for(int z = 0; z < matrix3D.GetLength(2); z++){
                matrix3D[x, y, z] = temp[count];
                count++;
            }
        }
    }
}

void PrintMatrix(int[,,] matrix3D){
    for(int i = 0; i < matrix3D.GetLength(0); i++){
        for(int j = 0; j < matrix3D.GetLength(1); j++){
            for (int k = 0; k < matrix3D.GetLength(2); k++){
                Console.Write($"{matrix3D[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

CreateMatrix(matrix3D);
PrintMatrix(matrix3D);