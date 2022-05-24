// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


void EvenNumbers(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.Write("Четные числа: ");
     for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            Console.Write(arr[i] + " ");
    }
}


int[] array = new int[4];
    Random randomaiser = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = randomaiser.Next(100,1000);
}

EvenNumbers(array);