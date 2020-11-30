using QuanlycuahangbanQuanAo.Bussiness;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuanlycuahangbanQuanAo.DataAccess
{
    class HoaDonBanDAL
    {
        public static void Docfile()
        {
            StreamReader streamReader = new StreamReader("HoaDonBan.txt");
            string line;

            while ((line = streamReader.ReadLine()) != null)
            {
                if (line == " ") break;

                NhapHoaDonBan.hoadonbans.Add(new HoaDonBan(line.Split(';')[0], line.Split(';')[1], line.Split(';')[2], double.Parse(line.Split(';')[3])));

            }
            streamReader.Close();
        }
        public static void Ghifile()
        {
            StreamWriter streamWriter = new StreamWriter("HoaDonBan.txt");
            foreach (HoaDonBan hdb in NhapHoaDonBan.hoadonbans)
            {
                streamWriter.WriteLine(hdb.ToString());
            }
            streamWriter.Close();
        }
    }
}
