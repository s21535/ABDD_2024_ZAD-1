// See https://aka.ms/new-console-template for more information



Console.WriteLine("Hello, World!");
Console.WriteLine("Modification 1");
Console.WriteLine("Modification 2");
Console.WriteLine("Modification 3");

static int CalculateAverage(int[] numbers)
{
    int sum = 0, average = 0;
    for (int i = 0; i <= numbers.Length-1; i++)
    {
        sum = sum + numbers[i];
    }
    average = sum / (numbers.Length-1);
    return average;
}

static int FindMaximum(int[] numbers)
{
    int max = numbers[0];
    for (int i = 1; i <= numbers.Length-1; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    return max;
}