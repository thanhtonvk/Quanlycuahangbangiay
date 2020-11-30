using QuanlycuahangbanQuanAo.Bussiness;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuanlycuahangbanQuanAo.DataAccess
{
    class CTHDBDAL
    {
        public static void Docfile()
        {
            StreamReader streamReader = new StreamReader("CTHDB.txt");
            string line;

            while ((line = streamReader.ReadLine()) != null)
            {
                if (line == " ") break;

                NhapCTHDB.cthdbs.Add(new ChiTietHoaDonBan(line.Split(";")[0], line.Split(";")[1], line.Split(";")[2], int.Parse(line.Split(";")[3]), double.Parse(line.Split(";")[4]), line.Split(";")[5]));

            }
            streamReader.Close();
        }
        public static void Ghifile()
        {
            StreamWriter streamWriter = new StreamWriter("CTHDB.txt");
            foreach (ChiTietHoaDonBan hdb in NhapCTHDB.cthdbs)
            {
                streamWriter.WriteLine(hdb.ToString());
            }
            streamWriter.Close();
        }
    }
}
