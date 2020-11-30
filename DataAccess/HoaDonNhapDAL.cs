using QuanlycuahangbanQuanAo.Bussiness;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuanlycuahangbanQuanAo.DataAccess
{
    class HoaDonNhapDAL
    {
        public static void Docfile()
        {
            StreamReader streamReader = new StreamReader("HoaDonNhap.txt");
            string line;

            while ((line = streamReader.ReadLine()) != null)
            {
                if (line == " ") break;

                NhapHoaDonNhap.hoadonnhaps.Add(new HoaDonNhap(line.Split(';')[0], line.Split(';')[1], line.Split(';')[2], line.Split(';')[3], line.Split(';')[4], double.Parse(line.Split(';')[5]), line.Split(';')[6], double.Parse(line.Split(';')[7]), double.Parse(line.Split(';')[8]), line.Split(';')[9]));

            }
            streamReader.Close();
        }
        public static void Ghifile()
        {
            StreamWriter streamWriter = new StreamWriter("HoaDonNhap.txt");
            foreach (HoaDonNhap hdn in NhapHoaDonNhap.hoadonnhaps)
            {
                streamWriter.WriteLine(hdn.ToString());
            }
            streamWriter.Close();
        }
    }
}
