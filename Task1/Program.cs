/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int value()
{
    System.Console.Write("Введите длину массива: ");
    string numvalue = Console.ReadLine();
    int value = Convert.ToInt32(numvalue);
    return value;
}

int[] GenerateArray(int len, int min, int max)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write(array1[i] + " ");
    }
}

int check(int[] array1)
{
    int num = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] % 2 == 0)
        {
            num = num + 1;
        }
    }
    return num;
}

int number = value();
int[] numArray = GenerateArray(number, 100, 999);
int quantity = check(numArray);

PrintArray(numArray);
System.Console.WriteLine($"В массиве содержится {quantity} четных числа");