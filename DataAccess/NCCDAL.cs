using QuanlycuahangbanQuanAo.Bussiness;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuanlycuahangbanQuanAo.DataAccess
{
    class NCCDAL
    {
        public static void Docfile()
        {
            StreamReader streamReader = new StreamReader("NhaCungCap.txt");
            string line;

            while ((line = streamReader.ReadLine()) != null)
            {
                if (line == " ") break;

                NhapNCC.nccs.Add(new NCC(line.Split(';')[0], line.Split(';')[1], line.Split(';')[2], line.Split(';')[3]));

            }
            streamReader.Close();
        }
        public static void Ghifile()
        {
            StreamWriter streamWriter = new StreamWriter("NhaCungCap.txt");
            foreach (NCC nc in NhapNCC.nccs)
            {
                streamWriter.WriteLine(nc.ToString());
            }
            streamWriter.Close();
        }
    }
}
