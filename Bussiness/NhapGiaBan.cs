using QuanlycuahangbanQuanAo.DataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuanlycuahangbanQuanAo.Bussiness
{
    class NhapGiaBan
    {
        public static ArrayList giabans = new ArrayList();
        public static void Them()
        {
            Console.WriteLine(" _____________________________________________________");
            Console.WriteLine("|               Nhập giá quần áo                         |");
            Console.WriteLine(" _____________________________________________________");
            Console.Write("|               Nhập mã giá bán: ");
            string maGiaBan=Console.ReadLine();
            Console.Write("|                mã quần áo: ");
            string maQuanAo=Console.ReadLine();
            Console.Write("|                giá bán quần áo: ");
            double giaBanQuanAo=double.Parse(Console.ReadLine());
            Console.Write("|               Nhập đơn vị tính: ");
            string donvitinh = Console.ReadLine();
            Console.WriteLine(" _____________________________________________________");
            GiaBan gb = new GiaBan(maGiaBan, maQuanAo, giaBanQuanAo, donvitinh);
            giabans.Add(gb);
        }
        public static void Hien()
        {
            Console.WriteLine("{0,15}|{1,15}|{2,20}|{3,20}","Ma gia ban","Ma QuanAo","Gia ban QuanAo","Don vi tinh");
            foreach(GiaBan gb in giabans)
            {
                Console.WriteLine("{0,15}|{1,15}|{2,20}|{3,20}", gb.MaGiaBan,gb.MaQuanAo,gb.GiaBanQuanAo,gb.DonViTinh);
            }    
        }
        public static void Tim(string ma)
        {
            foreach (GiaBan gb in giabans)
            {
                if(ma.Equals(gb.MaQuanAo))
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", gb.MaGiaBan, gb.MaQuanAo, gb.GiaBanQuanAo, gb.DonViTinh);
                }    
            }
        }
    }
}
