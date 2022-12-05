// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int[] array = FillArray(10, -10, 10);
System.Console.WriteLine(String.Join(", ", array));
System.Console.WriteLine($"-> {CountNatNum(array)}");
///
int CountNatNum(int[] FuncArr)
{
    int result = 0;
    foreach (int item in FuncArr)
        if(item > 0) result++;
    return result;
}

int[] FillArray(int size, int MinValue, int MaxValue)
{
    System.Console.WriteLine("Введите числа: ");
    int[] FuncArr = new int[size];
    for (int i = 0; i < size; i++)
        FuncArr[i] = int.Parse(Console.ReadLine()??"");
    return FuncArr;
}