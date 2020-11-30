using QuanlycuahangbanQuanAo.Bussiness;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuanlycuahangbanQuanAo.DataAccess
{
    class NhanVienDAL
    {
        public static void Docfile()
        {
            StreamReader streamReader = new StreamReader("NhanVien.txt");
            string line;

            while ((line = streamReader.ReadLine()) != null)
            {
                if (line == " ") break;

                NhapNhanVien.nhanviens.Add(new NhanVien(line.Split(';')[0], line.Split(';')[1], line.Split(';')[2], line.Split(';')[3], line.Split(';')[4], line.Split(';')[5]));

            }
            streamReader.Close();
        }
        public static void Ghifile()
        {
            StreamWriter streamWriter = new StreamWriter("NhanVien.txt");
            foreach (NhanVien nv in NhapNhanVien.nhanviens)
            {
                streamWriter.WriteLine(nv.ToString());
            }
            streamWriter.Close();
        }
    }
}
