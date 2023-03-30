void input(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
}

int positive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if(array[i] > 0)
        {
            count++;
        }
    return count;
}
Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
input(array);
Console.Write($"Количество чисел больше 0: {positive(array)}");