using System;

class Program
{
    static void Main()
    {
        int[] array = GenerateRandomArray(10); // Генерация случайного массива из 10 элементов
        Console.WriteLine("Сгенерированный массив: " + string.Join(", ", array));
        int maxLength = FindLongestAlternatingSubsequence(array);
        Console.WriteLine("Длина самой длинной знакопеременной подпоследовательности: " + maxLength);
    }

    static int[] GenerateRandomArray(int length)
    {
        Random random = new Random();
        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            // Генерация случайного числа от -10 до 10, исключая ноль
            int randomNumber;
            do
            {
                randomNumber = random.Next(-10, 11); // Генерация числа от -10 до 10 включительно
            } while (randomNumber == 0);

            array[i] = randomNumber;
        }

        return array;
    }

    static int FindLongestAlternatingSubsequence(int[] array)
    {
        if (array.Length == 0)
        {
            return 0;
        }

        int maxLength = 1; // Длина самой длинной знакопеременной подпоследовательности
        int currentLength = 1; // Длина текущей знакопеременной подпоследовательности

        for (int i = 1; i < array.Length; i++)
        {
            if ((array[i] > 0 && array[i - 1] < 0) || (array[i] < 0 && array[i - 1] > 0))
            {
                currentLength++;
                maxLength = Math.Max(maxLength, currentLength);
            }
            else
            {
                currentLength = 1;
            }
        }

        return maxLength;
    }
}