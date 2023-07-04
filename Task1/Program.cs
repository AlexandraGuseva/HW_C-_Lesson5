// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
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

int QuantitiPositiveNumbers(int[] randomArray)
{
    int quantiti = 0;
    for (int i = 0; i < randomArray.Length; i++)
    {
        if (randomArray[i] % 2 == 0)
            quantiti++;
    }
    return quantiti;
}

// Body
FeelArray(100, 999);
Console.WriteLine($"\n The number of even numbers in the array: {QuantitiPositiveNumbers(randomArray)} \n");