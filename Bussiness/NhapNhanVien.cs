using QuanlycuahangbanQuanAo.DataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuanlycuahangbanQuanAo.Bussiness
{
    class NhapNhanVien
    {
        public static ArrayList nhanviens = new ArrayList();
        public static void Them()
        {
            Console.WriteLine(" _____________________________________________________");
            Console.WriteLine("|                   Nhập nhân viên                    |");
            Console.WriteLine(" _____________________________________________________");
            Console.Write("|                   Nhập mã nhân viên: ");
            string manv = Console.ReadLine();
            Console.Write("|                   Nhập tên nhân viên: ");
            string tennv = Console.ReadLine();
            Console.Write("|                   Nhập ngày sinh: ");
            string ngaysinh = Console.ReadLine();
            Console.Write("|                   Nhập giới tính: ");
            string gioitinh = Console.ReadLine();
            Console.Write("|                   Nhập ngày vào làm việc: ");
            string ngayvaolv = Console.ReadLine();
            Console.Write("|                   Nhập loại nhân viên: ");
            string loainv = Console.ReadLine();
            Console.WriteLine(" _____________________________________________________");
            NhanVien nv = new NhanVien(manv, tennv, ngaysinh, gioitinh, ngayvaolv, loainv);
            nhanviens.Add(nv);
        }
        public static void Hien()
        {
            Console.WriteLine("{0,10}|{1,25}|{2,15}|{3,10}|{4,15}|{5,15}","Mã nhân viên","Tên nhân viên","Ngày sinh","Giới tính","Ngày vào LV","Loai NV");
            foreach(NhanVien nv in nhanviens)
            {
                Console.WriteLine("{0,10}|{1,25}|{2,15}|{3,10}|{4,15}|{5,15}", nv.MaNV,nv.TenNV,nv.NgaySinh,nv.GioiTinh,nv.NgayVaoLV,nv.LoaiNV);
            }    
        }
        public static void Xoa(string ma)
        {
            int i = 0;
            bool kt = false;
            foreach (NhanVien nv in nhanviens)
            {
                if(ma.Equals(nv.MaNV))
                {
                    kt = true;
                    break;
                }
                else
                {
                    i++;
                }
            }
            if(kt)
            {
                nhanviens.RemoveAt(i);
                Console.WriteLine("Xóa thành công");
            }
        }
        public static void Tim(string ma)
        {
            Console.WriteLine("{0,10}|{1,25}|{2,15}|{3,10}|{4,15}|{5,15}", "Mã nhân viên", "Tên nhân viên", "Ngày sinh", "Giới tính", "Ngày vào LV", "Loai NV");
            foreach (NhanVien nv in nhanviens)
            {
                if(ma.Equals(nv.MaNV))
                {
                    Console.WriteLine("{0,10}|{1,25}|{2,15}|{3,10}|{4,15}|{5,15}", nv.MaNV, nv.TenNV, nv.NgaySinh, nv.GioiTinh, nv.NgayVaoLV, nv.LoaiNV);
                }
            }    
        }
    }
}
