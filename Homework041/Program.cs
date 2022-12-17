/*
Задача 41.
Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int UserLength(string message)
{
    int buf = 0;
    Console.WriteLine(message);
    buf = Convert.ToInt32(Console.ReadLine());
    return buf;
}
int[] GenerateUserArray(int length)
{
    int[] newArray = new int[length];
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.WriteLine($"Введите элемент массива под индексом {i}");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}
void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] +", ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}
int FindPositiveCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
int userLength = UserLength("Введите количество элементов массива ");
int[] userArray = GenerateUserArray(userLength);
int findCount = FindPositiveCount(userArray);
printArray(userArray);
Console.WriteLine($"Количество чисел больше 0 равно {findCount}.");
