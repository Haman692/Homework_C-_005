// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

int AddNumber(string str)
{
    System.Console.WriteLine(str);
    int number = Int32.Parse(Console.ReadLine());
    return number;
}

double[] AddArrWithRandomNumbers(int lenght, int min, int max)
{
    double[] arr = new double[lenght];
    Random rand = new Random();
    for (int i = 0; i < lenght; i++)
    {
        arr[i] = rand.Next(min, max) + Math.Round(rand.NextDouble(), 2);
    }
    return arr;
}

void FindMinMax(double[] arr, out double min, out double max)
{
    min = arr[0];
    max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
            min = arr[i];
        if (arr[i] > max)
            max = arr[i];
    }
}

const int BOTLIMIT = 0;
const int TOPLIMIT = 100;
int arrLenght = AddNumber("Введите размер масива");
if (arrLenght == 1)
    System.Console.WriteLine("В масиве одно значение");
else
{
    double[] arrey = AddArrWithRandomNumbers(arrLenght, BOTLIMIT, TOPLIMIT);
    System.Console.WriteLine('[' + string.Join("; ", arrey) + ']');
    FindMinMax(arrey, out double min, out double max);
    System.Console.WriteLine($"Минимальное значение({min}) меньше максимального ({max}) на {max - min}");
}