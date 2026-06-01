using System;

class StringExercises
{
    static void Mainbaitap8()
    {
        int choice;

        do
        {
            Console.WriteLine("===== STRING EXERCISES =====");
            Console.WriteLine("1. Input and print string");
            Console.WriteLine("2. Find string length");
            Console.WriteLine("3. Separate characters");
            Console.WriteLine("4. Reverse string");
            Console.WriteLine("5. Count words");
            Console.WriteLine("6. Compare two strings");
            Console.WriteLine("7. Count alphabets, digits, special chars");
            Console.WriteLine("8. Count vowels and consonants");
            Console.WriteLine("9. Check substring");
            Console.WriteLine("10. Find position of substring");
            Console.WriteLine("11. Check alphabet and case");
            Console.WriteLine("12. Count substring occurrences");
            Console.WriteLine("13. Insert substring");
            Console.WriteLine("0. Exit");

            Console.Write("Choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: Bai1(); break;
                case 2: Bai2(); break;
                case 3: Bai3(); break;
                case 4: Bai4(); break;
                case 5: Bai5(); break;
                case 6: Bai6(); break;
                case 7: Bai7(); break;
                case 8: Bai8(); break;
                case 9: Bai9(); break;
                case 10: Bai10(); break;
                case 11: Bai11(); break;
                case 12: Bai12(); break;
                case 13: Bai13(); break;
            }

            Console.WriteLine();

        } while (choice != 0);
    }

    static void Bai1()
    {
        Console.Write("Enter string: ");
        string s = Console.ReadLine();

        Console.WriteLine(s);
    }

    static void Bai2()
    {
        Console.Write("Enter string: ");
        string s = Console.ReadLine();

        int count = 0;

        foreach (char c in s)
        {
            count++;
        }

        Console.WriteLine("Length = " + count);
    }

    static void Bai3()
    {
        Console.Write("Enter string: ");
        string s = Console.ReadLine();

        foreach (char c in s)
        {
            Console.WriteLine(c);
        }
    }

    static void Bai4()
    {
        Console.Write("Enter string: ");
        string s = Console.ReadLine();

        for (int i = s.Length - 1; i >= 0; i--)
        {
            Console.Write(s[i]);
        }

        Console.WriteLine();
    }

    static void Bai5()
    {
        Console.Write("Enter string: ");
        string s = Console.ReadLine();

        int words = 0;
        bool insideWord = false;

        foreach (char c in s)
        {
            if (c != ' ')
            {
                if (!insideWord)
                {
                    words++;
                    insideWord = true;
                }
            }
            else
            {
                insideWord = false;
            }
        }

        Console.WriteLine("Words = " + words);
    }

    static void Bai6()
    {
        Console.Write("String 1: ");
        string s1 = Console.ReadLine();

        Console.Write("String 2: ");
        string s2 = Console.ReadLine();

        if (s1 == s2)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not Equal");
        }
    }

    static void Bai7()
    {
        Console.Write("Enter string: ");
        string s = Console.ReadLine();

        int letters = 0;
        int digits = 0;
        int special = 0;

        foreach (char c in s)
        {
            if ((c >= 'A' && c <= 'Z') ||
                (c >= 'a' && c <= 'z'))
            {
                letters++;
            }
            else if (c >= '0' && c <= '9')
            {
                digits++;
            }
            else
            {
                special++;
            }
        }

        Console.WriteLine("Alphabets = " + letters);
        Console.WriteLine("Digits = " + digits);
        Console.WriteLine("Special = " + special);
    }

    static void Bai8()
    {
        Console.Write("Enter string: ");
        string s = Console.ReadLine();

        int vowels = 0;
        int consonants = 0;

        foreach (char c in s)
        {
            char x = Char.ToLower(c);

            if ((x >= 'a' && x <= 'z'))
            {
                if (x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u')
                {
                    vowels++;
                }
                else
                {
                    consonants++;
                }
            }
        }

        Console.WriteLine("Vowels = " + vowels);
        Console.WriteLine("Consonants = " + consonants);
    }

    static void Bai9()
    {
        Console.Write("Main string: ");
        string s = Console.ReadLine();

        Console.Write("Substring: ");
        string sub = Console.ReadLine();

        if (s.Contains(sub))
        {
            Console.WriteLine("Present");
        }
        else
        {
            Console.WriteLine("Not Present");
        }
    }

    static void Bai10()
    {
        Console.Write("Main string: ");
        string s = Console.ReadLine();

        Console.Write("Substring: ");
        string sub = Console.ReadLine();

        Console.WriteLine("Position = " + s.IndexOf(sub));
    }

    static void Bai11()
    {
        Console.Write("Enter character: ");
        char c = char.Parse(Console.ReadLine());

        if ((c >= 'A' && c <= 'Z') ||
            (c >= 'a' && c <= 'z'))
        {
            Console.WriteLine("Alphabet");

            if (c >= 'A' && c <= 'Z')
            {
                Console.WriteLine("Uppercase");
            }
            else
            {
                Console.WriteLine("Lowercase");
            }
        }
        else
        {
            Console.WriteLine("Not Alphabet");
        }
    }

    static void Bai12()
    {
        Console.Write("Main string: ");
        string s = Console.ReadLine();

        Console.Write("Substring: ");
        string sub = Console.ReadLine();

        int count = 0;
        int pos = 0;

        while ((pos = s.IndexOf(sub, pos)) != -1)
        {
            count++;
            pos += sub.Length;
        }

        Console.WriteLine("Occurrences = " + count);
    }

    static void Bai13()
    {
        Console.Write("Main string: ");
        string s = Console.ReadLine();

        Console.Write("Find substring: ");
        string oldSub = Console.ReadLine();

        Console.Write("Insert substring: ");
        string newSub = Console.ReadLine();

        int pos = s.IndexOf(oldSub);

        if (pos == -1)
        {
            Console.WriteLine("Substring not found");
        }
        else
        {
            string result =
                s.Substring(0, pos) +
                newSub +
                s.Substring(pos);

            Console.WriteLine(result);
        }
    }
}