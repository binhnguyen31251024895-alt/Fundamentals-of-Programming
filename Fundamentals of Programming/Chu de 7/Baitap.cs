using System;
using System.IO;
using System.Text;

class FileExercises
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        int choice;

        do
        {
            Console.WriteLine("===== MENU FILE EXERCISES =====");
            Console.WriteLine("1. Create a blank file");
            Console.WriteLine("2. Remove a file");
            Console.WriteLine("3. Create a file and add text");
            Console.WriteLine("4. Create a text file and read it");
            Console.WriteLine("5. Write an array of strings to a file");
            Console.WriteLine("6. Append text to an existing file");
            Console.WriteLine("7. Copy a file and display content");
            Console.WriteLine("8. Move a file with another name");
            Console.WriteLine("9. Read the first line of a file");
            Console.WriteLine("10. Read the last line of a file");
            Console.WriteLine("11. Read the last n lines of a file");
            Console.WriteLine("12. Read a specific line from a file");
            Console.WriteLine("13. Count number of lines in a file");
            Console.WriteLine("14. Print folder structure including files");
            Console.WriteLine("15. Count characters and numbers in a text file");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an exercise: ");

            choice = int.Parse(Console.ReadLine());

            Console.WriteLine();

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
                case 14: Bai14(); break;
                case 15: Bai15(); break;
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

    // 1. Create a blank file
    static void Bai1()
    {
        Console.Write("Enter file name: ");
        string fileName = Console.ReadLine();

        File.Create(fileName).Close();

        Console.WriteLine("Blank file created successfully.");
    }

    // 2. Remove a file from the disk
    static void Bai2()
    {
        Console.Write("Enter file name to delete: ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            File.Delete(fileName);
            Console.WriteLine("File deleted successfully.");
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }

    // 3. Create a file and add some text
    static void Bai3()
    {
        Console.Write("Enter file name: ");
        string fileName = Console.ReadLine();

        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        File.WriteAllText(fileName, text);

        Console.WriteLine("File created and text added successfully.");
    }

    // 4. Create a text file and read it
    static void Bai4()
    {
        Console.Write("Enter file name: ");
        string fileName = Console.ReadLine();

        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        File.WriteAllText(fileName, text);

        Console.WriteLine("Content of file:");
        string content = File.ReadAllText(fileName);
        Console.WriteLine(content);
    }

    // 5. Create a file and write an array of strings to the file
    static void Bai5()
    {
        Console.Write("Enter file name: ");
        string fileName = Console.ReadLine();

        Console.Write("Enter number of lines: ");
        int n = int.Parse(Console.ReadLine());

        string[] lines = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Line " + (i + 1) + ": ");
            lines[i] = Console.ReadLine();
        }

        File.WriteAllLines(fileName, lines);

        Console.WriteLine("Array of strings written to file successfully.");
    }

    // 6. Append some text to an existing file
    static void Bai6()
    {
        Console.Write("Enter file name: ");
        string fileName = Console.ReadLine();

        Console.Write("Enter text to append: ");
        string text = Console.ReadLine();

        File.AppendAllText(fileName, text + Environment.NewLine);

        Console.WriteLine("Text appended successfully.");
    }

    // 7. Create and copy the file to another name and display the content
    static void Bai7()
    {
        Console.Write("Enter source file name: ");
        string sourceFile = Console.ReadLine();

        Console.Write("Enter text for source file: ");
        string text = Console.ReadLine();

        File.WriteAllText(sourceFile, text);

        Console.Write("Enter destination file name: ");
        string destinationFile = Console.ReadLine();

        File.Copy(sourceFile, destinationFile, true);

        Console.WriteLine("File copied successfully.");
        Console.WriteLine("Content of copied file:");

        string content = File.ReadAllText(destinationFile);
        Console.WriteLine(content);
    }

    // 8. Create a file and move it into the same directory with another name
    static void Bai8()
    {
        Console.Write("Enter original file name: ");
        string oldFile = Console.ReadLine();

        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        File.WriteAllText(oldFile, text);

        Console.Write("Enter new file name: ");
        string newFile = Console.ReadLine();

        if (File.Exists(newFile))
        {
            File.Delete(newFile);
        }

        File.Move(oldFile, newFile);

        Console.WriteLine("File moved/renamed successfully.");
    }

    // 9. Read the first line of a file
    static void Bai9()
    {
        Console.Write("Enter file name: ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);

            if (lines.Length > 0)
            {
                Console.WriteLine("First line: " + lines[0]);
            }
            else
            {
                Console.WriteLine("File is empty.");
            }
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }

    // 10. Read the last line of a file
    static void Bai10()
    {
        Console.Write("Enter file name: ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);

            if (lines.Length > 0)
            {
                Console.WriteLine("Last line: " + lines[lines.Length - 1]);
            }
            else
            {
                Console.WriteLine("File is empty.");
            }
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }

    // 11. Read the last n lines of a file
    static void Bai11()
    {
        Console.Write("Enter file name: ");
        string fileName = Console.ReadLine();

        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);

            int start = lines.Length - n;

            if (start < 0)
            {
                start = 0;
            }

            Console.WriteLine("Last " + n + " lines:");

            for (int i = start; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i]);
            }
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }

    // 12. Read a specific line from a file
    static void Bai12()
    {
        Console.Write("Enter file name: ");
        string fileName = Console.ReadLine();

        Console.Write("Enter line number: ");
        int lineNumber = int.Parse(Console.ReadLine());

        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);

            if (lineNumber >= 1 && lineNumber <= lines.Length)
            {
                Console.WriteLine("Line " + lineNumber + ": " + lines[lineNumber - 1]);
            }
            else
            {
                Console.WriteLine("Invalid line number.");
            }
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }

    // 13. Count the number of lines in a file
    static void Bai13()
    {
        Console.Write("Enter file name: ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);

            Console.WriteLine("Number of lines = " + lines.Length);
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }

    // 14. Print folder structure including files
    static void Bai14()
    {
        Console.Write("Enter folder path: ");
        string folderPath = Console.ReadLine();

        if (Directory.Exists(folderPath))
        {
            PrintDirectory(folderPath, 0);
        }
        else
        {
            Console.WriteLine("Folder does not exist.");
        }
    }

    static void PrintDirectory(string folderPath, int level)
    {
        string indent = new string(' ', level * 4);

        Console.WriteLine(indent + "[Folder] " + Path.GetFileName(folderPath));

        string[] files = Directory.GetFiles(folderPath);

        for (int i = 0; i < files.Length; i++)
        {
            Console.WriteLine(indent + "    [File] " + Path.GetFileName(files[i]));
        }

        string[] directories = Directory.GetDirectories(folderPath);

        for (int i = 0; i < directories.Length; i++)
        {
            PrintDirectory(directories[i], level + 1);
        }
    }

    // 15. Read a text file, then count characters and numbers
    static void Bai15()
    {
        Console.Write("Enter file name: ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            string content = File.ReadAllText(fileName);

            int characters = 0;
            int numbers = 0;

            for (int i = 0; i < content.Length; i++)
            {
                char c = content[i];

                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                {
                    characters++;
                }
                else if (c >= '0' && c <= '9')
                {
                    numbers++;
                }
            }

            Console.WriteLine("Characters = " + characters);
            Console.WriteLine("Numbers = " + numbers);
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }
}