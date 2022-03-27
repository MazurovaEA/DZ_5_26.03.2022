// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] RandArray(int lenght)
{
    int[] answer = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        answer[i] = new Random().Next(100, 1000);
    }
    return answer;
}
void PrintArray(int[] collect)
{
    Console.Write("[");
    for (int i = 0; i < collect.Length - 1; i++)
    {
        Console.Write(collect[i] + ", ");

    }
    Console.Write(collect[collect.Length - 1] + "]");
}
int CountEven(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}
int Promt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

int N = Promt("Введите необходимую длину массива => ");
if (N == 0) Console.WriteLine("Массив не может быть длиной 0");
else
{
    int[] arr = RandArray(N);
    PrintArray(arr);
    int count = CountEven(arr);
    Console.WriteLine();
    Console.WriteLine($"Количество четных чисел в массиве - {count}");
}