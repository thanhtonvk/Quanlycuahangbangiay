using QuanlycuahangbanQuanAo.DataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuanlycuahangbanQuanAo.Bussiness
{
    class NhapCTHDN
    {
        public static ArrayList cthdns = new ArrayList(); // Mảng chi tiết hóa đơn nhập
        public static void Them()
        {
            Console.WriteLine(" _____________________________________________________");
            Console.WriteLine("|               Nhập chi tiết hóa đươn nhập            |");
            Console.WriteLine(" _____________________________________________________");
            Console.Write("|            Nhập mã chi tiết hóa đơn nhập: ");
            string maCTHDN=Console.ReadLine();
            Console.Write("|            Nhập mã hóa đơn nhập: ");
            string maHDN=Console.ReadLine();
            Console.Write("|            Nhập mã quần áo: ");
            string maQuanAo=Console.ReadLine();
            Console.Write("|            Nhập số lượng: ");
            int soLuong=int.Parse(Console.ReadLine());
            Console.Write("|            Nhập đơn giá nhập: ");
            double donGiaNhap=double.Parse(Console.ReadLine());
            Console.Write("|            Nhập VAT: ");
            string vAT=Console.ReadLine();
            Console.WriteLine(" _____________________________________________________");
            ChiTietHoaDonNhap cthd = new ChiTietHoaDonNhap(maCTHDN, maHDN, maQuanAo, soLuong, donGiaNhap,vAT);
            cthdns.Add(cthd);//Thêm đối tượng vài mảng hóa đơn nhập
        }
        public static void Hien()
        {
            Console.WriteLine("{0,15}|{1,15}|{2,15}|{3,15}|{4,15}|{5,15}|{6,15}","Ma CTHD","Ma HDN","Ma QuanAo","So luong", "Don gia","Thanh tien","VAT");
            foreach(ChiTietHoaDonNhap cthd in cthdns)
            {
                Console.WriteLine("{0,15}|{1,15}|{2,15}|{3,15}|{4,15}|{5,15}|{6,15}", cthd.MaCTHDN, cthd.MaHDN, cthd.MaQuanAo, cthd.SoLuong, cthd.DonGiaNhap, cthd.ThanhTien(cthd.SoLuong, cthd.DonGiaNhap), cthd.VAT);
            }    
        }

    }
}
