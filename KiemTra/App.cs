using KiemTra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra
{
    public class App
    {
        List<DienThoai> dts = new List<DienThoai>();
        int n;
        public void nhap()
        {
            do
            {
                Console.Write("Nhap so luong dien thoai: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 1);
            dts = new List<DienThoai>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin dien thoai thu " + i + 1);
                DienThoai x = new DienThoai();
                x.nhapDienThoai();
                dts.Add(x);
            }
        }
        public void timDienThoaiDonGia()
        {
            double a, b;
            do
            {
                Console.Write("Nhap a = ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Nhap b = ");
                b = double.Parse(Console.ReadLine());
            } while (a > b && a > 0 && b > 0);
            int flag = 0;
            for (int i = 0; i < n; i++)
            {
                if (dts[i].getDonGia() < b && dts[i].getDonGia() > a)
                {
                    dts[i].xuatDienThoai();
                    flag = 1;
                }
                if (flag == 0)
                {
                    Console.WriteLine("Khong tim thay dien thoai");
                }
            }
        }
        public void timDienThoaiDatNhat()
        {
            double max = dts[0].getDonGia();
            for (int i = 0; i < n; i++)
            {
                if (max < dts[i].getDonGia())
                {
                    max = dts[i].getDonGia();
                }
            }
            int flag = 0;
            for (int i = 0; i < n; i++)
            {
                if (dts[i].getDonGia() == max)
                {
                    dts[i].xuatDienThoai();
                    flag = 1;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Khong tim thay dien thoai");
            }
        }
    }
}