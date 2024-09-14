using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt1
{
    class Program
    {
        static void Main(string[] args)
        {
            int soLuong;
            decimal giaSanPham;
            decimal tongGiaTriDonHang;
            try
            {

                Console.Write("nhap so luong san pham : ");
                soLuong = Int32.Parse(Console.ReadLine());

                Console.Write("nhap gia cua mot san pham : ");
                giaSanPham = decimal.Parse(Console.ReadLine());


                tongGiaTriDonHang = soLuong * giaSanPham;
                Console.Write("tong gia tri don hang : " + tongGiaTriDonHang);
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("nhap sai.");
                Console.ReadLine();
            }
            
        }
    }
}
