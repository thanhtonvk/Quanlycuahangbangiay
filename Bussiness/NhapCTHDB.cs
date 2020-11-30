using QuanlycuahangbanQuanAo.DataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuanlycuahangbanQuanAo.Bussiness
{
    class NhapCTHDB
    {
        public static ArrayList cthdbs = new ArrayList();
        public static void Them()
        {
            Console.WriteLine(" _____________________________________________________");
            Console.WriteLine("|               Nhập chi tiết hóa đơn bán             ");
            Console.WriteLine(" _____________________________________________________");
                Console.Write("|            Nhập mã chi tiết hóa đơn bán: ");
            string maCTHDB=Console.ReadLine();
                Console.Write("|            Nhập mã hóa đơn bán: ");
            string maHDB=Console.ReadLine();
                Console.Write("|            Nhập mã quần áo: ");
            string maQuanAo=Console.ReadLine();
                Console.Write("|            Nhập số lượng: ");
            int soLuong=int.Parse(Console.ReadLine());
                Console.Write("|            Nhập đơn giá bán: ");
            double donGiaBan=double.Parse(Console.ReadLine());
                Console.Write("|            Nhập đơn vị tính: ");
            string donViTinh=Console.ReadLine();
            Console.WriteLine(" _____________________________________________________");
            ChiTietHoaDonBan hdb = new ChiTietHoaDonBan(maCTHDB, maHDB, maQuanAo, soLuong, donGiaBan, donViTinh);
            cthdbs.Add(hdb);
        }
        public static void Hien()
        {
            Console.WriteLine("{0,15}|{1,15}|{2,15}|{3,15}|{4,20}|{5,20}|{6,15}","Ma CTHDB","Ma HDB","Ma QuanAo","So Luong","Don Gia Ban","Don Vi Tinh","Thanh Tien");
            foreach(ChiTietHoaDonBan hdb in cthdbs)
            {
                Console.WriteLine("{0,15}|{1,15}|{2,15}|{3,15}|{4,20}|{5,20}|{6,15}", hdb.MaCTHDB,hdb.MaHDB,hdb.MaQuanAo,hdb.SoLuong,hdb.DonGiaBan,hdb.DonViTinh,hdb.ThanhTien(hdb.SoLuong, hdb.DonGiaBan));
            }    
        }

    }
}
