// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int num = userInput("Введите размер массива: ");
int[] array = GetArray(num, 0, 100);
Console.WriteLine("[" + String.Join(", ", array) + "]");
int[] array1 = ReversArray1(array);
//Console.WriteLine("[" + String.Join(", ", array) + "]");
Console.WriteLine("[" + String.Join(", ", array1) + "]");

int[] ReversArray1(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];
    }
    return result;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

static int userInput (string message)
{
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int num))
            if (num > 0) return num;
        Console.WriteLine("Ошибка ввода!");
    }
}