using QuanlycuahangbanQuanAo.Bussiness;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuanlycuahangbanQuanAo.DataAccess
{
    class LoaiQuanAoDAL
    {
        public static void Docfile()
        {
            StreamReader streamReader = new StreamReader("LoaiQuanAo.txt");
            string line;

            while ((line = streamReader.ReadLine()) != null)
            {
                if (line == " ") break;

                NhapLoaiQuanAo.loaiQuanAos.Add(new LoaiQuanAo(line.Split(';')[0], line.Split(';')[1], line.Split(';')[2]));

            }
            streamReader.Close();
        }
        public static void Ghifile()
        {
            StreamWriter streamWriter = new StreamWriter("LoaiQuanAo.txt");
            foreach (LoaiQuanAo lg in NhapLoaiQuanAo.loaiQuanAos)
            {
                streamWriter.WriteLine(lg.ToString());
            }
            streamWriter.Close();
        }
    }
}
