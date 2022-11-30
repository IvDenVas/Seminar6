﻿// Напишите программу, которая перевернет одномерный массив (послдений элемент будет на первом месте а первый на последнем и тд)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
Console.Clear();

int[] array = GetArray(10, 0 ,10);
Console.WriteLine(String.Join(" ", array));

int[] reversArray = ReversArray1(array);
Console.WriteLine(String.Join(" ", reversArray));

ReversArray2(array);
Console.WriteLine(String.Join(" ", array));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] ReversArray1(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];
    }
    return result;
}

void ReversArray2(int[] inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length - i - 1];
        inArray[inArray.Length - i - 1] = k;
    }
}