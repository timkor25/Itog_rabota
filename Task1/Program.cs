using System;

class Program
{
    static void Main()
    {
        // Задаем исходный массив строк
        string[] originalArray = { "Hello", "2", "world", ":-)" };

        // Подсчитываем, сколько элементов будут в новом массиве
        int count = 0;
        foreach (string item in originalArray)
        {
            if (item.Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив для строк, удовлетворяющих условию
        string[] filteredArray = new string[count];

        // Заполняем новый массив подходящими строками
        int index = 0;
        foreach (string item in originalArray)
        {
            if (item.Length <= 3)
            {
                filteredArray[index] = item;
                index++;
            }
        }

        // Выводим результат
        Console.WriteLine("[" + string.Join(", ", filteredArray) + "]");
    }
}

