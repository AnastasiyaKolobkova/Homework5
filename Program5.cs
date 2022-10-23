// Домашняя работа 5.
// Задача 1.
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateRandomArray(int size) 
{
  int[] array = new int[size];
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 999);
  return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i]+ " ");
    Console.WriteLine();
}

int NumberOfEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++ )
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
  return count;
}

Console.Write("Input number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size);
ShowArray(myArray);
Console.WriteLine();
int count = NumberOfEvenNumbers(myArray);
Console.WriteLine($"The number of even numbers in the array: {count}");

// Задача 2.
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i]+ " ");
    Console.WriteLine();
}

int SumOfOddPosition(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

Console.Write("Input number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size);
ShowArray(myArray);
Console.WriteLine();
int sum = SumOfOddPosition(myArray);
Console.WriteLine($"The sum of the elements standing in odd positions: {sum}");

// Задача 3.
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i]+ " ");
    Console.WriteLine();
}

double ArrayRealNumbers(int[] array)
{
  double difference = 0;
  double maxNum = array[0];
  double minNum = array[0];
  for (int i = 1; i < array.Length; i++)
  {
    if (maxNum < array[i])
    {
      maxNum = array[i];
    }
    if (minNum > array[i])
    {
      minNum = array[i];
    }
  difference = maxNum - minNum;
  }
  return difference;
}

Console.Write("Input number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size);
ShowArray(myArray);
Console.WriteLine();
double difference = ArrayRealNumbers(myArray);
Console.WriteLine($"The difference between the maximum and minimum array elements: {difference}");