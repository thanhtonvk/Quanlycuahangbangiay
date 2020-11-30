using QuanlycuahangbanQuanAo.Bussiness;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuanlycuahangbanQuanAo.DataAccess
{
    class MauQuanAoDAL
    {
        public static void Docfile()
        {
            StreamReader streamReader = new StreamReader("MauQuanAo.txt");
            string line;

            while ((line = streamReader.ReadLine()) != null)
            {
                if (line == " ") break;

                NhapMauQuanAo.mauQuanAos.Add(new MauQuanAo(line.Split(';')[0], line.Split(';')[1], line.Split(';')[2], int.Parse(line.Split(';')[3]), int.Parse(line.Split(';')[4])));

            }
            streamReader.Close();
        }
        public static void Ghifile()
        {
            StreamWriter streamWriter = new StreamWriter("MauQuanAo.txt");
            foreach (MauQuanAo mg in NhapMauQuanAo.mauQuanAos)
            {
                streamWriter.WriteLine(mg.ToString());
            }
            streamWriter.Close();
        }
    }
}
