// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
Console.Clear();

double[] randomArray = new double[10];
// Methods
void FeelArray(int min, int max)
{
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().NextDouble();
        Console.Write($"{randomArray[i]:F2} ");
    }
    Console.WriteLine();
}

double razn(double[] randomArray)
{
    double min = randomArray[0];
    double max = randomArray[0];
    int i = 1;
    while (i < randomArray.Length)
    {
        if (min > randomArray[i]) min = randomArray[i];
        if (max < randomArray[i]) max = randomArray[i];
        i++;
    }
    return max - min;
}
FeelArray(1, 3);
Console.WriteLine($"\n The difference between the maximum and minimum array elements: {razn(randomArray):F2}\n");