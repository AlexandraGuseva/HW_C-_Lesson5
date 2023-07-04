// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();

int[] randomArray = new int[10];
// Methods
void FeelArray(int min, int max) // Creating array and filled random numbers
{
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().Next(min, max);
        Console.Write($"{randomArray[i]} ");
    }
}

int SumNumbersOnNegativePosition(int[] randomArray)
{
    int sum = 0;
    for (int i = 1; i < randomArray.Length; i++)
    {
        if (i % 2 != 0)
            sum += randomArray[i];
    }
    return sum;
}

// Body
FeelArray(1, 5);
Console.WriteLine($"\n The summ numbers on negative position: {SumNumbersOnNegativePosition(randomArray)} \n");