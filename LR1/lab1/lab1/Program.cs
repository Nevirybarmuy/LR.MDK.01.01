using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество элементов в массиве");
        int input = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[input];
        Console.WriteLine("Введите элементы массива");
        for (int index = 0; index < array.Length; index++)
        {
            array[index] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Элементы массива: ");
        for (int index = 0; index < array.Length; index++)
        {
            Console.Write($"{array[index]}, ");
        }
        Console.WriteLine();
        int maxvalue = array[0];
        int maxIndex = 0;
        for (int index = 1; index < array.Length; index++)
        {
            if (array[index] > maxvalue)
            {
                maxvalue = array[index];
                maxIndex = index;
            }
        }
        Console.WriteLine("Индекс максимального элемента: " + maxIndex);
        Console.WriteLine("Максимальный элемент: " + maxvalue);
    }
}