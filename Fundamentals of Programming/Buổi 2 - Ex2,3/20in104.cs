using System;
using System.Linq;
using System.Collections.Generic;

namespace Fundamentals_of_Programming.Buổi_2___Ex2_3
{
    internal class _20in104
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("20 selected C# exercises");
            Console.WriteLine("Choose exercise number");
            Console.WriteLine("7, 8, 14, 16, 18, 24, 26, 27, 28, 31");
            Console.WriteLine("39, 50, 56, 60, 73, 76, 79, 85, 92, 95");
            Console.Write("Enter exercise number: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 7:
                    Exercise07();
                    break;
                case 8:
                    Exercise08();
                    break;
                case 14:
                    Exercise14();
                    break;
                case 16:
                    Exercise16();
                    break;
                case 18:
                    Exercise18();
                    break;
                case 24:
                    Exercise24();
                    break;
                case 26:
                    Exercise26();
                    break;
                case 27:
                    Exercise27();
                    break;
                case 28:
                    Exercise28();
                    break;
                case 31:
                    Exercise31();
                    break;
                case 39:
                    Exercise39();
                    break;
                case 50:
                    Exercise50();
                    break;
                case 56:
                    Exercise56();
                    break;
                case 60:
                    Exercise60();
                    break;
                case 73:
                    Exercise73();
                    break;
                case 76:
                    Exercise76();
                    break;
                case 79:
                    Exercise79();
                    break;
                case 85:
                    Exercise85();
                    break;
                case 92:
                    Exercise92();
                    break;
                case 95:
                    Exercise95();
                    break;
                default:
                    Console.WriteLine("Invalid exercise number.");
                    break;
            }
        }

        static void Exercise07()
        {
            Console.WriteLine("Exercise 7");
            Console.WriteLine("Write a C# Sharp program to print adding, subtracting, multiplying, dividing and mod of two numbers.");

            Console.Write("Input the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} x {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a} mod {b} = {a % b}");
        }

        static void Exercise08()
        {
            Console.WriteLine("Exercise 8");
            Console.WriteLine("Write a C# Sharp program that prints the multiplication table of a number as input.");

            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }

        static void Exercise14()
        {
            Console.WriteLine("Exercise 14");
            Console.WriteLine("Write a C# program to convert Celsius degrees to Kelvin and Fahrenheit.");

            Console.Write("Enter the amount of Celsius: ");
            int celsius = Convert.ToInt32(Console.ReadLine());

            int kelvin = celsius + 273;
            int fahrenheit = celsius * 18 / 10 + 32;

            Console.WriteLine($"Kelvin = {kelvin}");
            Console.WriteLine($"Fahrenheit = {fahrenheit}");
        }

        static void Exercise16()
        {
            Console.WriteLine("Exercise 16");
            Console.WriteLine("Write a C# program to create a new string where the first and last characters change positions.");

            Console.Write("Input a string: ");
            string text = Console.ReadLine()!;

            if (text.Length <= 1)
            {
                Console.WriteLine(text);
            }
            else
            {
                char first = text[0];
                char last = text[text.Length - 1];
                string middle = text.Substring(1, text.Length - 2);

                string result = last + middle + first;
                Console.WriteLine(result);
            }
        }

        static void Exercise18()
        {
            Console.WriteLine("Exercise 18");
            Console.WriteLine("Write a C# program to check a pair of integers and return true if one is negative and one is positive.");

            Console.Write("Input first integer: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second integer: ");
            int b = Convert.ToInt32(Console.ReadLine());

            bool result = (a < 0 && b > 0) || (a > 0 && b < 0);

            Console.WriteLine(result);
        }

        static void Exercise24()
        {
            Console.WriteLine("Exercise 24");
            Console.WriteLine("Write a C# program to find the longest word in a string.");

            Console.Write("Input a sentence: ");
            string sentence = Console.ReadLine()!;

            string[] words = sentence.Split(' ');
            string longest = "";

            foreach (string word in words)
            {
                if (word.Length > longest.Length)
                {
                    longest = word;
                }
            }

            Console.WriteLine(longest);
        }

        static void Exercise26()
        {
            Console.WriteLine("Exercise 26");
            Console.WriteLine("Write a C# program to compute the sum of the first 500 prime numbers.");

            int count = 0;
            int number = 2;
            int sum = 0;

            while (count < 500)
            {
                if (IsPrime(number))
                {
                    sum += number;
                    count++;
                }

                number++;
            }

            Console.WriteLine("Sum of the first 500 prime numbers:");
            Console.WriteLine(sum);
        }

        static void Exercise27()
        {
            Console.WriteLine("Exercise 27");
            Console.WriteLine("Write a C# program and compute the sum of an integer's digits.");

            Console.Write("Input a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            number = Math.Abs(number);

            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                number = number / 10;
            }

            Console.WriteLine($"Sum of the digits: {sum}");
        }

        static void Exercise28()
        {
            Console.WriteLine("Exercise 28");
            Console.WriteLine("Write a C# program to reverse the words of a sentence.");

            Console.Write("Input a sentence: ");
            string sentence = Console.ReadLine()!;

            string[] words = sentence.Split(' ');
            Array.Reverse(words);

            string result = string.Join(" ", words);

            Console.WriteLine(result);
        }

        static void Exercise31()
        {
            Console.WriteLine("Exercise 31");
            Console.WriteLine("Write a C# program to multiply the corresponding elements of two integer arrays.");

            int[] array1 = { 1, 3, -5, 4 };
            int[] array2 = { 1, 4, -5, -2 };

            Console.WriteLine("Multiply corresponding elements of two arrays:");

            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i] * array2[i] + " ");
            }
        }

        static void Exercise39()
        {
            Console.WriteLine("Exercise 39");
            Console.WriteLine("Write a C# program to find the largest and lowest values from three integer values.");

            Console.Write("Input first integer: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second integer: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input third integer: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int largest = Math.Max(a, Math.Max(b, c));
            int lowest = Math.Min(a, Math.Min(b, c));

            Console.WriteLine($"Largest of three: {largest}");
            Console.WriteLine($"Lowest of three: {lowest}");
        }

        static void Exercise50()
        {
            Console.WriteLine("Exercise 50");
            Console.WriteLine("Write a C# program to rotate an array of integers in the left direction.");

            int[] array = { 1, 2, 8 };

            Console.WriteLine("Original array:");
            Console.WriteLine(string.Join(", ", array));

            int first = array[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[array.Length - 1] = first;

            Console.WriteLine("After rotating array:");
            Console.WriteLine(string.Join(", ", array));
        }

        static void Exercise56()
        {
            Console.WriteLine("Exercise 56");
            Console.WriteLine("Write a C# program to check if a given string is a palindrome or not.");

            Console.Write("Input a string: ");
            string text = Console.ReadLine()!;

            string reversed = new string(text.Reverse().ToArray());

            bool result = text == reversed;

            Console.WriteLine(result);
        }

        static void Exercise60()
        {
            Console.WriteLine("Exercise 60");
            Console.WriteLine("Write a C# program to calculate the sum of all integers in a rectangular matrix. Exclude numbers below 0.");

            int[,] matrix =
            {
                { 0, 2, 3, 2 },
                { 0, 6, 0, 1 },
                { 4, 0, 3, 0 }
            };

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int sum = 0;

            for (int col = 0; col < cols; col++)
            {
                bool blocked = false;

                for (int row = 0; row < rows; row++)
                {
                    if (matrix[row, col] == 0)
                    {
                        blocked = true;
                    }

                    if (!blocked)
                    {
                        sum += matrix[row, col];
                    }
                }
            }

            Console.WriteLine($"Sum = {sum}");
        }

        static void Exercise73()
        {
            Console.WriteLine("Exercise 73");
            Console.WriteLine("Write a C# program to convert the letters of a given string into alphabetical order.");

            Console.Write("Input a string: ");
            string text = Console.ReadLine()!;

            char[] chars = text.ToCharArray();
            Array.Sort(chars);

            string result = new string(chars);

            Console.WriteLine(result);
        }

        static void Exercise76()
        {
            Console.WriteLine("Exercise 76");
            Console.WriteLine("Write a C# program to get the ASCII value of a given character.");

            Console.Write("Input a character: ");
            char ch = Convert.ToChar(Console.ReadLine()!);

            int asciiValue = (int)ch;

            Console.WriteLine($"Ascii value of {ch} is: {asciiValue}");
        }

        static void Exercise79()
        {
            Console.WriteLine("Exercise 79");
            Console.WriteLine("Write a C# program to convert an integer to a string and a string to an integer.");

            string textValue = "50";
            int intValue = int.Parse(textValue);

            Console.WriteLine($"Original value and type: {textValue}, {textValue.GetType()}");
            Console.WriteLine("Convert string to integer:");
            Console.WriteLine($"Return value and type: {intValue}, {intValue.GetType()}");

            int number = 122;
            string stringValue = number.ToString();

            Console.WriteLine($"Original value and type: {number}, {number.GetType()}");
            Console.WriteLine("Convert integer to string:");
            Console.WriteLine($"Return value and type: {stringValue}, {stringValue.GetType()}");
        }

        static void Exercise85()
        {
            Console.WriteLine("Exercise 85");
            Console.WriteLine("Write a C# program to find the cumulative sum of an array of numbers.");

            int[] array = { 1, 3, 4, 5, 6, 7 };
            int sum = 0;

            Console.WriteLine("Original array:");
            Console.WriteLine(string.Join(" ", array));

            Console.WriteLine("Cumulative sum:");

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                Console.Write(sum + " ");
            }
        }

        static void Exercise92()
        {
            Console.WriteLine("Exercise 92");
            Console.WriteLine("Write a C# program to find the next prime number of a given number. If the given number is prime, return the number.");

            Console.Write("Input a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (!IsPrime(number))
            {
                number++;
            }

            Console.WriteLine($"Next prime number or current prime number: {number}");
        }

        static void Exercise95()
        {
            Console.WriteLine("Exercise 95");
            Console.WriteLine("Write a C# program to check whether a bracket string is valid or not.");

            Console.Write("Input bracket string: ");
            string text = Console.ReadLine()!;

            bool result = IsValidBrackets(text);

            Console.WriteLine(result);
        }

        static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static bool IsValidBrackets(string text)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in text)
            {
                if (ch == '(' || ch == '[' || ch == '{' || ch == '<')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == ']' || ch == '}' || ch == '>')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char open = stack.Pop();

                    if (open == '(' && ch != ')') return false;
                    if (open == '[' && ch != ']') return false;
                    if (open == '{' && ch != '}') return false;
                    if (open == '<' && ch != '>') return false;
                }
            }

            return stack.Count == 0;
        }
    }
}