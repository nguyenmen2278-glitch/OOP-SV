
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP_1
{
    internal class sinhvien
    {
        public string msv;
        public string hoTen;
        public int tuoi;
        public sinhvien() { } 

        public sinhvien(string msv, string hoTen, int tuoi)
        {
            this.msv = msv;
            this.hoTen = hoTen;
            this.tuoi = tuoi;
        }
        public void NhapSV()
        {
            Console.Write("Nhập MSV: ");
            msv = Console.ReadLine();
            Console.Write("Nhập Họ tên: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhập Tuổi: ");
            tuoi = int.Parse(Console.ReadLine());
        }

        public void DisplaySV()
        {
            Console.WriteLine("MSV: {0} | Họ tên: {1} | Tuổi: {2}", msv, hoTen, tuoi);
        }
    }
}
