using QuanlycuahangbanQuanAo.DataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuanlycuahangbanQuanAo.Bussiness
{
    class NhapMauQuanAo
    {
        public static ArrayList mauQuanAos = new ArrayList();
        public static void Them()
        {
            Console.WriteLine(" _____________________________________________________");
            Console.WriteLine("|                   Nhập mẫu quần áo                     |");
            Console.WriteLine(" _____________________________________________________");
            Console.Write("|                   Nhập mã quần áo: ");
            string maQuanAo = Console.ReadLine();
            Console.Write("|                   Nhập tên quần áo: ");
            string tenQuanAo = Console.ReadLine();
            Console.Write("|                   Nhập mã loại quần áo: ");
            string maloai = Console.ReadLine();
            Console.Write("|                    số lượng nhập: ");
            int slNhap = int.Parse(Console.ReadLine());
            Console.Write("|                   Nhập số lượng hiện có: ");
            int slHienco = int.Parse(Console.ReadLine());
            Console.WriteLine(" _____________________________________________________");
            MauQuanAo mg = new MauQuanAo(maQuanAo, tenQuanAo, maloai, slNhap, slHienco);
            mauQuanAos.Add(mg);
        }
        public static void Hien()
        {
            Console.WriteLine("{0,10}|{1,10}|{2,10}|{3,20}|{4,20}","Ma QuanAo","Ten QuanAo","Ma Loai","So luong nhap","So luong hien co");
            foreach(MauQuanAo mg in mauQuanAos)
            {
                Console.WriteLine("{0,10}|{1,10}|{2,10}|{3,20}|{4,20}", mg.MaQuanAo, mg.TenQuanAo, mg.MaLoai, mg.SlNhapve, mg.SlHienco);
            }    
        }
    }
}
