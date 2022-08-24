// Программа задает массив случайных положительных трехзначных чисел, показывает количество четных чисел в массиве
int[] generateArray(int Length = 10, int min = 100, int max = 999)
{
    int[] result = new int[Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(min, max+1);
    }
    return result;
}
int[] array = generateArray();
Console.WriteLine(string.Join(", ", array));

void Odd (int[] array)
{
int result = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        result++;
    }
}
Console.WriteLine("Количество четных чисел в массиве: " + result);
}
Odd(array);
