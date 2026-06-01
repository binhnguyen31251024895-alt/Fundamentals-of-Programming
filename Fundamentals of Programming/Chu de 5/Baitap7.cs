using System;
using System.Text;

class BaiTapMang10Bai
{
    static void Mainbaitapmang()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        int choice;

        do
        {
            Console.WriteLine("===== MENU 10 BAI TAP MANG =====");
            Console.WriteLine("1. Nhap va xuat mang");
            Console.WriteLine("2. Tinh tong va trung binh cong");
            Console.WriteLine("3. Tim so lon nhat va nho nhat");
            Console.WriteLine("4. Dem so chan va so le");
            Console.WriteLine("5. Tim kiem mot so trong mang");
            Console.WriteLine("6. Dao nguoc mang");
            Console.WriteLine("7. Kiem tra mang doi xung");
            Console.WriteLine("8. Liet ke cac so nguyen to trong mang");
            Console.WriteLine("9. Tach mang chan - le");
            Console.WriteLine("10. Sap xep mang tang dan va giam dan");
            Console.WriteLine("0. Thoat");
            Console.Write("Chon bai muon chay: ");

            choice = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Bai1();
                    break;

                case 2:
                    Bai2();
                    break;

                case 3:
                    Bai3();
                    break;

                case 4:
                    Bai4();
                    break;

                case 5:
                    Bai5();
                    break;

                case 6:
                    Bai6();
                    break;

                case 7:
                    Bai7();
                    break;

                case 8:
                    Bai8();
                    break;

                case 9:
                    Bai9();
                    break;

                case 10:
                    Bai10();
                    break;

                case 0:
                    Console.WriteLine("Ket thuc chuong trinh.");
                    break;

                default:
                    Console.WriteLine("Lua chon khong hop le.");
                    break;
            }

