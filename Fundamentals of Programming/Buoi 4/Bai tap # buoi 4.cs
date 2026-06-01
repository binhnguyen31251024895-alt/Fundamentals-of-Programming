//using System;
//using System.Text;

//class Program
//{
//    // Bai 1: Tinh tong hai so nguyen
//    static int TinhTong(int a, int b)
//    {
//        return a + b;
//    }

//    // Bai 2: Kiem tra so chan le
//    static bool KiemTraChan(int n)
//    {
//        return n % 2 == 0;
//    }

//    // Bai 3: Tim so lon nhat trong ba so
//    static int TimMax(int a, int b, int c)
//    {
//        return Math.Max(Math.Max(a, b), c);
//    }

//    // Bai 4: Tinh giai thua
//    static long TinhGiaiThua(int n)
//    {
//        long ketQua = 1;

//        for (int i = 1; i <= n; i++)
//        {
//            ketQua *= i;
//        }

//        return ketQua;
//    }

//    // Bai 5: Dao nguoc chuoi
//    static string DaoNguocChuoi(string input)
//    {
//        char[] arr = input.ToCharArray();
//        Array.Reverse(arr);
//        return new string(arr);
//    }

//    // Bai 6: Kiem tra so nguyen to
//    static bool KiemTraNguyenTo(int n)
//    {
//        if (n < 2)
//            return false;

//        for (int i = 2; i <= Math.Sqrt(n); i++)
//        {
//            if (n % i == 0)
//                return false;
//        }

//        return true;
//    }

//    // Bai 7: In day Fibonacci
//    static void InFibonacci(int n)
//    {
//        int a = 0;
//        int b = 1;

//        for (int i = 0; i < n; i++)
//        {
//            Console.Write(a + " ");

//            int temp = a + b;
//            a = b;
//            b = temp;
//        }

//        Console.WriteLine();
//    }

//    // Bai 8: Dem so luong nguyen am trong chuoi
//    static int DemNguyenAm(string s)
//    {
//        int dem = 0;
//        s = s.ToLower();

//        foreach (char c in s)
//        {
//            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
//            {
//                dem++;
//            }
//        }

//        return dem;
//    }

//    // Bai 9: Tinh luy thua khong dung Math.Pow
//    static double TinhLuyThua(double x, int y)
//    {
//        double ketQua = 1;

//        for (int i = 1; i <= Math.Abs(y); i++)
//        {
//            ketQua *= x;
//        }

//        if (y < 0)
//            return 1 / ketQua;

//        return ketQua;
//    }

//    // Bai 10: Tinh diem trung binh cua mang
//    static double TinhTrungBinh(int[] arr)
//    {
//        int tong = 0;

//        foreach (int x in arr)
//        {
//            tong += x;
//        }

//        return (double)tong / arr.Length;
//    }

//    // Bai 11: Kiem tra chuoi doi xung
//    static bool KiemTraDoiXung(string s)
//    {
//        int left = 0;
//        int right = s.Length - 1;

//        while (left < right)
//        {
//            if (s[left] != s[right])
//                return false;

//            left++;
//            right--;
//        }

//        return true;
//    }

//    // Bai 12: Chuyen do C sang do F
//    static double CelsiusToFahrenheit(double c)
//    {
//        return c * 9 / 5 + 32;
//    }

//    // Bai 13: Tim gia tri nho nhat trong mang
//    static int TimMin(int[] arr)
//    {
//        int min = arr[0];

//        foreach (int x in arr)
//        {
//            if (x < min)
//            {
//                min = x;
//            }
//        }

//        return min;
//    }

//    // Bai 14: Tinh tong cac chu so cua mot so nguyen
//    static int TongCacChuSo(int n)
//    {
//        n = Math.Abs(n);
//        int tong = 0;

//        while (n > 0)
//        {
//            tong += n % 10;
//            n /= 10;
//        }

//        return tong;
//    }

//    // Bai 15: Sap xep mang tang dan
//    static void SapXepMang(int[] arr)
//    {
//        Array.Sort(arr);

//        foreach (int x in arr)
//        {
//            Console.Write(x + " ");
//        }

//        Console.WriteLine();
//    }

//    // Bai 16: Xoa ky tu trung lap
//    static string XoaTrungLap(string s)
//    {
//        string ketQua = "";

