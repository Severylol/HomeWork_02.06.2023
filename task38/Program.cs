Console.Clear();
    double[] numbers = { 3.22, 4.2, 1.15, 77.15, 65.2 };
    double max = numbers.Max();
    double min = numbers.Min();
    double difference = max - min;
Console.WriteLine("Массив чисел:");
foreach (double number in numbers)
Console.Write(number + " ");
Console.WriteLine();
Console.Write("Разница между макс. и миним. элементами: " + difference);
Console.ReadKey();