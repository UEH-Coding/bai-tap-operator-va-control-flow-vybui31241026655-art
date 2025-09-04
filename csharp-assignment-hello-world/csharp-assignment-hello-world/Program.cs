public class Program
    {
        public static string SayHello()
        {
            return "Hello World!";
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int choice;
            do
            {
                Console.WriteLine("===== MENU =====");
                Console.WriteLine("1. Thực hiện phép toán cơ bản");
                Console.WriteLine("2. Tính toán hàm số");
                Console.WriteLine("3. Tính vận tốc ");
                Console.WriteLine("4. Tính diện tích và thể tích cầu");
                Console.WriteLine("5. Nhận dạng kí tự");
                Console.WriteLine("6. Kiểm tra số chẵn, số lẻ");
                Console.WriteLine("7. Tìm số lớn nhất trong 3 số");
                Console.WriteLine("8. Xác định tọa độ trong hệ tọa độ Oxy ");
                Console.WriteLine("9. Kiểm tra tam giác là tam giác gì");
                Console.WriteLine("10.Nhập vào 10 số, tìm trung bình cộng và tổng của chúng ");
                Console.WriteLine("11. Hiển thị bảng cửu chương của một số nguyên cho trước");
                Console.WriteLine("12. Hiển thị một mẫu hình tam giác với một số");
                Console.WriteLine("13. Nhập vào n số hạng điều hòa và tính tổng của chúng");
                Console.WriteLine("14. Nhập vào dãy số và tìm số hoàn thiện");
                Console.WriteLine("15. Nhập vào một số và xác định số đó có phải số nguyên tố");
                Console.WriteLine("0. Thoát");
                Console.Write("Nhập lựa chọn của bạn: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        PhepToan();
                        break;
                    case 2:
                        HamSo();
                        break;
                    case 3:
                        TinhVanToc();
                        break;
                    case 4:
                        TinhHinhCau();
                        break;
                    case 5:
                        KiemTraKyTu();
                        break;
                    case 6:
                        KiemTraChanLe();
                        break;
                    case 7:
                        TimSoLonNhat();
                        break;
                    case 8:
                        XacDinhGocPhanTu();
                        break;
                    case 0:
                        Console.WriteLine("Thoát chương trình...");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại!");
                        break;
                }

                Console.WriteLine(); // Xuống dòng để menu gọn hơn
            } while (choice != 0);
        }
        //Bài 1
        static void PhepToan()
        {
            // Nhập số thứ nhất
            Console.Write("Nhập số thứ nhất: ");
            double so1 = Convert.ToDouble(Console.ReadLine());

            // Nhập số thứ hai
            Console.Write("Nhập số thứ hai: ");
            double so2 = Convert.ToDouble(Console.ReadLine());

            // Nhập toán tử
            Console.Write("Nhập toán tử (+, -, *, x, /): ");
            char toanTu = Console.ReadLine()[0];

            double ketQua = 0;
            bool hopLe = true;

            switch (toanTu)
            {
                case '+':
                    ketQua = so1 + so2;
                    break;
                case '-':
                    ketQua = so1 - so2;
                    break;
                case '*':
                case 'x':
                case 'X':
                    ketQua = so1 * so2;
                    break;
                case '/':
                    if (so2 != 0)
                    {
                        ketQua = so1 / so2;
                    }
                    else
                    {
                        Console.WriteLine("Lỗi: Không thể chia cho 0!");
                        hopLe = false;
                    }
                    break;
                default:
                    Console.WriteLine("Toán tử không hợp lệ!");
                    hopLe = false;
                    break;
            }

            if (hopLe)
            {
                Console.WriteLine($"Kết quả: {so1} {toanTu} {so2} = {ketQua}");
            }
        }
    //Bài 2
    static void HamSo()
    {
        Console.WriteLine("Giá trị của x = y^2 + 2y + 1 với y từ -5 đến 5:");
        for (int y = -5; y <= 5; y++)
        {
            int x = y * y + 2 * y + 1;
            Console.WriteLine($"y = {y}, x = {x}");
        }
    }

         //Bài 3
        static void TinhVanToc()
            {
                Console.Write("Nhập khoảng cách (km): ");
                double distance = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nhập số giờ: ");
                int hours = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhập số phút: ");
                int minutes = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhập số giây: ");
                int seconds = Convert.ToInt32(Console.ReadLine());

                double totalHours = hours + minutes / 60.0 + seconds / 3600.0;
                if (totalHours == 0)
                {
                    Console.WriteLine("Thời gian không thể bằng 0.");
                    return;
                }
                double speedKmh = distance / totalHours;
                double speedMph = speedKmh / 1.609344;
                Console.WriteLine($"Vận tốc: {speedKmh:F2} km/h, {speedMph:F2} miles/h");
            }
            //Bài 4
            static void TinhHinhCau()
            {
                Console.Write("Nhập bán kính hình cầu: ");
                double r = Convert.ToDouble(Console.ReadLine());
                double dienTich = 4 * Math.PI * r * r;
                double theTich = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);
                Console.WriteLine($"Diện tích bề mặt hình cầu: {dienTich:F2}");
                Console.WriteLine($"Thể tích hình cầu: {theTich:F2}");
            }
            // Bài 5
            static void KiemTraKyTu()
            {
                Console.Write("Nhập một ký tự: ");
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Bạn chưa nhập ký tự nào.");
                    return;
                }
                char c = input[0];

                char lower = Char.ToLower(c);

                if ("aeiou".IndexOf(lower) >= 0)
                {
                    Console.WriteLine("Ký tự là nguyên âm.");
                }
                else if (Char.IsDigit(c))
                {
                    Console.WriteLine("Ký tự là chữ số.");
                }
                else
                {
                    Console.WriteLine("Ký tự là ký tự khác.");
                }
            }
            //Bài 6
            static void KiemTraChanLe()
            {
                int number;
                Console.Write("Nhập một số nguyên: ");
                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.Write("Dữ liệu không hợp lệ. Nhập lại số nguyên: ");
                }

                if (number % 2 == 0)
                    Console.WriteLine($"{number} là số chẵn.");
                else
                    Console.WriteLine($"{number} là số lẻ.");
            }
            //Bài 7
            static void TimSoLonNhat()
            {
                int a, b, c;
                Console.Write("Nhập số thứ nhất: ");
                while (!int.TryParse(Console.ReadLine(), out a))
                {
                    Console.Write("Dữ liệu không hợp lệ. Nhập lại số thứ nhất: ");
                }

                Console.Write("Nhập số thứ hai: ");
                while (!int.TryParse(Console.ReadLine(), out b))
                {
                    Console.Write("Dữ liệu không hợp lệ. Nhập lại số thứ hai: ");
                }

                Console.Write("Nhập số thứ ba: ");
                while (!int.TryParse(Console.ReadLine(), out c))
                {
                    Console.Write("Dữ liệu không hợp lệ. Nhập lại số thứ ba: ");
                }

                int max = a;
                if (b > max) max = b;
                if (c > max) max = c;

                Console.WriteLine($"Số lớn nhất trong ba số là: {max}");
            }
            //Bài 8
            static void XacDinhGocPhanTu()
   {
            Console.Write("Nhập giá trị hoành độ X: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập giá trị tung độ Y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            Console.WriteLine($"Điểm tọa độ ({x},{y}) nằm ở góc phần tư thứ nhất.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine($"Điểm tọa độ ({x},{y}) nằm ở góc phần tư thứ hai.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine($"Điểm tọa độ ({x},{y}) nằm ở góc phần tư thứ ba.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine($"Điểm tọa độ ({x},{y}) nằm ở góc phần tư thứ tư.");
        }
        else if (x == 0 && y == 0)
        {
            Console.WriteLine($"Điểm tọa độ ({x},{y}) nằm tại gốc tọa độ.");
        }
        else if (x == 0)
        {
            Console.WriteLine($"Điểm tọa độ ({x},{y}) nằm trên trục tung (Oy).");
        }
        else if (y == 0)
        {
            Console.WriteLine($"Điểm tọa độ ({x},{y}) nằm trên trục hoành (Ox).");
        }
    }
            //Bài 9
            static void TamGiac()
            {
                Console.Write("Nhập cạnh a: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhập cạnh b: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhập cạnh c: ");
                int c = Convert.ToInt32(Console.ReadLine());

                if (a == b && b == c)
                    Console.WriteLine("Tam giác đều");
                else if (a == b || b == c || a == c)
                    Console.WriteLine("Tam giác cân");
                else
                    Console.WriteLine("Tam giác thường");
            }
            //Bài 10
            static void TongTrungBinh()
            {
                int tong = 0;
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write($"Nhập số thứ {i}: ");
                    tong += Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Tổng = " + tong);
                Console.WriteLine("Trung bình = " + (tong / 10.0));
            }
            //Bài 11
            static void BangCuuChuong()
            {
                Console.Write("Nhập số nguyên: ");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{n} x {i} = {n * i}");
                }
            }
    //Bài 12
    static void MauHinhTamGiac()
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Mẫu hình A:");
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write(j);
            Console.WriteLine();
        }

        Console.WriteLine("Mẫu hình B:");
        int cur = 1;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write(cur++ + " ");
            Console.WriteLine();
        }

        Console.WriteLine("Mẫu hình C:");
        cur = 1;
        for (int i = 1; i <= n; i++)
        {
            for (int s = 1; s <= (n - i) * 2; s++)
                Console.Write(" ");
            for (int j = 1; j <= i; j++)
                Console.Write(cur++ + " ");
            Console.WriteLine();
        }
    }
            //Bài 13
        static void ChuoiDieuHoa()
        {
            Console.Write("Nhập số n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double tong = 0;
            Console.Write("Chuỗi: ");
            for (int i = 1; i <= n; i++)
            {
                Console.Write("1/" + i + " ");
                tong += 1.0 / i;
            }
            Console.WriteLine("\nTổng chuỗi = " + tong.ToString("F4"));
        }
            //Bài 14
            static void SoHoanHao()
            {
                Console.Write("Nhập giới hạn trên: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Các số hoàn hảo:");
                for (int i = 2; i <= n; i++)
                {
                    int tong = 0;
                    for (int j = 1; j < i; j++)
                        if (i % j == 0) tong += j;
                    if (tong == i)
                        Console.WriteLine(i);
                }
            }
            //Bài 15
            static void KiemTraNguyenTo()
            {
                Console.Write("Nhập số cần kiểm tra: ");
                int n = Convert.ToInt32(Console.ReadLine());
                bool laNguyenTo = true;

                if (n < 2) laNguyenTo = false;
                else
                {
                    for (int i = 2; i <= Math.Sqrt(n); i++)
                        if (n % i == 0)
                        {
                            laNguyenTo = false;
                            break;
                        }
                }

                if (laNguyenTo)
                    Console.WriteLine($"{n} là số nguyên tố.");
                else
                    Console.WriteLine($"{n} không phải là số nguyên tố.");
            }
        }
