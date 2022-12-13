// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива: ");
int.TryParse(Console.ReadLine(), out int size);

int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);

Console.WriteLine("Вот наш массив: ");
int count = 0;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] % 2 == 0)
        count++;
}
Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = int.Parse(Console.ReadLine());
    }
}