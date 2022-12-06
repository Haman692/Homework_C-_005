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

void SumNumber(int[] arr, out int sum1, out int sum2)
{
    sum1 = 0;
    sum2 = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(i % 2 == 1)
            sum1 += arr[i];
        else
            sum2 += arr[i];
    }

}

const int BOTLIMIT = -100;
const int TOPLIMIT = 100;
int arrLenght = AddNumber("Введите размер масива");
int[] arrey = AddArrWithRandomNumbers(arrLenght, BOTLIMIT, TOPLIMIT);
System.Console.WriteLine('[' + string.Join(", ", arrey) + ']');
SumNumber(arrey,out int sum1, out int sum2 );
System.Console.WriteLine($"Сумма элементов стоящих на нечетной позиции = {sum1}, на четной = {sum2}");