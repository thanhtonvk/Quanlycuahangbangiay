using System;
using System.Collections.Generic;
using System.Text;

namespace QuanlycuahangbanQuanAo.DataAccess
{
    class GiaBan
    {
        string maGiaBan;
        string maQuanAo;
        double giaBanQuanAo;
        string donViTinh;
        public GiaBan(string maGiaBan,string maQuanAo, double giaBanQuanAo,string donViTinh)
        {
            this.maGiaBan = maGiaBan;
            this.maQuanAo = maQuanAo;
            this.giaBanQuanAo = giaBanQuanAo;
            this.donViTinh = donViTinh;
           
        }
        override
            public string ToString()
        {
            return maGiaBan + ";" + maQuanAo + ";" + giaBanQuanAo + ";" + donViTinh;
        }
        public string MaGiaBan { get => maGiaBan; set => maGiaBan = value; }
        public string MaQuanAo { get => maQuanAo; set => maQuanAo = value; }
        public double GiaBanQuanAo { get => giaBanQuanAo; set => giaBanQuanAo = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
    }
}
