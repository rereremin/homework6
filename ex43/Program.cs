// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double k1 = EnterValue("Введите k1: ");
double k2 = EnterValue("Введите k2: ");
double b1 = EnterValue("Введите b1: ");
double b2 = EnterValue("Введите b2: ");

double x = GetX(k1, k2, b1, b2);
double y = GetY(k1, b1, x);

System.Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}, {y})");

///
double GetY(double k1, double b1, double x)
{
    return k1 * x + b1;
}

double GetX(double k1, double k2, double b1, double b2)
{
    return (b2 - b1) / (k1 - k2);
}

double EnterValue(string msg)
{
    while (true)
    {
        System.Console.WriteLine(msg);
        if(double.TryParse(Console.ReadLine(), out double num))
            if(num > 0)
                return num;
        System.Console.WriteLine("Error!");  
    }
}