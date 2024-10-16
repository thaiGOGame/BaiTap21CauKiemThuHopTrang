using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVienKiemThuHopTrang
{
    public class PhuongThucKiemThuHopTrang
    {
        //Bai3
        public int MaxAndMean(int A, int B, int C, out double Mean)
        {
            Mean = (A + B + C) / 3.0;
            int Maximum;
            if (A > B)
                if (A > C)
                    Maximum = A;
                else
                    Maximum = B;
            else
            if (B > C)
                Maximum = B;
            else
                Maximum = C;
            return Maximum;
        }
        //Bài 4
        public int Max(int a, int b, int c)
        {
            int max = 0;
            if (a > 0 && b > 0 && c > 0)
                max = a;
            else
                return 0;
            if (max < b)
                max = b;
            if (max < c)
                max = c;
            return max;
        }
        //Bài 5
        public String Triangle(int a, int b, int c)
        {
            int match = 0;
            if (a == b)
                match = match + 1;
            if (a == c)
                match = match + 2;
            if (b == c)
                match = match + 3;
            if (match == 0)
                if ((a + b) <= c)
                    return ("Not a Triangle");
                else if ((b + c) <= a)
                    return ("Not a Triangle");
                else if ((a + c) <= b)
                    return ("Not a Triangle");
                else return ("Triangle is Scalene");
            else if (match == 1)
                if ((a + c) <= b)
                    return ("Not a Triangle");
                else return ("Triangle is Isosceles");
            else if (match == 2)
                if ((a + c) <= b)
                    return ("Not a Triangle");
                else return ("Triangle is Isosceles");
            else if (match == 3)
                if ((b + c) <= a)
                    return ("Not a Triangle");
                else return ("Triangle is Isosceles");
            else return ("Triangle is Equilateral");
        }
        //Bai 6
        public double Average(double Sum, double Count)
        {
            if (Count == 1) return Sum;
            else if (Count > 0) return Sum / Count;
            else return 0;
        }
        //Bài 7
        public byte DaysInMonth(ushort year, byte month)
        {
            // Bước 1: Kiểm tra tháng
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                return 31; // Các tháng có 31 ngày: Jan, Mar, May, Jul, Aug, Oct, Dec
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                return 30; // Các tháng có 30 ngày: Apr, Jun, Sep, Nov
            }
            else if (month == 2)
            {
                // Bước 2: Kiểm tra năm nhuận cho tháng 2
                if (year % 400 == 0)
                {
                    return 29; // Năm chia hết cho 400 là năm nhuận
                }
                else if (year % 100 == 0)
                {
                    return 28; // Năm chia hết cho 100 nhưng không chia hết cho 400 không phải năm nhuận
                }
                else if (year % 4 == 0)
                {
                    return 29; // Năm chia hết cho 4 là năm nhuận
                }
                else
                {
                    return 28; // Các năm khác không phải năm nhuận
                }
            }
            else
            {
                return 0; // Tháng không hợp lệ
            }
        }
        //Bài 8
        public (float?, float?) SolveQuadraticEquation(float a, float b, float c)
        {
            float delta;

            // Bước 1: Kiểm tra nếu a = 0
            if (a == 0)
            {
                throw new ArgumentException("Phương trình không phải bậc hai (a không thể bằng 0).");
            }

            // Bước 2: Tính delta
            delta = b * b - 4 * a * c;

            // Bước 3: Kiểm tra giá trị của delta
            if (delta < 0)
            {
                Console.WriteLine("No result"); // In ra thông báo nếu không có nghiệm thực
                return (null, null);
            }
            else if (delta == 0)
            {
                // Một nghiệm kép
                float x = -b / (2 * a);
                return (x, x);
            }
            else
            {
                // Hai nghiệm phân biệt
                float x1 = (-b - (float)System.Math.Sqrt(delta)) / (2 * a);
                float x2 = (-b + (float)System.Math.Sqrt(delta)) / (2 * a);
                return (x1, x2);
            }
        }
        //Bài 9
        public float CheckValueInRangeAToB(float a, float b, float x)
        {
            // Kiểm tra điều kiện
            if (a > b)
            {
                Console.WriteLine("Lỗi: a phải nhỏ hơn hoặc bằng b.");
                return float.NaN;
            }

            if (x < a)
            {
                return a; // Nếu x < a, trả về a
            }
            else if (x > b)
            {
                return b; // Nếu x > b, trả về b
            }
            else
            {
                return x; // Nếu a <= x <= b, trả về x
            }
        }
        //Bài 10
        public bool IsValidTriangle(float a, float b, float c)
        {
            // Bước 1: Kiểm tra nếu một trong các cạnh nhỏ hơn hoặc bằng 0
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return false;
            }

            // Bước 2: Kiểm tra điều kiện tổng hai cạnh lớn hơn cạnh còn lại
            if (a + b <= c)
            {
                return false;
            }

            if (a + c <= b)
            {
                return false;
            }

            if (b + c <= a)
            {
                return false;
            }

            // Bước 3: Nếu tất cả các điều kiện đều thỏa, trả về true (là tam giác hợp lệ)
            return true;
        }
        //Bai 11
        public (float x, float y) CalculatePositionImageInWindow(float w, float h, float ww, float wh)
        {
            // Kiểm tra điều kiện đầu vào
            if (w <= 0 || h <= 0 || ww <= 0 || wh <= 0)
            {
                throw new ArgumentException("Lỗi: Chiều rộng và chiều cao phải lớn hơn 0."); // Ném ngoại lệ nếu có lỗi
            }

            float x, y;

            if (w > ww)
            {
                x = 0;
                 // Tính x
            }
            else
            {
                x = (ww - w) / 2;
            }

            if (h > wh)
            {
                y = 0; // Nếu h > wh, gán y = 0
            }
            else
            {
                y = (wh - h) / 2; // Tính y
            }

            return (x, y); // Trả về cặp giá trị x và y
        }
        //Bài 12
        public float CalculateElectricityCost( float p1, float p2, float p3, float total)
        {
            if (p1 < 0 || p2 < 0 || p3 < 0 || total < 0)
            {
                throw new ArgumentException("Error: p1, p2, p3, and total must be non-negative.");
            }
            if (total <= 100)
            {
                return total * p1;
            }
            else if (total <= 150)
            {
                return 100 * p1 + (total - 100) * p2;
            }
            else
            {
                return 100 * p1 + 50 * p2 + (total - 150) * p3;
            }
        }
        //Bài 13
        public bool IsPointInRectangle(float x1, float y1, float x2, float y2, float x, float y)
        {
            // Kiểm tra điều kiện đầu vào
            if (x1 >= x2 || y1 >= y2)
            {
                throw new ArgumentException("Lỗi: x1 phải nhỏ hơn x2 và y1 phải nhỏ hơn y2."); // Ném ngoại lệ nếu có lỗi
            }

            // Kiểm tra xem điểm (x, y) có nằm trong hình chữ nhật không
            if (x < x1 || x > x2 || y < y1 || y > y2)
            {
                return false; // Điểm nằm ngoài hình chữ nhật
            }

            return true; // Điểm nằm trong hình chữ nhật
        }
        //Bài 14
        public (float x, float y, float s) CalculateDimensions(float w, float h)
        {
            float x, y, s;

            if (w < 0 || h < 0)
            {
                throw new ArgumentException("Error: Invalid width or height."); // Mimic the "print error" by throwing an exception
            }

            if (w > h)
            {
                x = (w - h) / 2;
                y = 0;
                s = h;
            }
            else
            {
                x = 0;
                y = (h - w) / 2;
                s = w;
            }

            return (x, y, s);
        }

        //Bài 15
        public bool IsLeapYear(int year)
        {
            // Kiểm tra giá trị biên
            if (year > 10000 || year < 1000)
            {
                return false; // Năm không hợp lệ
            }
            else
            {
                // Kiểm tra năm nhuận
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        return true; // Năm nhuận
                    }
                    else
                    {
                        return false; // Không phải năm nhuận
                    }
                }
                else if (year % 4 == 0)
                {
                    return true; // Năm nhuận
                }
                else
                {
                    return false; // Không phải năm nhuận
                }
            }
        }

        //Bài 16
        public bool PasswordCheck(string pass)
        {
            // Kiểm tra độ dài của mật khẩu
            if (pass.Length < 6)
            {
                return false; // Không hợp lệ
            }
            if (pass.Length > 10)
            {
                return false; // Không hợp lệ
            }

            // Kiểm tra xem mật khẩu có ít nhất một chữ số hay không
            if (!pass.Any(char.IsDigit))
            {
                return false; // Không hợp lệ
            }

            return true; // Hợp lệ
        }
        //Bài 17
        public bool IsValidDate(short year, byte month, byte day)
        {
            // Kiểm tra tháng
            if (month < 1 || month > 12)
            {
                return false; // Tháng không hợp lệ
            }

            // Kiểm tra ngày
            if (day < 1)
            {
                return false; // Ngày không thể nhỏ hơn 1
            }

            // Lấy số ngày tối đa trong tháng
            int maxDays = DaysInMonth((ushort)year, month);

            // Kiểm tra xem ngày có vượt quá số ngày tối đa trong tháng không
            if (day > maxDays)
            {
                return false; // Ngày vượt quá số ngày tối đa
            }

            return true; // Ngày hợp lệ
        }
        //Bài 18
        public bool EmailCheck(string email)
        {
            // Kiểm tra xem email có ít nhất một ký tự '.' không
            if (!email.Contains('.'))
            {
                return false; // Không hợp lệ
            }

            // Kiểm tra xem email có chứa chuỗi ".." không
            if (email.Contains(".."))
            {
                return false; // Không hợp lệ
            }

            // Kiểm tra xem email có chứa ký tự '@' không
            if (!email.Contains('@'))
            {
                return false; // Không hợp lệ
            }

            // Kiểm tra xem email có chứa chuỗi "@." hoặc ".@" hoặc "@@" không
            if (email.Contains("@.") || email.Contains(".@") || email.Contains("@@"))
            {
                return false; // Không hợp lệ
            }

            return true; // Hợp lệ
        }
        //Bài 19
        public int BodyCheck(int height, int weight)
        {
            if (height <= 0) return -1;
            if (weight <= 0) return -1;
            else
            {
                double scale = weight * 10000 / (height * height);
                if (scale < 18) return 2;
                else if (scale > 20) return 1;
                else return 0;
            }

        }


        // Bai 20
        const int MAX_INT = 32767;
        static string str = "Statement Coverage";
        public int IsInString(char tmp)
        {
            int pos = MAX_INT;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == tmp)
                {
                    pos = i; // Lưu vị trí của ký tự tìm thấy
                    break;   // Thoát khỏi vòng lặp khi tìm thấy
                }
            }

            return pos; // Trả về vị trí hoặc MAX_INT nếu không tìm thấy
        }

        public long HexToDec(string hexaString)
        {

            int c;

            long hexnum, nhex;

            hexnum = nhex = 0;

            int i = 0;

            while (i < hexaString.Length)

            {

                c = hexaString[i++];

                switch (c)

                {

                    case '0':
                    case '1':
                    case '2':

                    case '3':
                    case '4':
                    case '5':

                    case '6':
                    case '7':
                    case '8':

                    case '9':

                        nhex++;

                        hexnum *= 0x10;

                        hexnum += (c - '0');

                        break;

                    case 'a':
                    case 'b':
                    case 'c':

                    case 'd':
                    case 'e':
                    case 'f':

                        

                        nhex++;

                        hexnum *= 0x10;

                        hexnum += (c - 'a' + 0xa);

                        break;

                    case 'A':
                    case 'B':
                    case 'C':

                    case 'D':
                    case 'E':
                    case 'F':

                        /*upper case hex digit */

                        nhex++;

                        hexnum *= 0x10;

                        hexnum += (c - 'A' + 0xA);

                        break;

                    default:

                        break;

                }

            }

            return hexnum;

        }
    }
}
