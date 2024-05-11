using System;

class Program
{
    static void Main()
    {
        // Задаем третий исходный массив строк
        string[] originalArray = { "Russia", "Denmark", "Kazan" };

        int count = 0;
        foreach (string item in originalArray)
        {
            if (item.Length <= 3)
            {
                count++;
            }
        }

        string[] filteredArray = new string[count];

        int index = 0;
        foreach (string item in originalArray)
        {
            if (item.Length <= 3)
            {
                filteredArray[index] = item;
                index++;
            }
        }

        Console.WriteLine("[" + string.Join(", ", filteredArray) + "]");
    }
}
