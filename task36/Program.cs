Console.Clear();
Random random = new Random();
int size = 4;
int[] numbers = new int[size];
for (int i = 0; i < size; i++)
numbers[i] = random.Next(1, 100);
int sum = 0;
for (int i = 1; i < size; i += 2)
sum += numbers[i];
Console.WriteLine("Массив чисел:");
for (int i = 0; i < size; i++)
Console.Write(numbers[i] + " ");
Console.WriteLine();
Console.Write("Сумма элементов на нечетных позициях: " + sum);
Console.ReadKey();