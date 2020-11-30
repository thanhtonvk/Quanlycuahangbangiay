using System;
using System.Collections.Generic;
using System.Text;

namespace QuanlycuahangbanQuanAo.DataAccess
{
    class ChiTietHoaDonBan
    {
        string maCTHDB;
        string maHDB;
        string maQuanAo;
        int soLuong;
        double donGiaBan;
        string donViTinh;
        public ChiTietHoaDonBan(string maCTHDB,string maHDB,string maQuanAo,int soLuong,double donGiaBan,string donViTinh)
        {
            this.maCTHDB = maCTHDB;
            this.maHDB = maHDB;
            this.maQuanAo = maQuanAo;
            this.soLuong = soLuong;
            this.donGiaBan = donGiaBan;
            this.donViTinh = donViTinh;
        }
        override
            public string ToString()
        {
            return maCTHDB + ";" + ";" + maHDB+ ";"+ maQuanAo+ ";" + soLuong+ ";" + donGiaBan+ ";" + donViTinh;
        }
        public string MaCTHDB { get => maCTHDB; set => maCTHDB = value; }
        public string MaHDB { get => maHDB; set => maHDB = value; }
        public string MaQuanAo { get => maQuanAo; set => maQuanAo = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double DonGiaBan { get => donGiaBan; set => donGiaBan = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public double ThanhTien(int soLuong,double donGiaBan)
        {
            return soLuong * donGiaBan;
        }
    }
}
