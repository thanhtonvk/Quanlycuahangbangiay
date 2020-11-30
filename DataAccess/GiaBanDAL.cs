using QuanlycuahangbanQuanAo.Bussiness;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuanlycuahangbanQuanAo.DataAccess
{
    class GiaBanDAL
    {
        public static void Docfile()
        {
            StreamReader streamReader = new StreamReader("GiaBan.txt");
            string line;

            while ((line = streamReader.ReadLine()) != null)
            {
                if (line == " ") break;

                NhapGiaBan.giabans.Add(new GiaBan(line.Split(';')[0], line.Split(';')[1], double.Parse(line.Split(';')[2]), line.Split(';')[3]));

            }
            streamReader.Close();
        }
        public static void Ghifile()
        {
            StreamWriter streamWriter = new StreamWriter("GiaBan.txt");
            foreach (GiaBan gb in NhapGiaBan.giabans)
            {
                streamWriter.WriteLine(gb.ToString());
            }
            streamWriter.Close();
        }
    }
}
