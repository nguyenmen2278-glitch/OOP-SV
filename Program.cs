using OOP_1;
using System;
using System.Text;

namespace OOP_B1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

           
            sinhvien[] dsSV = new sinhvien[2];

           
            Console.WriteLine("--- NHẬP THÔNG TIN 2 SINH VIÊN ---");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Nhập sinh viên thứ {i + 1}:");
                dsSV[i] = new sinhvien(); 
                dsSV[i].NhapSV();
            }

           
            Console.WriteLine("\n--- Hien thi thong tin sinh vien ---");
            for (int i = 0; i < 2; i++)
            {
                dsSV[i].DisplaySV(); 
            }

            Console.ReadLine();
        }
    }
}
