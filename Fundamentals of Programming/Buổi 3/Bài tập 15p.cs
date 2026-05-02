using System;

namespace Fundamentals_of_Programming.Buổi_3
{
    internal class Bài_tập_15p
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("===== BÀI TẬP 15 PHÚT =====");
            Console.WriteLine("1. Tính toán hai số với phép +, -, *, x, /");
            Console.WriteLine("2. Tính giá trị hàm x = y^2 + 2y + 1 với y từ -5 đến 5");
            Console.WriteLine("3. Tính tốc độ km/h và miles/h");
            Console.WriteLine("4. Tính diện tích bề mặt và thể tích hình cầu");
            Console.WriteLine("5. Kiểm tra ký tự là nguyên âm, chữ số hay ký hiệu khác");

            Console.Write("Chọn bài muốn chạy từ 1 đến 5: ");
            int choice = Convert.ToInt32(Console.ReadLine());

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

                default:
                    Console.WriteLine("Bạn chọn sai số bài.");
                    break;
            }
        }

        static void Bai1()
        {
            Console.WriteLine("Bài 1");
            Console.WriteLine("Nhập hai số và một phép toán, sau đó in kết quả.");

            Console.Write("Nhập số thứ nhất: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập phép toán (+, -, *, x, /): ");
            char operation = Convert.ToChar(Console.ReadLine()!);

            Console.Write("Nhập số thứ hai: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            bool valid = true;

            if (operation == '+')
            {
                result = a + b;
            }
            else if (operation == '-')
            {
                result = a - b;
            }
            else if (operation == '*' || operation == 'x' || operation == 'X')
            {
                result = a * b;
            }
            else if (operation == '/')
            {
                if (b != 0)
                {
                    result = a / b;
                }
                else
                {
                    Console.WriteLine("Không thể chia cho 0.");
                    valid = false;
                }
            }
            else
            {
                Console.WriteLine("Phép toán không hợp lệ.");
                valid = false;
            }

            if (valid)
            {
                Console.WriteLine($"Kết quả: {a} {operation} {b} = {result}");
            }
        }

        static void Bai2()
        {
            Console.WriteLine("Bài 2");
            Console.WriteLine("Hiển thị giá trị của hàm x = y^2 + 2y + 1 với y từ -5 đến 5.");

            Console.WriteLine("y\t x");

            for (int y = -5; y <= 5; y++)
            {
                int x = y * y + 2 * y + 1;
                Console.WriteLine($"{y}\t {x}");
            }
        }

        static void Bai3()
        {
            Console.WriteLine("Bài 3");
            Console.WriteLine("Nhập quãng đường và thời gian, sau đó tính tốc độ km/h và miles/h.");

            Console.Write("Nhập quãng đường theo kilomet: ");
            double distanceKm = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập số giờ: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập số phút: ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập số giây: ");
            int seconds = Convert.ToInt32(Console.ReadLine());

            double totalHours = hours + minutes / 60.0 + seconds / 3600.0;

            double speedKmPerHour = distanceKm / totalHours;

            double distanceMiles = distanceKm / 1.609;
            double speedMilesPerHour = distanceMiles / totalHours;

            Console.WriteLine($"Tốc độ theo km/h: {speedKmPerHour:F2}");
            Console.WriteLine($"Tốc độ theo miles/h: {speedMilesPerHour:F2}");
        }

        static void Bai4()
        {
            Console.WriteLine("Bài 4");
            Console.WriteLine("Nhập bán kính hình cầu, tính diện tích bề mặt và thể tích.");

            Console.Write("Nhập bán kính: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double surface = 4 * Math.PI * radius * radius;
            double volume = 4.0 / 3 * Math.PI * radius * radius * radius;

            Console.WriteLine($"Diện tích bề mặt hình cầu: {surface:F2}");
            Console.WriteLine($"Thể tích hình cầu: {volume:F2}");
        }

        static void Bai5()
        {
            Console.WriteLine("Bài 5");
            Console.WriteLine("Nhập một ký tự, kiểm tra ký tự đó là nguyên âm, chữ số hay ký hiệu khác.");

            Console.Write("Nhập một ký tự: ");
            char ch = Convert.ToChar(Console.ReadLine()!);

            if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine("Ký tự này là chữ số.");
            }
            else if (
                ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
                ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U'
            )
            {
                Console.WriteLine("Ký tự này là nguyên âm.");
            }
            else
            {
                Console.WriteLine("Ký tự này là ký hiệu khác hoặc phụ âm.");
            }
        }
    }
}