// Программа задает массив случайных чисел, находит сумму элементов стоящих на нечетных позициях
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

void Sum (int[] array)
{
int Sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 > 0)
    {
        Sum = Sum + array[i];
    }
}
Console.WriteLine("Сумма нечетных индексов: " + Sum);
}
Sum(array);