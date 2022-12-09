// Напишите программу, которая перевернет одномерный массив (последний элемент будет на первом мемте, а первый на последнем и т.д.)

void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
      array[i] = new Random().Next(1, 11);
}

int[] ReleaseArray(int[] array) //создаем новый массив
{
    for (int i = 0; i < array.Length / 2; i++)
    {
      int temp = array[i]; // первый элемент
      array[i] = array[array.Length - i - 1]; //на первую позицию кладем последний элемент
      array[array.Length - i - 1] = temp; // на последнюю - первый
    }
    return array;
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n]; // создание изначального массива
InputArray(array); // заполнение массива
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]"); // вывод изначального массива в терминале
Console.WriteLine($"Конечный массив: [{string.Join(", ", ReleaseArray(array))}]");
