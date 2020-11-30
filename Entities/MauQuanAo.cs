using System;
using System.Collections.Generic;
using System.Text;

namespace QuanlycuahangbanQuanAo.DataAccess
{
    class MauQuanAo
    {
        string maQuanAo;
        string tenQuanAo;
        string maLoai;
        int slNhapve;
        int slHienco;
        public MauQuanAo(string maQuanAo,string tenQuanAo,string maLoai,int slNhapve,int slHienco)
        {
            this.maQuanAo = maQuanAo;
            this.tenQuanAo = tenQuanAo;
            this.maLoai = maLoai;
            this.slNhapve = slNhapve;
            this.slHienco = slHienco;
        }
        override
            public string ToString()
        {
            return maQuanAo + ";" + tenQuanAo + ";" + maLoai + ";" + slNhapve + ";" + slHienco;
        }
        public string MaQuanAo { get => maQuanAo; set => maQuanAo = value; }
        public string TenQuanAo { get => tenQuanAo; set => tenQuanAo = value; }
        public string MaLoai { get => maLoai; set => maLoai = value; }
        public int SlNhapve { get => slNhapve; set => slNhapve = value; }
        public int SlHienco { get => slHienco; set => slHienco = value; }
    }
}
