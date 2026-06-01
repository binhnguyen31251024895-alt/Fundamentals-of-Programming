using System;
using System.Text;

class Baitap6
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("===== PART 1 =====");

        int[] arr = CreateRandomArray(10, 1, 20);

        Console.Write("Random array: ");
        PrintArray(arr);

        Console.WriteLine("Average value: " + CalculateAverage(arr));

        Console.Write("Enter a value to test if array contains it: ");
        int valueToTest = int.Parse(Console.ReadLine());

        if (ContainsValue(arr, valueToTest))
            Console.WriteLine("The array contains " + valueToTest);
        else
            Console.WriteLine("The array does not contain " + valueToTest);

        Console.Write("Enter a value to find its index: ");
        int valueToFind = int.Parse(Console.ReadLine());

        int index = FindIndex(arr, valueToFind);

        if (index != -1)
            Console.WriteLine("Index of " + valueToFind + " is: " + index);
        else
            Console.WriteLine(valueToFind + " is not found in the array.");

        Console.Write("Enter a value to remove from array: ");
        int valueToRemove = int.Parse(Console.ReadLine());

        int[] removedArray = RemoveElement(arr, valueToRemove);

        Console.Write("Array after removing " + valueToRemove + ": ");
        PrintArray(removedArray);

        Console.WriteLine("Maximum value: " + FindMaximum(arr));
        Console.WriteLine("Minimum value: " + FindMinimum(arr));

        int[] reversedArray = ReverseArray(arr);

        Console.Write("Reversed array: ");
        PrintArray(reversedArray);

        int[] duplicateValues = FindDuplicateValues(arr);

        Console.Write("Duplicate values: ");
        PrintArray(duplicateValues);

        int[] noDuplicateArray = RemoveDuplicateElements(arr);

        Console.Write("Array after removing duplicates: ");
        PrintArray(noDuplicateArray);


        Console.WriteLine();
        Console.WriteLine("===== PART 2 - QUESTION 1: BUBBLE SORT =====");

        int[] numbers = new int[10];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter integer number " + (i + 1) + ": ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Original array: ");
        PrintArray(numbers);

        BubbleSort(numbers);

        Console.Write("Sorted array: ");
        PrintArray(numbers);


        Console.WriteLine();
        Console.WriteLine("===== PART 2 - QUESTION 2: LINEAR SEARCH WORD =====");

        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        Console.Write("Enter a word to search: ");
        string word = Console.ReadLine();

        bool found = LinearSearchWord(sentence, word);

        if (found)
            Console.WriteLine("The word appears in the sentence.");
        else
            Console.WriteLine("The word does not appear in the sentence.");

        Console.WriteLine();
        Console.WriteLine("Program finished.");
    }

    static int[] CreateRandomArray(int size, int minValue, int maxValue)
    {
        Random random = new Random();
        int[] arr = new int[size];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(minValue, maxValue + 1);
        }

        return arr;
    }

    static double CalculateAverage(int[] arr)
    {
        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        return (double)sum / arr.Length;
    }

    static bool ContainsValue(int[] arr, int value)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == value)
            {
                return true;
            }
        }

        return false;
    }

    static int FindIndex(int[] arr, int value)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == value)
            {
                return i;
            }
        }

        return -1;
    }

    static int[] RemoveElement(int[] arr, int value)
    {
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != value)
            {
                count++;
            }
        }

        int[] newArray = new int[count];
        int index = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != value)
            {
                newArray[index] = arr[i];
                index++;
            }
        }

        return newArray;
    }

    static int FindMaximum(int[] arr)
    {
        int max = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        return max;
    }

    static int FindMinimum(int[] arr)
    {
        int min = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }

        return min;
    }

    static int[] ReverseArray(int[] arr)
    {
        int[] reversed = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            reversed[i] = arr[arr.Length - 1 - i];
        }

        return reversed;
    }

    static int[] FindDuplicateValues(int[] arr)
    {
        int[] temp = new int[arr.Length];
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            bool isDuplicate = false;

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (isDuplicate && !ContainsValueInPart(temp, count, arr[i]))
            {
                temp[count] = arr[i];
                count++;
            }
        }

        int[] duplicates = new int[count];

        for (int i = 0; i < count; i++)
        {
            duplicates[i] = temp[i];
        }

        return duplicates;
    }

    static int[] RemoveDuplicateElements(int[] arr)
    {
        int[] temp = new int[arr.Length];
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (!ContainsValueInPart(temp, count, arr[i]))
            {
                temp[count] = arr[i];
                count++;
            }
        }

        int[] result = new int[count];

        for (int i = 0; i < count; i++)
        {
            result[i] = temp[i];
        }

        return result;
    }

    static bool ContainsValueInPart(int[] arr, int length, int value)
    {
        for (int i = 0; i < length; i++)
        {
            if (arr[i] == value)
            {
                return true;
            }
        }

        return false;
    }

    static void BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static bool LinearSearchWord(string sentence, string word)
    {
        char[] separators = { ' ', '.', ',', '!', '?', ';', ':', '-', '(', ')', '"', '\'' };

        string[] words = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].ToLower() == word.ToLower())
            {
                return true;
            }
        }

        return false;
    }

    static void PrintArray(int[] arr)
    {
        if (arr.Length == 0)
        {
            Console.WriteLine("Empty array");
            return;
        }

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine();
    }
}