            Console.WriteLine();

        } while (choice != 0);
    }

    // Bai 1: Nhap va xuat mang
    static void Bai1()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        int[] a = new int[n];

        Console.WriteLine("Nhap " + n + " so nguyen:");

        for (int i = 0; i < n; i++)
        {
            Console.Write("a[" + i + "] = ");
            a[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Mang vua nhap la:");
        PrintArray(a);
    }

    // Bai 2: Tinh tong va trung binh cong
    static void Bai2()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        double[] a = new double[n];

        Console.WriteLine("Nhap " + n + " so thuc:");

        for (int i = 0; i < n; i++)
        {
            Console.Write("a[" + i + "] = ");
            a[i] = double.Parse(Console.ReadLine());
        }

        double sum = 0;

        for (int i = 0; i < n; i++)
        {
            sum += a[i];
        }

        double average = sum / n;

        Console.WriteLine(sum.ToString("F2") + " " + average.ToString("F2"));
    }

    // Bai 3: Tim so lon nhat va nho nhat
    static void Bai3()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        int[] a = new int[n];

        Console.WriteLine("Nhap " + n + " so nguyen:");

        for (int i = 0; i < n; i++)
        {
            Console.Write("a[" + i + "] = ");
            a[i] = int.Parse(Console.ReadLine());
        }

        int max = a[0];
        int min = a[0];

        for (int i = 1; i < n; i++)
        {
            if (a[i] > max)
            {
                max = a[i];
            }

            if (a[i] < min)
            {
                min = a[i];
            }
        }

        Console.WriteLine(max + " " + min);
    }

    // Bai 4: Dem so chan va so le
    static void Bai4()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        int[] a = new int[n];

        Console.WriteLine("Nhap " + n + " so nguyen:");

        for (int i = 0; i < n; i++)
        {
            Console.Write("a[" + i + "] = ");
            a[i] = int.Parse(Console.ReadLine());
        }

        int countEven = 0;
        int countOdd = 0;

        for (int i = 0; i < n; i++)
        {
            if (a[i] % 2 == 0)
            {
                countEven++;
            }
            else
            {
                countOdd++;
            }
        }

        Console.WriteLine(countEven + " " + countOdd);
    }

    // Bai 5: Tim kiem mot so trong mang
    static void Bai5()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Nhap x can tim: ");
        int x = int.Parse(Console.ReadLine());

        int[] a = new int[n];

        Console.WriteLine("Nhap " + n + " so nguyen:");

        for (int i = 0; i < n; i++)
        {
            Console.Write("a[" + i + "] = ");
            a[i] = int.Parse(Console.ReadLine());
        }

        int position = -1;

        for (int i = 0; i < n; i++)
        {
            if (a[i] == x)
            {
                position = i;
                break;
            }
        }

        Console.WriteLine(position);
    }

    // Bai 6: Dao nguoc mang khong dung mang phu
    static void Bai6()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        int[] a = new int[n];

        Console.WriteLine("Nhap " + n + " so nguyen:");

        for (int i = 0; i < n; i++)
        {
            Console.Write("a[" + i + "] = ");
            a[i] = int.Parse(Console.ReadLine());
        }

        int left = 0;
        int right = n - 1;

        while (left < right)
        {
            int temp = a[left];
            a[left] = a[right];
            a[right] = temp;

            left++;
            right--;
        }

        Console.WriteLine("Mang sau khi dao nguoc:");
        PrintArray(a);
    }

    // Bai 7: Kiem tra mang doi xung
    static void Bai7()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        int[] a = new int[n];

        Console.WriteLine("Nhap " + n + " so nguyen:");

        for (int i = 0; i < n; i++)
        {
            Console.Write("a[" + i + "] = ");
            a[i] = int.Parse(Console.ReadLine());
        }

        bool isSymmetric = true;

        for (int i = 0; i < n / 2; i++)
        {
            if (a[i] != a[n - 1 - i])
            {
                isSymmetric = false;
                break;
            }
        }

        if (isSymmetric)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }

    // Bai 8: Liet ke cac so nguyen to trong mang
    static void Bai8()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        int[] a = new int[n];

        Console.WriteLine("Nhap " + n + " so nguyen duong:");

        for (int i = 0; i < n; i++)
        {
            Console.Write("a[" + i + "] = ");
            a[i] = int.Parse(Console.ReadLine());
        }

        bool hasPrime = false;

        for (int i = 0; i < n; i++)
        {
            if (IsPrime(a[i]))
            {
                Console.Write(a[i] + " ");
                hasPrime = true;
            }
        }

        if (!hasPrime)
        {
            Console.WriteLine("EMPTY");
        }
        else
        {
            Console.WriteLine();
        }
    }

    // Bai 9: Tach mang chan - le
    static void Bai9()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        int[] a = new int[n];

        Console.WriteLine("Nhap " + n + " so nguyen:");

        for (int i = 0; i < n; i++)
        {
            Console.Write("a[" + i + "] = ");
            a[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Cac so chan:");

        for (int i = 0; i < n; i++)
        {
            if (a[i] % 2 == 0)
            {
                Console.Write(a[i] + " ");
            }
        }

        Console.WriteLine();

        Console.WriteLine("Cac so le:");

        for (int i = 0; i < n; i++)
        {
            if (a[i] % 2 != 0)
            {
                Console.Write(a[i] + " ");
            }
        }

        Console.WriteLine();
    }

    // Bai 10: Sap xep mang tang dan va giam dan
    static void Bai10()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        int[] a = new int[n];

        Console.WriteLine("Nhap " + n + " so nguyen:");

        for (int i = 0; i < n; i++)
        {
            Console.Write("a[" + i + "] = ");
            a[i] = int.Parse(Console.ReadLine());
        }

        int[] ascending = CopyArray(a);
        int[] descending = CopyArray(a);

        BubbleSortAscending(ascending);
        BubbleSortDescending(descending);

        Console.WriteLine("Mang tang dan:");
        PrintArray(ascending);

        Console.WriteLine("Mang giam dan:");
        PrintArray(descending);
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

    static int[] CopyArray(int[] a)
    {
        int[] b = new int[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            b[i] = a[i];
        }

        return b;
    }

    static void BubbleSortAscending(int[] a)
    {
        for (int i = 0; i < a.Length - 1; i++)
        {
            for (int j = 0; j < a.Length - 1 - i; j++)
            {
                if (a[j] > a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
        }
    }

    static void BubbleSortDescending(int[] a)
    {
        for (int i = 0; i < a.Length - 1; i++)
        {
            for (int j = 0; j < a.Length - 1 - i; j++)
            {
                if (a[j] < a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
        }
    }

    static void PrintArray(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + " ");
        }

        Console.WriteLine();
    }
}