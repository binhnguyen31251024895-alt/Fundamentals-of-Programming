using System;
using System.Text;

namespace Fundamentals_of_Programming.Buổi_3
{
    internal class Làm_lại_các_bài_trong_slide
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            int luaChon;

            do
            {
                Console.WriteLine("\n===== MENU 11 BÀI TẬP CONTROL FLOW =====");
                Console.WriteLine("1. Kiểm tra số chẵn hay số lẻ");
                Console.WriteLine("2. Tìm số lớn nhất trong 3 số");
                Console.WriteLine("3. Xác định điểm tọa độ nằm ở góc phần tư nào");
                Console.WriteLine("4. Kiểm tra loại tam giác");
                Console.WriteLine("5. Nhập 10 số, tính tổng và trung bình");
                Console.WriteLine("6. In bảng cửu chương");
                Console.WriteLine("7. In tam giác số");
                Console.WriteLine("8. In các mẫu hình số trong slide");
                Console.WriteLine("9. Tính dãy điều hòa");
                Console.WriteLine("10. Tìm số hoàn hảo trong một khoảng");
                Console.WriteLine("11. Kiểm tra số nguyên tố");
                Console.WriteLine("0. Thoát chương trình");
                Console.Write("Chọn bài muốn chạy: ");

                luaChon = int.Parse(Console.ReadLine()!);

                switch (luaChon)
                {
                    case 1:
                        KiemTraChanLe();
                        break;
                    case 2:
                        TimSoLonNhatTrongBaSo();
                        break;
                    case 3:
                        XacDinhGocPhanTu();
                        break;
                    case 4:
                        KiemTraLoaiTamGiac();
                        break;
                    case 5:
                        TinhTongVaTrungBinh10So();
                        break;
                    case 6:
                        InBangCuuChuong();
                        break;
                    case 7:
                        InTamGiacSo();
                        break;
                    case 8:
                        InCacMauHinhSo();
                        break;
                    case 9:
                        TinhDayDieuHoa();
                        break;
                    case 10:
                        TimSoHoanHaoTrongKhoang();
                        break;
                    case 11:
                        KiemTraSoNguyenTo();
                        break;
                    case 0:
                        Console.WriteLine("Đã thoát chương trình.");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }

            } while (luaChon != 0);
        }

        // Bài 1: Kiểm tra số chẵn hay số lẻ
        static void KiemTraChanLe()
        {
            Console.Write("Nhập một số: ");
            int n = int.Parse(Console.ReadLine()!);

            if (n % 2 == 0)
                Console.WriteLine($"{n} là số chẵn.");
            else
                Console.WriteLine($"{n} là số lẻ.");
        }

        // Bài 2: Tìm số lớn nhất trong 3 số
        static void TimSoLonNhatTrongBaSo()
        {
            Console.Write("Nhập số thứ nhất: ");
            int a = int.Parse(Console.ReadLine()!);

            Console.Write("Nhập số thứ hai: ");
            int b = int.Parse(Console.ReadLine()!);

            Console.Write("Nhập số thứ ba: ");
            int c = int.Parse(Console.ReadLine()!);

            int lonNhat = a;

            if (b > lonNhat)
                lonNhat = b;

            if (c > lonNhat)
                lonNhat = c;

            Console.WriteLine($"Số lớn nhất là: {lonNhat}");
        }

        // Bài 3: Xác định điểm tọa độ nằm ở góc phần tư nào
        static void XacDinhGocPhanTu()
        {
            Console.Write("Nhập tọa độ X: ");
            int x = int.Parse(Console.ReadLine()!);

            Console.Write("Nhập tọa độ Y: ");
            int y = int.Parse(Console.ReadLine()!);

            if (x > 0 && y > 0)
                Console.WriteLine($"Điểm tọa độ ({x},{y}) nằm ở góc phần tư thứ nhất.");
            else if (x < 0 && y > 0)
                Console.WriteLine($"Điểm tọa độ ({x},{y}) nằm ở góc phần tư thứ hai.");
            else if (x < 0 && y < 0)
                Console.WriteLine($"Điểm tọa độ ({x},{y}) nằm ở góc phần tư thứ ba.");
            else if (x > 0 && y < 0)
                Console.WriteLine($"Điểm tọa độ ({x},{y}) nằm ở góc phần tư thứ tư.");
            else if (x == 0 && y == 0)
                Console.WriteLine($"Điểm tọa độ ({x},{y}) nằm tại gốc tọa độ.");
            else if (x == 0)
                Console.WriteLine($"Điểm tọa độ ({x},{y}) nằm trên trục Y.");
            else
                Console.WriteLine($"Điểm tọa độ ({x},{y}) nằm trên trục X.");
        }

        // Bài 4: Kiểm tra tam giác đều, cân hay thường
        static void KiemTraLoaiTamGiac()
        {
            Console.Write("Nhập cạnh thứ nhất: ");
            int a = int.Parse(Console.ReadLine()!);

            Console.Write("Nhập cạnh thứ hai: ");
            int b = int.Parse(Console.ReadLine()!);

            Console.Write("Nhập cạnh thứ ba: ");
            int c = int.Parse(Console.ReadLine()!);

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("Ba cạnh này không tạo thành một tam giác hợp lệ.");
            }
            else if (a == b && b == c)
            {
                Console.WriteLine("Đây là tam giác đều.");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Đây là tam giác cân.");
            }
            else
            {
                Console.WriteLine("Đây là tam giác thường.");
            }
        }

        // Bài 5: Nhập 10 số và tính tổng, trung bình
        static void TinhTongVaTrungBinh10So()
        {
            int tong = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Nhập số thứ {i}: ");
                int n = int.Parse(Console.ReadLine()!);
                tong += n;
            }

            double trungBinh = tong / 10.0;

            Console.WriteLine($"Tổng của 10 số là: {tong}");
            Console.WriteLine($"Trung bình của 10 số là: {trungBinh}");
        }

        // Bài 6: In bảng cửu chương
        static void InBangCuuChuong()
        {
            Console.Write("Nhập một số nguyên: ");
            int n = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Bảng cửu chương của {n}:");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }

        // Bài 7: In tam giác số
        static void InTamGiacSo()
        {
            Console.Write("Nhập số dòng: ");
            int soDong = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= soDong; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }

                Console.WriteLine();
            }
        }

        // Bài 8: In các mẫu hình số giống trong slide
        static void InCacMauHinhSo()
        {
            Console.WriteLine("Mẫu 1:");

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nMẫu 2:");

            int so = 1;

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(so + " ");
                    so++;
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nMẫu 3:");

            so = 1;

            for (int i = 1; i <= 4; i++)
            {
                for (int khoangTrang = 1; khoangTrang <= 4 - i; khoangTrang++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(so + " ");
                    so++;
                }

                Console.WriteLine();
            }
        }

        // Bài 9: In dãy điều hòa và tính tổng
        static void TinhDayDieuHoa()
        {
            Console.Write("Nhập số lượng số hạng n: ");
            int n = int.Parse(Console.ReadLine()!);

            double tong = 0;

            Console.Write("Dãy điều hòa: ");

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"1/{i}");

                if (i < n)
                    Console.Write(" + ");

                tong += 1.0 / i;
            }

            Console.WriteLine();
            Console.WriteLine($"Tổng của dãy điều hòa là: {tong}");
        }

        // Bài 10: Tìm số hoàn hảo trong một khoảng
        static void TimSoHoanHaoTrongKhoang()
        {
            Console.Write("Nhập số bắt đầu: ");
            int batDau = int.Parse(Console.ReadLine()!);

            Console.Write("Nhập số kết thúc: ");
            int ketThuc = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Các số hoàn hảo từ {batDau} đến {ketThuc} là:");

            for (int so = batDau; so <= ketThuc; so++)
            {
                int tongUoc = 0;

                for (int i = 1; i < so; i++)
                {
                    if (so % i == 0)
                    {
                        tongUoc += i;
                    }
                }

                if (tongUoc == so && so > 0)
                {
                    Console.WriteLine(so);
                }
            }
        }

        // Bài 11: Kiểm tra số nguyên tố
        static void KiemTraSoNguyenTo()
        {
            Console.Write("Nhập một số: ");
            int n = int.Parse(Console.ReadLine()!);

            bool laSoNguyenTo = true;

            if (n <= 1)
            {
                laSoNguyenTo = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        laSoNguyenTo = false;
                        break;
                    }
                }
            }

            if (laSoNguyenTo)
                Console.WriteLine($"{n} là số nguyên tố.");
            else
                Console.WriteLine($"{n} không phải là số nguyên tố.");
        }
    }
}