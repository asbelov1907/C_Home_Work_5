//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
void UnevenNumbers(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.Write("Не четные числа: ");
    int Uneven = 0;
     for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 != 0)
            Uneven += arr[i];
            
    }
    Console.Write(Uneven + " ");
}


int[] array = new int[4];
    Random randomaiser = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = randomaiser.Next(-1000,1000);
}

UnevenNumbers(array);
