/*
Задача 43.
Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

int GetNumberFromUser(string message)
{
    int result = 0;
    Console.WriteLine(message);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}
void FindIntersectionPoint(double number1, double number2, double number3, double number4)
{
    double x = 0;
    double y = 0;
    if (number2 != number4)
    {
        y = Convert.ToDouble((number1 * number4 - number3 * number2) / (number4 - number2));
        x = Convert.ToDouble((y - number1) / number2);
        Console.WriteLine($"Наши прямые пересекаются в точке ({x}; {y})");
    }
    else
    {
        Console.WriteLine("Наши прямые являются параллельными");
    }
}
int b1 = GetNumberFromUser("Введите b1 ");
int k1 = GetNumberFromUser("Введите k1 ");
int b2 = GetNumberFromUser("Введите b2 ");
int k2 = GetNumberFromUser("Введите k2 ");
Console.WriteLine($"Первая прямая задана уравнением y = {k1}*x + {b1}");
Console.WriteLine($"Вторая прямая задана уравнением y = {k2}*x + {b2}");
FindIntersectionPoint(b1, k1, b2, k2);
