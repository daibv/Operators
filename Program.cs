using System;
namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            float width;//khai bao bien kieu float cho chieu rong width
            float height;//khai bao bien kieu float cho chieu cao height
            Console.Write("Enter width: ");
            width = float.Parse(Console.ReadLine());//Sử dụng Console.ReadLine() để lấy dữ liệu nhập vào từ người dùng
            Console.Write("Enter height: ");
            height = float.Parse(Console.ReadLine());//Sử dụng Console.ReadLine() để lấy dữ liệu nhập vào từ người dùng
            float area = width * height;
            Console.WriteLine("Area is: " + area);
        }
    }
}