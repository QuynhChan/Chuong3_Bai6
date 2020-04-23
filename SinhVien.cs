using System;
using System.Collections.Generic;
using System.Text;

namespace Chuong3_Bai6
{
    class SinhVien
    {
        private string MaSinhVien;
        private string HoTen;
        private int NamSinh;
        private double DiemLapTrinh;
        private double DiemCSDL;
        private double DiemTB;

        public SinhVien()
        {
            MaSinhVien = "";
            HoTen = "";
            NamSinh = 1990;
            DiemLapTrinh = DiemCSDL = DiemTB = 0;
        }
        public SinhVien(string MaSinhVien, string HoTen, int NamSinh, double DiemLapTrinh, double DIemCSDL)
        {
            this.MaSinhVien = MaSinhVien;
            this.HoTen = HoTen;
            this.NamSinh = NamSinh;
            this.DiemLapTrinh = DiemLapTrinh;
            this.DiemCSDL = DIemCSDL;
            this.DiemTB = (DiemLapTrinh + DiemCSDL)/2;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap ma sinh vien: ");
            MaSinhVien = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap ho ten sinh vien: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh cua sinh vien: ");
            NamSinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap diem lap trinh cua sinh vien: ");
            DiemLapTrinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap diem CSDL cua sinh vien: ");
            DiemCSDL = Convert.ToInt32(Console.ReadLine());
        }
        public void diemTB()
        {
            DiemTB = (DiemLapTrinh + DiemCSDL) / 2;
        }
        public void ThongTinSinhVien()
        {
            Console.WriteLine("Ma sinh vien: {0} \t Ho ten sinh vien: {1} \t Nam sinh: {2} \n " +
                "Diem lap trinh: {3} \t Diem CSDL: {4} \t Diem TB: {5}", MaSinhVien, HoTen, NamSinh, DiemLapTrinh,
                DiemCSDL, DiemTB);
        }
    }
}
