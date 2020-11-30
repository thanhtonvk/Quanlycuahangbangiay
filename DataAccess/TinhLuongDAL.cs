using QuanlycuahangbanQuanAo.Bussiness;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuanlycuahangbanQuanAo.DataAccess
{
    class TinhLuongDAL
    {
        public static void Docfile()
        {
            StreamReader streamReader = new StreamReader("TinhLuong.txt");
            string line;

            while ((line = streamReader.ReadLine()) != null)
            {
                if (line == " ") break;

                NhapTinhLuong.tinhluongs.Add(new TinhLuong(line.Split(';')[0], line.Split(';')[1], double.Parse(line.Split(';')[2]), double.Parse(line.Split(';')[3]), double.Parse(line.Split(';')[4])));

            }
            streamReader.Close();
        }
        public static void Ghifile()
        {
            StreamWriter streamWriter = new StreamWriter("TinhLuong.txt");
            foreach (TinhLuong tl in NhapTinhLuong.tinhluongs)
            {
                streamWriter.WriteLine(tl.ToString());
            }
            streamWriter.Close();
        }
    }
}
