int length = Promt("Длина массива: ");
int[] array = GenereteArray(length);
PrintArray(array);
System.Console.WriteLine(Max(array) - Min(array));


int Promt (string message)
{
    System.Console.WriteLine(message);
    string readInput = System.Console.ReadLine();
    int result =int.Parse(readInput);
    return result;
}

int[] GenereteArray(int length)
    {
        int[] result = new int[length];
        for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(1, 100);
    }
    return result;
}

void PrintArray(int[] array)
{
    foreach (int i in array) 
    {
        System.Console.Write($"{i} ");
    }
    System.Console.WriteLine();
} 

int Max(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
        max = array[i];
        }
    }
    return max;
}

int Min(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
        min = array[i];
        }
    }
    return min;
}
