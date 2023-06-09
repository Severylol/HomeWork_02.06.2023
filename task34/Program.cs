
Console.Clear();
Random random = new Random();// объект для генерации случайных чисел
int size = 4; // тут размер массива
int[] numbers = new int[size]; // Создала массив
for (int i = 0; i < size; i++) // Заполнила массив случайными положительными 3-хзначными числами
    numbers[i] = random.Next(100, 1000);
int evenCount = 0; // Тут переменная чтоб посчитать
foreach (int number in numbers) // Тут перебирала э.м. и проверила их на четность
if (number % 2 == 0)
    evenCount++;
Console.WriteLine("Массив чисел:");
foreach (int number in numbers)
Console.Write(number + " ");
Console.WriteLine(); // Вывожу массив
Console.WriteLine("Количество четных чисел: " + evenCount);
//Верно ж?