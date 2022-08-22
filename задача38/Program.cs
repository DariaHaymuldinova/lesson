// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int[] generateArray(int Length = 10, int min = 0, int max = 1000)
{
    int[] result = new int[Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(min, max);
    }
    return result;
}
int[] array = generateArray();
Console.WriteLine(string.Join(", ", array));

void MaxMin (int[] array)
{
int Max = array[0];
int Min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > Max)
    {
        Max = array[i];
    }
    if (array[i] < Min)
    {
        Min = array[i];
    }
}
int result = Max - Min;
Console.WriteLine("Разница между максимальным и минимальным значениями: " + result);
}
MaxMin(array);

