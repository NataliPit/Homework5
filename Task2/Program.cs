/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
 */

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

int SumArray(int[] array1)
{
    int sum = 0;
    for (int i = 0; i < array1.Length; i += 2)
    {
        sum = sum + array1[i];
    }
    return sum;
}


int quantity = value();
int[] array = GenerateArray(quantity, 0, 30);

PrintArray(array);
int sum = SumArray(array);
System.Console.WriteLine($"Сумма элементов массива = {sum}.");