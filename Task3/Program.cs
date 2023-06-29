/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */

double[] GenerateArray()
{
    double[] array = new double[6];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100) + rnd.NextDouble();
    }
    return array;
}

void PrintArray(double[] array1)
{
    Console.Write($"Дан массив: ");
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"{array1[i]:f2}");
    }
}

double Max(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i += 2)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

double Min(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i += 2)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}
double[] array = GenerateArray();

PrintArray(array);
double min = Min(array);
double max = Max(array);

System.Console.WriteLine($"\nMax число: {max:f2}. \nMin число: {min:f2}. \nРазница между {max:f2} и {min:f2} = {max-min:f2}.");