//        foreach (char c in s)
//        {
//            if (!ketQua.Contains(c))
//            {
//                ketQua += c;
//            }
//        }

//        return ketQua;
//    }

//    // Bai 17: Tim uoc chung lon nhat bang thuat toan Euclid
//    static int UCLN(int a, int b)
//    {
//        a = Math.Abs(a);
//        b = Math.Abs(b);

//        while (b != 0)
//        {
//            int temp = b;
//            b = a % b;
//            a = temp;
//        }

//        return a;
//    }

//    // Bai 18: Chuyen doi thap phan sang nhi phan
//    static string DecimalToBinary(int n)
//    {
//        if (n == 0)
//            return "0";

//        string binary = "";

//        while (n > 0)
//        {
//            binary = (n % 2) + binary;
//            n /= 2;
//        }

//        return binary;
//    }

//    // Bai 19: Kiem tra nam nhuan
//    static bool KiemTraNamNhuan(int year)
//    {
//        return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
//    }

//    // Bai 20: Dem so tu trong cau
//    static int DemSoTu(string sentence)
//    {
//        string[] words = sentence.Split(
//            new char[] { ' ' },
//            StringSplitOptions.RemoveEmptyEntries
//        );

//        return words.Length;
//    }

//    // Ham Main de chay thu toan bo bai
//    static void Mainbuoi4(string[] args) { }
//    {
//        Console.OutputEncoding = Encoding.UTF8;

//        Console.WriteLine("BAI TAP C# - HAM FUNCTIONS");
//        Console.WriteLine("--------------------------");

//        Console.WriteLine("Bai 1: Tong 5 + 3 = " + TinhTong(5, 3));

//        Console.WriteLine("Bai 2: 10 la so chan? " + KiemTraChan(10));

//        Console.WriteLine("Bai 3: Max cua 4, 9, 2 = " + TimMax(4, 9, 2));

//        Console.WriteLine("Bai 4: 5! = " + TinhGiaiThua(5));

//        Console.WriteLine("Bai 5: Dao chuoi 'Hello' = " + DaoNguocChuoi("Hello"));

//        Console.WriteLine("Bai 6: 7 la so nguyen to? " + KiemTraNguyenTo(7));
//        Console.WriteLine("Bai 6: 10 la so nguyen to? " + KiemTraNguyenTo(10));

//        Console.Write("Bai 7: 6 so Fibonacci dau tien: ");
//        InFibonacci(6);

//        Console.WriteLine("Bai 8: So nguyen am trong 'Hello World' = " + DemNguyenAm("Hello World"));

//        Console.WriteLine("Bai 9: 2^3 = " + TinhLuyThua(2, 3));

//        int[] arr10 = { 4, 5, 6, 7 };
//        Console.WriteLine("Bai 10: Trung binh cua [4, 5, 6, 7] = " + TinhTrungBinh(arr10));

//        Console.WriteLine("Bai 11: 'radar' doi xung? " + KiemTraDoiXung("radar"));
//        Console.WriteLine("Bai 11: 'hello' doi xung? " + KiemTraDoiXung("hello"));

//        Console.WriteLine("Bai 12: 25 do C = " + CelsiusToFahrenheit(25) + " do F");

//        int[] arr13 = { 10, 5, 8, 2, 9 };
//        Console.WriteLine("Bai 13: Min cua [10, 5, 8, 2, 9] = " + TimMin(arr13));

//        Console.WriteLine("Bai 14: Tong chu so cua 1234 = " + TongCacChuSo(1234));

//        int[] arr15 = { 3, 1, 4, 2 };
//        Console.Write("Bai 15: Mang sau khi sap xep: ");
//        SapXepMang(arr15);

//        Console.WriteLine("Bai 16: Xoa trung lap 'programming' = " + XoaTrungLap("programming"));

//        Console.WriteLine("Bai 17: UCLN cua 12 va 18 = " + UCLN(12, 18));

//        Console.WriteLine("Bai 18: 10 doi sang nhi phan = " + DecimalToBinary(10));

//        Console.WriteLine("Bai 19: 2024 la nam nhuan? " + KiemTraNamNhuan(2024));
//        Console.WriteLine("Bai 19: 2023 la nam nhuan? " + KiemTraNamNhuan(2023));

//        Console.WriteLine("Bai 20: So tu trong cau = " + DemSoTu("Hoc lap trinh C# rat thu vi"));
//    }
//}
