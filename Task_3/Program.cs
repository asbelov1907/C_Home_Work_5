// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Hello, World!");

void MaxMinNumber(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }

    double MaxNumber = arr[0];
    double MinNumber = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > MaxNumber)
            MaxNumber = arr[i];
        if (arr[i] < MaxNumber)
            MinNumber = arr[i];
    }

    double difference = MaxNumber - MinNumber;
    Console.WriteLine("Разница между максимальным " + MaxNumber + " и минимальным " + MinNumber + " элементом массива равна " + difference);
}



double[] array = new double[5];
Random randomaiser = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round(randomaiser.NextDouble()*1000 ,2);
}

MaxMinNumber(array);
