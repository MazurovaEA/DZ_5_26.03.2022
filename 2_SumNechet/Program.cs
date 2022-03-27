// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
int Promt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}
int[] RandArray(int lenght)
{
    int[] answer = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        answer[i] = new Random().Next(-10, 11);    //Для совсем рандомных значений: answer[i] = new Random().Next(); 
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
int SumElementOdd(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i = i + 2)
    {
        sum += arr[i];
    }
    return sum;
}

int N = Promt("Введите необходимую длину массива => ");
if (N == 0) Console.WriteLine("Массив не может быть длиной 0");
else
{
    int[] arr = RandArray(N);
    PrintArray(arr);
    int sum = SumElementOdd(arr);
    Console.WriteLine();
    Console.WriteLine($"Сумма всех нечетных элементов в массиве: {sum}");
}