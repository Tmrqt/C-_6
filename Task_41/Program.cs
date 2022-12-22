int [] Numbers()
{
    Console.Write("Введите числа через пробел: ");
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    return arr;
}

int Counter(int[] arr)
{
    int count = 0; 
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    System.Console.WriteLine(($"Количествво чисел > 0: {count}"));
    return count;
}

int[] arr = Numbers();
int plus = Counter(arr);