using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra
{
    public class MaHang
    {
        private int maHang;
        private string tenHang;
        private string hangSanxuat;
        private int thoigianBaoHanh;
        private double donGia;

        public double DonGia { get => donGia; set => donGia = value; }

        public MaHang()
        {
        }

        public MaHang(int maHang, string tenHang, string hangSanxuat, int thoigianBaoHanh, double donGia)
        {
            maHang = maHang;
            this.tenHang = tenHang;
            this.hangSanxuat = hangSanxuat;
            this.thoigianBaoHanh = thoigianBaoHanh;
            this.donGia = donGia;
        }
        public void nhapMaHang()
        {
            Console.Write(" nhap ma hang ");
            maHang = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap ten hang ");
            tenHang = Console.ReadLine();
            Console.Write(" nhap hang san xuat ");
            hangSanxuat = Console.ReadLine();
            Console.Write(" nhap thoi gian bao hanh ");
            thoigianBaoHanh = int.Parse(Console.ReadLine());
            Console.Write(" nhap don gia ");
            donGia = double.Parse(Console.ReadLine());


        }
        public void xuatMathang()
        {
            Console.WriteLine(" Ma hang: " + maHang);
            Console.WriteLine(" Ten hang : " + tenHang);
            Console.WriteLine("Hang san xuat: " + hangSanxuat);
            Console.WriteLine(" Thoi gian bao hanh: " + thoigianBaoHanh);
            Console.WriteLine(" Don gia: " + donGia);
        }
        public double getDonGia()
        {
            return this.donGia;
        }

    }
}
