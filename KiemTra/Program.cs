using KiemTra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            App app = new App();
            app.nhap();
            app.timDienThoaiDonGia();
            app.timDienThoaiDatNhat();
            Console.ReadLine();
        }
    }
}
