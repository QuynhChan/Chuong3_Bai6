using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Chuong3_Bai6
{
    class DanhSach
    {
        private int n;
        private SinhVien[] DS;
        private double DiemLapTrinh;
        private double DiemCSDL;
        private double DiemTB;
        public void Nhap()
        {
            Console.WriteLine("Hay nhap so luong sinh vien: ");
            n = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Hay nhap thong tin cho sinh vien thu: ", i);
                DS[i] = new SinhVien();
                DS[i].Nhap();
            }
        }
        public void Xuat()
        {
                if (DS != null && n>0)
                {
                    for (int i= 0; i < n; i ++)
                    {
                    Console.WriteLine("Thong tin cho sinh vien thu: ", i);
                    DS[i] = new SinhVien();
                    }
                }
        }
        public void diemTB()
        {
            DiemTB = (DiemLapTrinh + DiemCSDL) / 2;
        }
        public void DTB()
        {
            for (int i=0;i<n;i++)
            {
                if (DiemTB() > 8)
                {
                    Console.WriteLine("Nhung sinh vien co diem trung binh lon hon 8: ", i);
                }
                else
                {
                    return (-1);
                }
            }
        }

    }
}
