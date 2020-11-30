using QuanlycuahangbanQuanAo.Bussiness;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuanlycuahangbanQuanAo.DataAccess
{
    class CTHDNDAL
    {
        public static void Docfile()
        {
            StreamReader streamReader = new StreamReader("CTHDN.txt");
            string line;

            while ((line = streamReader.ReadLine()) != null)
            {
                if (line == " ") break;

                NhapCTHDN.cthdns.Add(new ChiTietHoaDonNhap(line.Split(';')[0], line.Split(';')[1], line.Split(';')[2], int.Parse(line.Split(';')[3]), double.Parse(line.Split(';')[4]), line.Split(';')[5]));

            }
            streamReader.Close();

        }
        public static void Ghifile()
        {
            StreamWriter streamWriter = new StreamWriter("CTHDN.txt");
            foreach (ChiTietHoaDonNhap hdn in NhapCTHDN.cthdns)
            {
                streamWriter.WriteLine(hdn.ToString());
            }
            streamWriter.Close();
        }
    }
}
