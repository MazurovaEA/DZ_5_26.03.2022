// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.

int Promt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}
double[] RandArray(int lenght)
{
    double[] answer = new double[lenght];
    for (int i = 0; i < lenght; i++)
    {
        Random rnd = new Random();                      // вариант без отрицательных: answer[i] = new Random().NextDouble()*100; (*100 - дает возможность генерировать значение от 0 до 100)
        answer[i] = -100 + rnd.NextDouble() * 201;      // диапазон от -100 до 100
    }                                                           
    return answer;
}

void PrintArray(double[] collect)
{
    Console.Write("[");
    for (int i = 0; i < collect.Length - 1; i++)
    {
        Console.Write($"{collect[i]:0.00}, ");

    }
    Console.Write($"{collect[collect.Length - 1]:0.00}]");
}
double FindMax(double[] arr)
{
    double maxElem = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (maxElem < arr[i]) maxElem = arr[i];
    }
    return maxElem;
}
double FindMin(double[] arr)
{
    double minElem = arr[0];
    for (int j = 1; j < arr.Length; j++)
    {
        if (minElem > arr[j]) minElem = arr[j];
    }
    return minElem;
}

int N = Promt("Введите необходимую длину массива => ");
if (N == 0) Console.WriteLine("Массив не может быть длиной 0");
else
{
    double[] arr = RandArray(N);
    PrintArray(arr);
    Console.WriteLine();
    double max = FindMax(arr);
    double min = FindMin(arr);
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {max - min}");
}