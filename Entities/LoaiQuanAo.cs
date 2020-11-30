using System;
using System.Collections.Generic;
using System.Text;

namespace QuanlycuahangbanQuanAo.DataAccess
{
    class LoaiQuanAo
    {
        string maQuanAo;
        string tenQuanAo;
        string dacDiem;
        override
            public string ToString()
        {
            return maQuanAo + ";" + tenQuanAo + ";" + dacDiem;
        }
        public string MaQuanAo { get => maQuanAo; set => maQuanAo = value; }
        public string TenQuanAo { get => tenQuanAo; set => tenQuanAo = value; }
        public string DacDiem { get => dacDiem; set => dacDiem = value; }
        public LoaiQuanAo(string maQuanAo, string tenQuanAo, string dacDiem)
        {
            this.maQuanAo = maQuanAo;
            this.tenQuanAo = tenQuanAo;
            this.dacDiem = dacDiem;
        }
    }
}
