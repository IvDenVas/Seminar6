// напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int num = userInput("Введите число: ");
Console.WriteLine(convertToDoub(num));


static int convertToDoub(int num)
{
    int i = 0;
    int resault = 0;
    while (num > 0)
    {
        resault += num % 2 * (int)Math.Pow(10, i);
        num /= 2;
        i++;
    }
    return resault;
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