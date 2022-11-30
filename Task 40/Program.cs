// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с стороноами такой длины.

int num1 = userInput("Введите первое число: ");
int num2 = userInput("Введите второе число: ");
int num3 = userInput("Введите третье число: ");

if (Triangle(num1, num2, num3))
    Console.WriteLine("Yes");
else Console.WriteLine("No");

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

static bool Triangle(int num1, int num2, int num3)
{
    if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2) return true; // return (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2)
    else return false;                                                               //
}