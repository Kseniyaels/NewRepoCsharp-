/* Массив из 123 случайных чисел, 
показывает количество элементов массива, значения которых лежат 
в отрезке с 10 до 99*/

int Count(int[] array, int min, int max)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] >= min) && (array[i] <= max))
            result++;
    }
    return result;
}

int[] a = {10, 11, 12, 13, 14};
Console.WriteLine(String.Join(" ", a));

Console.WriteLine(Count(a, 10, 99));
