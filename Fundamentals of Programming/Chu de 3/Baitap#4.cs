using System;
using System.Text;

class ControlFlowExercises
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        int choice;

        do
        {
            Console.WriteLine("===== MENU CONTROL FLOW EXERCISES =====");
            Console.WriteLine("1. Check triangle type");
            Console.WriteLine("2. Read 10 numbers and find sum and average");
            Console.WriteLine("3. Display multiplication table");
            Console.WriteLine("4. Display number patterns");
            Console.WriteLine("5. Display all three patterns");
            Console.WriteLine("6. Display harmonic series and sum");
            Console.WriteLine("7. Find perfect numbers in a range");
            Console.WriteLine("8. Check prime number");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an exercise: ");

            choice = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    CheckTriangleType();
                    break;

                case 2:
                    SumAndAverageOf10Numbers();
                    break;

                case 3:
                    MultiplicationTable();
                    break;

                case 4:
                    NumberPatterns();
                    break;

                case 5:
                    DisplayAllPatterns();
                    break;

                case 6:
                    HarmonicSeries();
                    break;

                case 7:
                    PerfectNumbersInRange();
                    break;

                case 8:
                    CheckPrimeNumber();
                    break;

                case 0:
                    Console.WriteLine("Program ended.");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine();

        } while (choice != 0);
    }

    static void CheckTriangleType()
    {
        Console.Write("Enter side a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter side b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter side c: ");
        int c = int.Parse(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
        {
            if (a == b && b == c)
            {
                Console.WriteLine("The triangle is Equilateral.");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("The triangle is Isosceles.");
            }
            else
            {
                Console.WriteLine("The triangle is Scalene.");
            }
        }
        else
        {
            Console.WriteLine("These sides cannot form a triangle.");
        }
    }

    static void SumAndAverageOf10Numbers()
    {
        int sum = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Enter number " + i + ": ");
            int number = int.Parse(Console.ReadLine());

            sum += number;
        }

        double average = sum / 10.0;

        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("Average = " + average);
    }

    static void MultiplicationTable()
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Multiplication table of " + number + ":");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(number + " x " + i + " = " + (number * i));
        }
    }

    static void NumberPatterns()
    {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Pattern 1:");

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }

            Console.WriteLine();
        }

        Console.WriteLine();

        Console.WriteLine("Pattern 2:");

        int value = 1;

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(value + " ");
                value++;
            }

            Console.WriteLine();
        }

        Console.WriteLine();

        Console.WriteLine("Pattern 3:");

        value = 1;

        for (int i = 1; i <= rows; i++)
        {
            for (int space = 1; space <= rows - i; space++)
            {
                Console.Write("  ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write(value + " ");
                value++;
            }

            Console.WriteLine();
        }
    }

    static void DisplayAllPatterns()
    {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Pattern 1:");

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }

            Console.WriteLine();
        }

        Console.WriteLine();

        Console.WriteLine("Pattern 2:");

        int number = 1;

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(number + " ");
                number++;
            }

            Console.WriteLine();
        }

        Console.WriteLine();

        Console.WriteLine("Pattern 3:");

        number = 1;

        for (int i = 1; i <= rows; i++)
        {
            for (int space = 1; space <= rows - i; space++)
            {
                Console.Write("  ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write(number + " ");
                number++;
            }

            Console.WriteLine();
        }
    }

    static void HarmonicSeries()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        double sum = 0;

        Console.Write("Harmonic series: ");

        for (int i = 1; i <= n; i++)
        {
            Console.Write("1/" + i);

            if (i < n)
            {
                Console.Write(" + ");
            }

            sum += 1.0 / i;
        }

        Console.WriteLine();
        Console.WriteLine("Sum = " + sum);
    }

    static void PerfectNumbersInRange()
    {
        Console.Write("Enter start number: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter end number: ");
        int end = int.Parse(Console.ReadLine());

        Console.WriteLine("Perfect numbers from " + start + " to " + end + ":");

        for (int number = start; number <= end; number++)
        {
            int sum = 0;

            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == number && number > 0)
            {
                Console.WriteLine(number);
            }
        }
    }

    static void CheckPrimeNumber()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        bool isPrime = true;

        if (number <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
        {
            Console.WriteLine(number + " is a prime number.");
        }
        else
        {
            Console.WriteLine(number + " is not a prime number.");
        }
    }
}