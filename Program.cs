using System;

namespace Chuong3_Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien();
            sv.Nhap();         

            sv.diemTB();
            sv.ThongTinSinhVien();
            Console.ReadLine();
        }
    }
}
