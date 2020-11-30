using QuanlycuahangbanQuanAo.DataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuanlycuahangbanQuanAo.Bussiness
{
    class NhapLoaiQuanAo
    {
        public static ArrayList loaiQuanAos = new ArrayList();
        public static void them()
        {
            Console.WriteLine(" _____________________________________________________");
            Console.WriteLine("|                   Nhập loại quần áo                    |");
            Console.WriteLine(" _____________________________________________________");
            Console.Write("|                   Nhập mã quần áo: ");
            string maQuanAo = Console.ReadLine();
            Console.Write("|                   Nhập tên quần áo: ");
            string tenQuanAo = Console.ReadLine();
            Console.Write("|                   Nhập đặc điểm: ");
            string dacdiem = Console.ReadLine();
            Console.WriteLine(" _____________________________________________________");
            LoaiQuanAo lg = new LoaiQuanAo(maQuanAo, tenQuanAo, dacdiem);
            loaiQuanAos.Add(lg);
        }
        public static void Hien()
        {
            Console.WriteLine("{0,10}|{1,10}|{2,20}","Mã giày","Tên giày","Đặc điểm");
            foreach(LoaiQuanAo lg in loaiQuanAos)
            {
                Console.WriteLine("{0,10}|{1,10}|{2,20}", lg.MaQuanAo, lg.TenQuanAo, lg.DacDiem);
            }    
        }


    }
}
