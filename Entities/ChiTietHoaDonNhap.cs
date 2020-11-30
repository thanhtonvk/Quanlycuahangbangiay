using System;
using System.Collections.Generic;
using System.Text;

namespace QuanlycuahangbanQuanAo.DataAccess
{
    class ChiTietHoaDonNhap
    {
        string maCTHDN;
        string maHDN;
        string maQuanAo;
        int soLuong;
        double donGiaNhap;
        string vAT;
        public ChiTietHoaDonNhap(string maCTHDN, string maHDN, string maQuanAo, int soLuong, double donGiaNhap, string vAT)
        {
            this.maCTHDN = maCTHDN;
            this.maHDN = maHDN;
            this.maQuanAo = maQuanAo;
            this.soLuong = soLuong;
            this.donGiaNhap = donGiaNhap;
            this.vAT = vAT;
        }
        override
            public string ToString()
        {
            return maCTHDN+ ";" + maHDN+ ";" + maQuanAo+ ";" + soLuong+ ";" + donGiaNhap+ ";" + vAT;
        }
        public string MaCTHDN { get => maCTHDN; set => maCTHDN = value; }
        public string MaHDN { get => maHDN; set => maHDN = value; }
        public string MaQuanAo { get => maQuanAo; set => maQuanAo = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double DonGiaNhap { get => donGiaNhap; set => donGiaNhap = value; }
        public string VAT { get => vAT; set => vAT = value; }

        public double ThanhTien(int SoLuong,double DongiaNhap)
        {
            return SoLuong * DongiaNhap;
        }
    }
}
