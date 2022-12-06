// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

int AddNumber(string meseg)
{
    System.Console.WriteLine(meseg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] AddArrWithRandomNumbers(int lenght, int min, int max)
{
    int[] arr = new int [lenght];
    Random rand = new Random();
    for (int i = 0; i < lenght; i++)
    {
        arr[i] = rand.Next(min, max);
    }
    return arr;
}

int SumOddNumber(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        sum += arr[i];
    }
    return sum;
}

const int BOTLIMIT = -100;
const int TOPLIMIT = 100;
int arrLenght = AddNumber("Введите размер масива");
int[] arrey = AddArrWithRandomNumbers(arrLenght, BOTLIMIT, TOPLIMIT);
System.Console.WriteLine('[' + string.Join(", ", arrey) + ']');
int sum = SumOddNumber(arrey);
System.Console.WriteLine($"Сумма элементов стоящих на нечетной позиции = {sum}");