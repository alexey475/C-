// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop" и производится при помощи нажатия Enter
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4
string InputNumber = string.Empty;
int number;
int count = 0;

while (true){
    Console.Write("Введите число или stop: ");
    InputNumber = Console.ReadLine();
    if (InputNumber == "stop"){
        break;
    }
    number = Convert.ToInt32(InputNumber);
    if (number > 0)
        count++;
}

Console.Write(count);