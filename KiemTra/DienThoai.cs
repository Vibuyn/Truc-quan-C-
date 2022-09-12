using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra
{
    class DienThoai : MaHang
    {
        private string HeDieuHanh;

        public DienThoai() : base
            {

            }

        public DienThoai(int maHang, string tenHang, string hangSanxuat, int thoigianBaoHanh, double donGia) : base(maHang, tenHang, hangSanxuat, thoigianBaoHanh, donGia)
        {

        }
        public void NhapDienThoai()
        {
            base.nhapMaHang();
            Console.Write(" nhap He dieu hanh ");
            HeDieuHanh = Console.ReadLine();
        }
        public void xuatDienThoai()
        {
            base.xuatMathang();
            Console.WriteLine("He dieu hanh: " + HeDieuHanh);
        }
        public double getDonGia()
        {
            return this.DonGia;
        }
    }
}
